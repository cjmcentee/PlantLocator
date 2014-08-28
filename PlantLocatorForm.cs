using ExcelLibrary.SpreadSheet;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantLocator
{
    public partial class PlantLocatorForm : MetroForm
    {
        const string formName = "Plant Locator";

        DirectoryInfo stateFileSearchRootDirectory;
        List<DirectoryItem> stateFileItems;

        CartState state;


        public PlantLocatorForm()
        {
            InitializeComponent();

            stateFileItems = new List<DirectoryItem>();
        }

        void SetFormName(DateTime? date)
        {
            if (date.HasValue)
                Text = formName + " @" + date.Value.ToString("MM/dd/yyy");
            else
                Text = formName + " @Unknown Date";
            Refresh();
        }


        private void LoadStateFileFolder()
        {

            if (stateFileDirectoryDialog.ShowDialog() == DialogResult.OK) {
                if (Directory.Exists(stateFileDirectoryDialog.SelectedPath)) {
                    stateFileSearchRootDirectory = new DirectoryInfo(stateFileDirectoryDialog.SelectedPath);

                    var stateFileDirectories = stateFileSearchRootDirectory.FindStateFileFolders();

                    stateFileItems.Clear();
                    foreach (DirectoryInfo stateFileDirectory in stateFileDirectories) {
                        // New state file item to represent a folder that has files that describe the system state
                        DirectoryItem stateFileItem = new DirectoryItem();
                        stateFileItem.Directory = stateFileDirectory;
                        stateFileItem.SelectDirectory += new SelectDirectoryEventHandler(stateFileItem_SelectDirectory);

                        stateFileItems.Add(stateFileItem);
                    }

                    stateFilesList.Controls.Clear();
                    stateFilesList.Controls.AddRange(stateFileItems.ToArray());

                    foreach (DataGridViewColumn column in stateGrid.Columns)
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
        }

        private void ExportAsExcel()
        {
            if (saveExcelFileDialog.ShowDialog() == DialogResult.OK) {
                string excelFileName = saveExcelFileDialog.FileName;

                Workbook planetSystemBook = new Workbook();

                Worksheet plantSystemSheet = state.ExportToExcel();
                
                planetSystemBook.Worksheets.Add(plantSystemSheet);
                
                planetSystemBook.Save(excelFileName);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData) {
                case Keys.Control | Keys.O:
                    LoadStateFileFolder();
                    return true;

                case Keys.Control | Keys.E:
                case Keys.Control | Keys.S:
                    ExportAsExcel();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void stateFileItem_SelectDirectory(object sender, SelectDirectoryEventArgs e)
        {
            var stateFiles = e.Directory.StateFiles();

            state = CartState.Parse(e.Directory);
            SetFormName(state.time);

            stateGrid.DataSource = state.carts.ToArray();
        }

        private void loadFolderButton_Click(object sender, EventArgs e)
        {
            LoadStateFileFolder();
        }

        private void exportAllButton_Click(object sender, EventArgs e)
        {
            ExportAsExcel();
        }

        private void stateGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Column index and field index should be the same
            var sortedCarts = CartInfo.SortByFieldIndex(state.carts, e.ColumnIndex);

            stateGrid.DataSource = sortedCarts.ToArray();
        }
    }
}
