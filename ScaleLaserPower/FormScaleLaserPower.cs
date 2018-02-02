using System;
using System.Windows.Forms;

namespace ScaleLaserPower
{
    public partial class FormScaleLaserPower : Form
    {
        private FileHandler fileHandler;

        public FormScaleLaserPower()
        {
            InitializeComponent();
        }

        private void btnScaleTo100_Click(object sender, EventArgs e)
        {
            if (fileHandler.IsReady)
            {
                btnScaleTo100.Enabled = false;
                var scaleLaserPower = new ScaleLaserPower(this.fileHandler);
                scaleLaserPower.ScaleTo100();
                SetStatusBar("Finished scaling (" + fileHandler.OutputFileName + ")");
                btnScaleTo100.Enabled = true;
            }
        }

        private void openToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialogGcode.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.fileHandler = new FileHandler(openFileDialogGcode.FileName);
                this.textBoxGcode.Text = this.fileHandler.ReadAllLines();
                SetStatusBar("Opened gcode file (" + fileHandler.InputFileName + ")");
            }
        }

        private void SetStatusBar(string text)
        {
            this.toolStripStatusLabel.Text = text;
            ClearStatusBar(5);
        }

        private void ClearStatusBar(int seconds)
        {
            var t = new Timer();
            t.Interval = seconds * 1000;
            t.Tick += (s, e) =>
            {
                this.toolStripStatusLabel.Text = string.Empty;
                t.Stop();
            };
            t.Start();
        }
    }
}
