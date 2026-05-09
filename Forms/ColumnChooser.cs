// Decompiled with JetBrains decompiler
// Type: go.Forms.ColumnChooser
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using go.Utils;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class ColumnChooser : Form
  {
    private string formName = "";
    private FormInfo formInfo = new FormInfo();
    private ListView listViewChosen;
    private ListView listViewOptions;
    private Button buttonAdd;
    private Button buttonRemove;
    private Button buttonUp;
    private Button buttonDown;
    private Button buttonOk;
    private Button buttonCancel;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private Label label1;
    private Label label2;

    public ColumnChooser(string formName)
    {
      this.InitializeComponent();
      this.formName = formName;
      this.Text = "Column Chooser for " + formName;
      this.formInfo = Datas.FormHandler.GetFormInfo(formName);
      ArrayList columnInfo = this.formInfo.columnInfo;
      for (int index = 0; index < columnInfo.Count && index < this.formInfo.columnWidths.Count; ++index)
        this.listViewChosen.Items.Add(new ListViewItem(new string[2]
        {
          EnumToString.Enum2String((ColumnInfo) columnInfo[index]),
          ((int) this.formInfo.columnWidths[index]).ToString()
        }));
      foreach (ColumnInfo availableColumn in Datas.FormHandler.GetAvailableColumns(formName))
        this.listViewOptions.Items.Add(new ListViewItem(new string[2]
        {
          EnumToString.Enum2String(availableColumn),
          "-1"
        }));
    }

    private void InitializeComponent()
    {
      this.listViewChosen = new ListView();
      this.columnHeader2 = new ColumnHeader();
      this.listViewOptions = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.buttonAdd = new Button();
      this.buttonRemove = new Button();
      this.buttonUp = new Button();
      this.buttonDown = new Button();
      this.buttonOk = new Button();
      this.buttonCancel = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.SuspendLayout();
      this.listViewChosen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.listViewChosen.Columns.AddRange(new ColumnHeader[1]
      {
        this.columnHeader2
      });
      this.listViewChosen.HeaderStyle = ColumnHeaderStyle.None;
      this.listViewChosen.Location = new Point(16, 28);
      this.listViewChosen.Name = "listViewChosen";
      this.listViewChosen.Size = new Size(172, 268);
      this.listViewChosen.TabIndex = 0;
      this.listViewChosen.View = View.Details;
      this.listViewChosen.DoubleClick += new EventHandler(this.buttonRemove_Click);
      this.columnHeader2.Text = "NameLeft";
      this.columnHeader2.Width = 160;
      this.listViewOptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.listViewOptions.Columns.AddRange(new ColumnHeader[1]
      {
        this.columnHeader1
      });
      this.listViewOptions.HeaderStyle = ColumnHeaderStyle.None;
      this.listViewOptions.Location = new Point(240, 28);
      this.listViewOptions.Name = "listViewOptions";
      this.listViewOptions.Size = new Size(168, 268);
      this.listViewOptions.TabIndex = 1;
      this.listViewOptions.View = View.Details;
      this.listViewOptions.DoubleClick += new EventHandler(this.buttonAdd_Click);
      this.columnHeader1.Text = "Name";
      this.columnHeader1.Width = 160;
      this.buttonAdd.Anchor = AnchorStyles.Top;
      this.buttonAdd.Location = new Point(196, 84);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new Size(36, 24);
      this.buttonAdd.TabIndex = 2;
      this.buttonAdd.Text = "<-";
      this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
      this.buttonRemove.Anchor = AnchorStyles.Top;
      this.buttonRemove.Location = new Point(196, 112);
      this.buttonRemove.Name = "buttonRemove";
      this.buttonRemove.Size = new Size(36, 24);
      this.buttonRemove.TabIndex = 3;
      this.buttonRemove.Text = "->";
      this.buttonRemove.Click += new EventHandler(this.buttonRemove_Click);
      this.buttonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.buttonUp.Location = new Point(16, 300);
      this.buttonUp.Name = "buttonUp";
      this.buttonUp.Size = new Size(32, 20);
      this.buttonUp.TabIndex = 4;
      this.buttonUp.Text = "Up";
      this.buttonUp.Click += new EventHandler(this.buttonUp_Click);
      this.buttonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.buttonDown.Location = new Point(60, 300);
      this.buttonDown.Name = "buttonDown";
      this.buttonDown.Size = new Size(44, 20);
      this.buttonDown.TabIndex = 5;
      this.buttonDown.Text = "Down";
      this.buttonDown.Click += new EventHandler(this.buttonDown_Click);
      this.buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.buttonOk.Location = new Point(248, 320);
      this.buttonOk.Name = "buttonOk";
      this.buttonOk.TabIndex = 6;
      this.buttonOk.Text = "Ok";
      this.buttonOk.Click += new EventHandler(this.buttonOk_Click);
      this.buttonOk.DialogResult = DialogResult.OK;
      this.buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.buttonCancel.Location = new Point(332, 320);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.TabIndex = 7;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
      this.buttonCancel.DialogResult = DialogResult.Cancel;
      this.label1.Location = new Point(20, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(100, 16);
      this.label1.TabIndex = 8;
      this.label1.Text = "Selected columns";
      this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.label2.Location = new Point(244, 8);
      this.label2.Name = "label2";
      this.label2.Size = new Size(100, 16);
      this.label2.TabIndex = 9;
      this.label2.Text = "Available columns";
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(424, 354);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.buttonCancel);
      this.Controls.Add((Control) this.buttonOk);
      this.Controls.Add((Control) this.buttonDown);
      this.Controls.Add((Control) this.buttonUp);
      this.Controls.Add((Control) this.buttonRemove);
      this.Controls.Add((Control) this.buttonAdd);
      this.Controls.Add((Control) this.listViewOptions);
      this.Controls.Add((Control) this.listViewChosen);
      this.MinimumSize = new Size(428, 320);
      this.Name = nameof (ColumnChooser);
      this.Text = nameof (ColumnChooser);
      this.ResumeLayout(false);
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
      if (this.listViewOptions.SelectedIndices == null)
        return;
      foreach (int selectedIndex in this.listViewOptions.SelectedIndices)
        this.listViewChosen.Items.Add((ListViewItem) this.listViewOptions.Items[selectedIndex].Clone());
    }

    private void buttonRemove_Click(object sender, EventArgs e)
    {
      if (this.listViewChosen.SelectedIndices == null)
        return;
      int num = 0;
      foreach (int selectedIndex in this.listViewChosen.SelectedIndices)
      {
        this.listViewChosen.Items.RemoveAt(selectedIndex - num);
        ++num;
      }
    }

    private void buttonUp_Click(object sender, EventArgs e)
    {
      if (this.listViewChosen.SelectedIndices == null)
        return;
      foreach (int selectedIndex in this.listViewChosen.SelectedIndices)
      {
        if (selectedIndex == 0)
          break;
        ListViewItem listViewItem = this.listViewChosen.Items[selectedIndex];
        this.listViewChosen.Items.RemoveAt(selectedIndex);
        this.listViewChosen.Items.Insert(selectedIndex - 1, listViewItem);
      }
    }

    private void buttonDown_Click(object sender, EventArgs e)
    {
      if (this.listViewChosen.SelectedIndices == null)
        return;
      for (int index = this.listViewChosen.SelectedIndices.Count - 1; index >= 0; --index)
      {
        int selectedIndex = this.listViewChosen.SelectedIndices[index];
        if (selectedIndex == this.listViewChosen.Items.Count - 1)
          break;
        ListViewItem listViewItem = this.listViewChosen.Items[selectedIndex];
        this.listViewChosen.Items.RemoveAt(selectedIndex);
        this.listViewChosen.Items.Insert(selectedIndex + 1, listViewItem);
      }
    }

    private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

    private void buttonOk_Click(object sender, EventArgs e)
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      foreach (ListViewItem listViewItem in this.listViewChosen.Items)
      {
        arrayList1.Add((object) StringToEnum.String2ColumnType(listViewItem.SubItems[0].Text));
        arrayList2.Add((object) int.Parse(listViewItem.SubItems[1].Text));
      }
      this.formInfo.columnInfo = arrayList1;
      this.formInfo.columnWidths = arrayList2;
      Datas.FormHandler.SetFormInfo(this.formName, this.formInfo);
      this.Close();
    }
  }
}
