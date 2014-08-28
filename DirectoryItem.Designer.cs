namespace PlantLocator
{
    partial class DirectoryItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directoryButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // directoryButton
            // 
            this.directoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.directoryButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.directoryButton.Location = new System.Drawing.Point(0, 0);
            this.directoryButton.Margin = new System.Windows.Forms.Padding(0);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(125, 30);
            this.directoryButton.TabIndex = 0;
            this.directoryButton.Text = "directory_name";
            this.directoryButton.UseSelectable = true;
            this.directoryButton.Click += new System.EventHandler(this.directoryButton_Click);
            // 
            // DirectoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.directoryButton);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Name = "DirectoryItem";
            this.Size = new System.Drawing.Size(125, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton directoryButton;
    }
}
