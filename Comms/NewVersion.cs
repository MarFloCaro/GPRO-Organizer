using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Comms
{
    public class NewVersion : Form
    {
        private Label label1;
        private PictureBox pictSourceForge;
        private RichTextBox readmeBox;

        public NewVersion(string readme)
        {
            this.InitializeComponent();
            this.readmeBox.Text = readme;
        }

        private void pictSFClick(object sender, EventArgs e)
        {
            try
            {
                // TODO update
                Process.Start("https://sourceforge.net/projects/gpro-organizer-2/files/latest/download");
            }
            catch
            {
                int num = (int)MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void pictSourceForgeMouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictSourceForgeMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.pictSourceForge = new PictureBox();
            this.readmeBox = new RichTextBox();
            ((ISupportInitialize)this.pictSourceForge).BeginInit();
            this.SuspendLayout();
            this.label1.Dock = DockStyle.Top;
            this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.label1.Location = new Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new Size(567, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "A new version is available for download !";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.pictSourceForge.Image = (Image)Resources.Resources.sourceforge;
            this.pictSourceForge.InitialImage = (Image)null;
            this.pictSourceForge.Location = new Point(149, 59);
            this.pictSourceForge.Name = "pictSourceForge";
            this.pictSourceForge.Size = new Size(278, 57);
            this.pictSourceForge.TabIndex = 1;
            this.pictSourceForge.TabStop = false;
            this.pictSourceForge.Click += new EventHandler(this.pictSFClick);
            this.pictSourceForge.MouseLeave += new EventHandler(this.pictSourceForgeMouseLeave);
            this.pictSourceForge.MouseHover += new EventHandler(this.pictSourceForgeMouseHover);
            this.readmeBox.Dock = DockStyle.Bottom;
            this.readmeBox.Location = new Point(4, 122);
            this.readmeBox.Name = "readmeBox";
            this.readmeBox.Size = new Size(567, 365);
            this.readmeBox.TabIndex = 2;
            this.readmeBox.Text = "";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(575, 491);
            this.Controls.Add((Control)this.readmeBox);
            this.Controls.Add((Control)this.pictSourceForge);
            this.Controls.Add((Control)this.label1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = Resources.Resources.Car;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(NewVersion);
            this.Padding = new Padding(4);
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "GPro Organizer \u00B2 - New Version available !";
            this.TopMost = true;
            ((ISupportInitialize)this.pictSourceForge).EndInit();
            this.ResumeLayout(false);
        }
    }
}
