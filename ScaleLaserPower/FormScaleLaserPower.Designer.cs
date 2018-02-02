namespace ScaleLaserPower
{
    partial class FormScaleLaserPower
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxGcode = new System.Windows.Forms.TextBox();
            this.btnScaleTo100 = new System.Windows.Forms.Button();
            this.openFileDialogGcode = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxGcode
            // 
            this.textBoxGcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGcode.Location = new System.Drawing.Point(0, 24);
            this.textBoxGcode.Multiline = true;
            this.textBoxGcode.Name = "textBoxGcode";
            this.textBoxGcode.ReadOnly = true;
            this.textBoxGcode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxGcode.Size = new System.Drawing.Size(1155, 713);
            this.textBoxGcode.TabIndex = 0;
            this.textBoxGcode.WordWrap = false;
            // 
            // btnScaleTo100
            // 
            this.btnScaleTo100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScaleTo100.Location = new System.Drawing.Point(1008, 685);
            this.btnScaleTo100.Name = "btnScaleTo100";
            this.btnScaleTo100.Size = new System.Drawing.Size(126, 29);
            this.btnScaleTo100.TabIndex = 1;
            this.btnScaleTo100.Text = "Scale to 100";
            this.btnScaleTo100.UseVisualStyleBackColor = true;
            this.btnScaleTo100.Click += new System.EventHandler(this.btnScaleTo100_Click);
            // 
            // openFileDialogGcode
            // 
            this.openFileDialogGcode.DefaultExt = "gcode";
            this.openFileDialogGcode.FileName = "openFileDialog1";
            this.openFileDialogGcode.Filter = "gcode files|*.gcode";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItemOpen});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItemOpen
            // 
            this.openToolStripMenuItemOpen.Name = "openToolStripMenuItemOpen";
            this.openToolStripMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItemOpen.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItemOpen.Text = "Open";
            this.openToolStripMenuItemOpen.Click += new System.EventHandler(this.openToolStripMenuItemOpen_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 715);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1155, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // FormScaleLaserPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 737);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnScaleTo100);
            this.Controls.Add(this.textBoxGcode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormScaleLaserPower";
            this.Text = "Scale Laser Power";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGcode;
        private System.Windows.Forms.Button btnScaleTo100;
        private System.Windows.Forms.OpenFileDialog openFileDialogGcode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItemOpen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

