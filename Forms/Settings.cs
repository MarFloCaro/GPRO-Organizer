 
// Type: go.Forms.Settings
 
 
 

using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class Settings : Form
  {
    public bool rememberPassword;
    public bool autoCheck;
    public bool saveSettings;
    public bool warn_for_wrong_tyres;
    public bool keep_data_with_program;
    public int startingTabPage;
    private Button buttonOk;
    private Button buttonApply;
    private Button buttonCancel;
    private CheckBox checkBoxSavePassword;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Label label1;
    private ComboBox comboBoxStartTabPage;
    private TabPage tabPage3;
    private CheckBox checkBoxTyresWarning;
    private TabPage tabPage4;
    private CheckBox chkCheck;
    private CheckBox checkBoxKeepDataWithProgram;

    public Settings(
      bool rememberPassword,
      bool autoCheck,
      bool warnTyres,
      bool keep_data_with_program)
    {
      this.InitializeComponent();
      this.keep_data_with_program = keep_data_with_program;
      this.rememberPassword = rememberPassword;
      this.autoCheck = autoCheck;
      this.warn_for_wrong_tyres = warnTyres;
      this.checkBoxSavePassword.Checked = rememberPassword;
      this.chkCheck.Checked = autoCheck;
      this.checkBoxTyresWarning.Checked = this.warn_for_wrong_tyres;
      this.checkBoxKeepDataWithProgram.Checked = keep_data_with_program;
      this.buttonApply.Enabled = false;
      object obj = Registry.CurrentUser.CreateSubKey("Software\\go\\GUI").GetValue("StartingTabPage");
      if (obj != null)
        this.startingTabPage = (int) obj;
      this.comboBoxStartTabPage.SelectedIndex = this.startingTabPage;
      this.comboBoxStartTabPage.Text = (string) this.comboBoxStartTabPage.Items[this.startingTabPage];
    }

    private void InitializeComponent()
    {
      this.checkBoxSavePassword = new CheckBox();
      this.buttonOk = new Button();
      this.buttonApply = new Button();
      this.buttonCancel = new Button();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.tabPage2 = new TabPage();
      this.label1 = new Label();
      this.comboBoxStartTabPage = new ComboBox();
      this.tabPage3 = new TabPage();
      this.checkBoxTyresWarning = new CheckBox();
      this.tabPage4 = new TabPage();
      this.checkBoxKeepDataWithProgram = new CheckBox();
      this.chkCheck = new CheckBox();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.SuspendLayout();
      this.checkBoxSavePassword.Location = new Point(8, 8);
      this.checkBoxSavePassword.Name = "checkBoxSavePassword";
      this.checkBoxSavePassword.Size = new Size(184, 16);
      this.checkBoxSavePassword.TabIndex = 0;
      this.checkBoxSavePassword.Text = "Save password (encrypted)";
      this.checkBoxSavePassword.CheckedChanged += new EventHandler(this.enableApplyButton);
      this.buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.buttonOk.Location = new Point(16, 88);
      this.buttonOk.Name = "buttonOk";
      this.buttonOk.Size = new Size(75, 23);
      this.buttonOk.TabIndex = 1;
      this.buttonOk.Text = "&Ok";
      this.buttonOk.Click += new EventHandler(this.buttonOk_Click);
      this.buttonApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.buttonApply.Enabled = false;
      this.buttonApply.Location = new Point(96, 88);
      this.buttonApply.Name = "buttonApply";
      this.buttonApply.Size = new Size(75, 23);
      this.buttonApply.TabIndex = 2;
      this.buttonApply.Text = "&Apply";
      this.buttonApply.Click += new EventHandler(this.buttonApply_Click);
      this.buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.buttonCancel.DialogResult = DialogResult.Cancel;
      this.buttonCancel.Location = new Point(176, 88);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new Size(75, 23);
      this.buttonCancel.TabIndex = 3;
      this.buttonCancel.Text = "&Cancel";
      this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
      this.tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Controls.Add((Control) this.tabPage4);
      this.tabControl1.Location = new Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(264, 80);
      this.tabControl1.TabIndex = 5;
      this.tabPage1.Controls.Add((Control) this.chkCheck);
      this.tabPage1.Controls.Add((Control) this.checkBoxSavePassword);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Size = new Size(256, 54);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Online";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.tabPage2.Controls.Add((Control) this.label1);
      this.tabPage2.Controls.Add((Control) this.comboBoxStartTabPage);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Size = new Size(256, 54);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "GUI";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.label1.Location = new Point(8, 17);
      this.label1.Name = "label1";
      this.label1.Size = new Size(96, 16);
      this.label1.TabIndex = 1;
      this.label1.Text = "Starting Tab Page";
      this.comboBoxStartTabPage.Items.AddRange(new object[11]
      {
        (object) "Last Viewed",
        (object) "Driver",
        (object) "TD",
        (object) "Car",
        (object) "Staff",
        (object) "Season",
        (object) "Testing",
        (object) "Practice",
        (object) "Strategy",
        (object) "Forecast",
        (object) "Finances"
      });
      this.comboBoxStartTabPage.Location = new Point(110, 14);
      this.comboBoxStartTabPage.Name = "comboBoxStartTabPage";
      this.comboBoxStartTabPage.Size = new Size(121, 21);
      this.comboBoxStartTabPage.TabIndex = 0;
      this.comboBoxStartTabPage.Text = "Last Viewed";
      this.comboBoxStartTabPage.SelectionChangeCommitted += new EventHandler(this.enableApplyButton);
      this.tabPage3.Controls.Add((Control) this.checkBoxTyresWarning);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new Size(256, 54);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Warnings";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.checkBoxTyresWarning.AutoSize = true;
      this.checkBoxTyresWarning.Location = new Point(3, 20);
      this.checkBoxTyresWarning.Name = "checkBoxTyresWarning";
      this.checkBoxTyresWarning.Size = new Size(237, 17);
      this.checkBoxTyresWarning.TabIndex = 0;
      this.checkBoxTyresWarning.Text = "Warn if start tyres do not match start weather";
      this.checkBoxTyresWarning.UseVisualStyleBackColor = true;
      this.checkBoxTyresWarning.CheckedChanged += new EventHandler(this.enableApplyButton);
      this.tabPage4.Controls.Add((Control) this.checkBoxKeepDataWithProgram);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(256, 54);
      this.tabPage4.TabIndex = 4;
      this.tabPage4.Text = "Datafile";
      this.tabPage4.UseVisualStyleBackColor = true;
      this.checkBoxKeepDataWithProgram.AutoSize = true;
      this.checkBoxKeepDataWithProgram.Location = new Point(3, 16);
      this.checkBoxKeepDataWithProgram.Name = "checkBoxKeepDataWithProgram";
      this.checkBoxKeepDataWithProgram.Size = new Size(151, 17);
      this.checkBoxKeepDataWithProgram.TabIndex = 0;
      this.checkBoxKeepDataWithProgram.Text = "Keep datafile with program";
      this.checkBoxKeepDataWithProgram.UseVisualStyleBackColor = true;
      this.checkBoxKeepDataWithProgram.CheckedChanged += new EventHandler(this.enableApplyButton);
      this.chkCheck.Location = new Point(8, 30);
      this.chkCheck.Name = "chkCheck";
      this.chkCheck.Size = new Size(206, 21);
      this.chkCheck.TabIndex = 1;
      this.chkCheck.Text = "Automatically check for new version";
      this.AcceptButton = (IButtonControl) this.buttonOk;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.buttonCancel;
      this.ClientSize = new Size(258, 120);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.buttonCancel);
      this.Controls.Add((Control) this.buttonApply);
      this.Controls.Add((Control) this.buttonOk);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = Resources.Resources.Car;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Settings);
      this.Text = "GPRO Organizer : Settings";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      this.ResumeLayout(false);
    }

    private void buttonOk_Click(object sender, EventArgs e)
    {
      this.buttonApply_Click(sender, e);
      this.Close();
    }

    private void buttonApply_Click(object sender, EventArgs e)
    {
      this.rememberPassword = this.checkBoxSavePassword.Checked;
      this.autoCheck = this.chkCheck.Checked;
      this.warn_for_wrong_tyres = this.checkBoxTyresWarning.Checked;
      this.buttonApply.Enabled = false;
      this.keep_data_with_program = this.checkBoxKeepDataWithProgram.Checked;
      this.saveSettings = true;
      this.SaveSettings();
    }

    private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

    private void enableApplyButton(object sender, EventArgs e) => this.buttonApply.Enabled = true;

    private void SaveSettings()
    {
      RegistryKey subKey = Registry.CurrentUser.CreateSubKey("Software\\go\\GUI");
      subKey.SetValue("StartingTabPage", (object) this.comboBoxStartTabPage.SelectedIndex);
      subKey.Close();
    }
  }
}
