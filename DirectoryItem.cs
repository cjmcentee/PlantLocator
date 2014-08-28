using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.IO;

namespace PlantLocator
{
    public partial class DirectoryItem : MetroUserControl
    {
        private DirectoryInfo directory;
        public DirectoryInfo Directory
        {
            get
            {
                return directory;
            }
            set
            {
                // Null directory deletes the item
                if (value == null) {
                    this.Parent = null;
                    this.Dispose();
                }
                else {
                    directory = value;
                    this.directoryButton.Text = directory.Name;
                }
            }
        }

        public DirectoryItem()
        {
            InitializeComponent();
        }

        private void directoryButton_Click(object sender, EventArgs e)
        {
            if (SelectDirectory != null)
                SelectDirectory(this, new SelectDirectoryEventArgs(directory));
        }

        public event SelectDirectoryEventHandler SelectDirectory;
    }

    public delegate void SelectDirectoryEventHandler(object sender, SelectDirectoryEventArgs e);
    public class SelectDirectoryEventArgs : EventArgs
    {
        public DirectoryInfo Directory;

        public SelectDirectoryEventArgs(DirectoryInfo directory)
        {
            Directory = new DirectoryInfo(directory.FullName);
        }
    }
}
