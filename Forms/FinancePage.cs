// Decompiled with JetBrains decompiler
// Type: go.Forms.FinancePage
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class FinancePage : TabPage
  {
    public TreeView treeViewIncome;
    public TreeView treeViewExpenses;
    public Label label1;
    public Label label2;

    public FinancePage(int season)
    {
      this.SuspendLayout();
      this.Text = "Season " + season.ToString();
      this.treeViewIncome = new TreeView();
      this.treeViewExpenses = new TreeView();
      this.label1 = new Label();
      this.label2 = new Label();
      this.treeViewIncome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.treeViewIncome.BackColor = SystemColors.Control;
      this.treeViewIncome.BorderStyle = BorderStyle.None;
      this.treeViewIncome.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.treeViewIncome.FullRowSelect = true;
      this.treeViewIncome.ImageIndex = -1;
      this.treeViewIncome.Location = new Point(8, 44);
      this.treeViewIncome.Name = nameof (treeViewIncome);
      this.treeViewIncome.SelectedImageIndex = -1;
      this.treeViewIncome.Size = new Size(300, 216);
      this.treeViewIncome.TabIndex = 1;
      this.treeViewExpenses.BackColor = SystemColors.Control;
      this.treeViewExpenses.BorderStyle = BorderStyle.None;
      this.treeViewExpenses.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.treeViewExpenses.ImageIndex = -1;
      this.treeViewExpenses.Location = new Point(308, 44);
      this.treeViewExpenses.Name = nameof (treeViewExpenses);
      this.treeViewExpenses.RightToLeft = RightToLeft.No;
      this.treeViewExpenses.SelectedImageIndex = -1;
      this.treeViewExpenses.Size = new Size(360, 216);
      this.treeViewExpenses.TabIndex = 2;
      this.label1.Location = new Point(8, 12);
      this.label1.Name = nameof (label1);
      this.label1.Size = new Size(200, 16);
      this.label1.TabIndex = 3;
      this.label1.Text = "Income ";
      this.label2.Location = new Point(308, 12);
      this.label2.Name = nameof (label2);
      this.label2.Size = new Size(200, 16);
      this.label2.TabIndex = 4;
      this.label2.Text = "Expenses ";
      this.Controls.Add((Control) this.treeViewExpenses);
      this.Controls.Add((Control) this.treeViewIncome);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.label2);
      this.Location = new Point(4, 22);
      this.Name = "tabPage1";
      this.Size = new Size(672, 266);
      this.TabIndex = 0;
      this.Text = "tabPage1";
      this.ResumeLayout(false);
    }
  }
}
