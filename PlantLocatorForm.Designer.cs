namespace PlantLocator
{
    partial class PlantLocatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.stateFilesList = new System.Windows.Forms.FlowLayoutPanel();
            this.stateGrid = new System.Windows.Forms.DataGridView();
            this.stateFileDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsList = new System.Windows.Forms.FlowLayoutPanel();
            this.loadFolderButton = new MetroFramework.Controls.MetroButton();
            this.exportAllButton = new MetroFramework.Controls.MetroButton();
            this.saveExcelFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.buttonsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.stateFilesList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.stateGrid);
            this.splitContainer1.Size = new System.Drawing.Size(920, 345);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 0;
            // 
            // stateFilesList
            // 
            this.stateFilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateFilesList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.stateFilesList.Location = new System.Drawing.Point(0, 0);
            this.stateFilesList.Name = "stateFilesList";
            this.stateFilesList.Size = new System.Drawing.Size(186, 345);
            this.stateFilesList.TabIndex = 0;
            // 
            // stateGrid
            // 
            this.stateGrid.AllowUserToResizeRows = false;
            this.stateGrid.BackgroundColor = System.Drawing.Color.White;
            this.stateGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.stateGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stateGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.stateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stateGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.stateGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateGrid.EnableHeadersVisualStyles = false;
            this.stateGrid.Location = new System.Drawing.Point(0, 0);
            this.stateGrid.Name = "stateGrid";
            this.stateGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stateGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.stateGrid.RowHeadersVisible = false;
            this.stateGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
            this.stateGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stateGrid.Size = new System.Drawing.Size(730, 345);
            this.stateGrid.TabIndex = 0;
            this.stateGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stateGrid_ColumnHeaderMouseClick);
            // 
            // stateFileDirectoryDialog
            // 
            this.stateFileDirectoryDialog.SelectedPath = "C:\\Development\\DDPSC\\PlantLocator\\test objects";
            this.stateFileDirectoryDialog.ShowNewFolderButton = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonsList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 391);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonsList
            // 
            this.buttonsList.Controls.Add(this.loadFolderButton);
            this.buttonsList.Controls.Add(this.exportAllButton);
            this.buttonsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsList.Location = new System.Drawing.Point(3, 354);
            this.buttonsList.Name = "buttonsList";
            this.buttonsList.Size = new System.Drawing.Size(920, 34);
            this.buttonsList.TabIndex = 1;
            // 
            // loadFolderButton
            // 
            this.loadFolderButton.AutoSize = true;
            this.loadFolderButton.Location = new System.Drawing.Point(3, 3);
            this.loadFolderButton.Name = "loadFolderButton";
            this.loadFolderButton.Size = new System.Drawing.Size(80, 23);
            this.loadFolderButton.Style = MetroFramework.MetroColorStyle.Green;
            this.loadFolderButton.TabIndex = 0;
            this.loadFolderButton.Text = "Load Folder";
            this.loadFolderButton.UseSelectable = true;
            this.loadFolderButton.Click += new System.EventHandler(this.loadFolderButton_Click);
            // 
            // exportAllButton
            // 
            this.exportAllButton.AutoSize = true;
            this.exportAllButton.Location = new System.Drawing.Point(89, 3);
            this.exportAllButton.Name = "exportAllButton";
            this.exportAllButton.Size = new System.Drawing.Size(75, 23);
            this.exportAllButton.Style = MetroFramework.MetroColorStyle.Green;
            this.exportAllButton.TabIndex = 1;
            this.exportAllButton.Text = "Export All";
            this.exportAllButton.UseSelectable = true;
            this.exportAllButton.Click += new System.EventHandler(this.exportAllButton_Click);
            // 
            // saveExcelFileDialog
            // 
            this.saveExcelFileDialog.DefaultExt = "xls";
            this.saveExcelFileDialog.Filter = "Excel|*.xls";
            // 
            // PlantLocatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PlantLocatorForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Plant Locator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stateGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.buttonsList.ResumeLayout(false);
            this.buttonsList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel stateFilesList;
        private System.Windows.Forms.FolderBrowserDialog stateFileDirectoryDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel buttonsList;
        private MetroFramework.Controls.MetroButton loadFolderButton;
        private MetroFramework.Controls.MetroButton exportAllButton;
        private System.Windows.Forms.DataGridView stateGrid;
        private System.Windows.Forms.SaveFileDialog saveExcelFileDialog;
    }
}

