 
// Type: go.Forms.StrategyToolForm
 
 
 

using go.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class StrategyToolForm : Form
  {
    private Track track;
    private double estFuel;
    private int estTyre;
    private int neededFuel;
    private int neededStints;
    private double tyreWearPerLap;
    private double fuelPerLap;
    private int maxLaps;
    private Label label1;
    private Label label2;
    private Label label3;
    private GroupBox groupBox1;
    private Label label4;
    private GroupBox groupBox2;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label label10;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private Label label12;
    private Label label13;
    private Label label14;
    private GroupBox groupBox5;
    private Label label15;
    private Label label16;
    private Label label17;
    private GroupBox groupBox6;
    private Label label18;
    private Label label19;
    private Label label20;
    private GroupBox groupBox7;
    private Label label21;
    private Label label22;
    private Label label23;
    private GroupBox groupBox8;
    private Label label11;
    private Label label24;
    private Label label26;
    private Label label27;
    private Label label28;
    private Button button1;
    private TextBox textBoxTrackRaceLength;
    private TextBox textBoxTrackLapLength;
    private TextBox textBoxTrackLaps;
    private TextBox textBoxTrackFuelConsumption;
    private TextBox textBoxTrackTyreWear;
    private TextBox textBoxTrackName;
    private TextBox textBoxEstFuel;
    private TextBox textBoxEstTyre;
    private TextBox textBoxNeededFuel;
    private TextBox textBoxNeededStops;
    private TextBox textBox4fuel;
    private TextBox textBox4tyre;
    private TextBox textBox3fuel;
    private TextBox textBox3tyre;
    private TextBox textBox2laps;
    private TextBox textBox2fuel;
    private TextBox textBox2tyre;
    private TextBox textBox1laps;
    private TextBox textBox1fuel;
    private TextBox textBox1tyre;
    private TextBox textBox4laps;
    private TextBox textBox3laps;

    public StrategyToolForm(ref Track track)
    {
      this.InitializeComponent();
      this.track = track;
      this.textBoxTrackName.Text = track.name;
      this.textBoxTrackTyreWear.Text = EnumToString.Enum2String(track.tyreWear);
      this.textBoxTrackFuelConsumption.Text = EnumToString.Enum2String(track.fuelConsumption);
      this.textBoxTrackLaps.Text = track.laps.ToString();
      this.textBoxTrackLapLength.Text = track.lapDistance.ToString();
      this.textBoxTrackRaceLength.Text = track.distance.ToString();
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (StrategyToolForm));
      this.label1 = new Label();
      this.textBoxEstFuel = new TextBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.groupBox1 = new GroupBox();
      this.textBoxEstTyre = new TextBox();
      this.label4 = new Label();
      this.groupBox2 = new GroupBox();
      this.label28 = new Label();
      this.label27 = new Label();
      this.textBoxTrackRaceLength = new TextBox();
      this.textBoxTrackLapLength = new TextBox();
      this.textBoxTrackLaps = new TextBox();
      this.textBoxTrackFuelConsumption = new TextBox();
      this.textBoxTrackTyreWear = new TextBox();
      this.label10 = new Label();
      this.label9 = new Label();
      this.label8 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
      this.textBoxTrackName = new TextBox();
      this.label5 = new Label();
      this.groupBox3 = new GroupBox();
      this.groupBox7 = new GroupBox();
      this.label21 = new Label();
      this.label22 = new Label();
      this.label23 = new Label();
      this.textBox4laps = new TextBox();
      this.textBox4fuel = new TextBox();
      this.textBox4tyre = new TextBox();
      this.groupBox6 = new GroupBox();
      this.label18 = new Label();
      this.label19 = new Label();
      this.label20 = new Label();
      this.textBox3laps = new TextBox();
      this.textBox3fuel = new TextBox();
      this.textBox3tyre = new TextBox();
      this.groupBox5 = new GroupBox();
      this.label15 = new Label();
      this.label16 = new Label();
      this.label17 = new Label();
      this.textBox2laps = new TextBox();
      this.textBox2fuel = new TextBox();
      this.textBox2tyre = new TextBox();
      this.groupBox4 = new GroupBox();
      this.label14 = new Label();
      this.label13 = new Label();
      this.label12 = new Label();
      this.textBox1laps = new TextBox();
      this.textBox1fuel = new TextBox();
      this.textBox1tyre = new TextBox();
      this.groupBox8 = new GroupBox();
      this.label26 = new Label();
      this.textBoxNeededStops = new TextBox();
      this.textBoxNeededFuel = new TextBox();
      this.label24 = new Label();
      this.label11 = new Label();
      this.button1 = new Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.SuspendLayout();
      this.label1.Location = new Point(8, 24);
      this.label1.Name = "label1";
      this.label1.Size = new Size(104, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Fuel Consumption:";
      this.textBoxEstFuel.Location = new Point(120, 20);
      this.textBoxEstFuel.Name = "textBoxEstFuel";
      this.textBoxEstFuel.Size = new Size(40, 20);
      this.textBoxEstFuel.TabIndex = 0;
      this.textBoxEstFuel.TextAlign = HorizontalAlignment.Right;
      this.textBoxEstFuel.KeyUp += new KeyEventHandler(this.textBoxEstFuel_KeyUp);
      this.label2.Location = new Point(160, 24);
      this.label2.Name = "label2";
      this.label2.Size = new Size(32, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "Km/l";
      this.label3.Location = new Point(8, 56);
      this.label3.Name = "label3";
      this.label3.Size = new Size(100, 16);
      this.label3.TabIndex = 3;
      this.label3.Text = "Tyre Duration:";
      this.groupBox1.Controls.Add((Control) this.textBoxEstTyre);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.textBoxEstFuel);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Location = new Point(280, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(216, 88);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Manager estimates";
      this.textBoxEstTyre.Location = new Point(120, 52);
      this.textBoxEstTyre.Name = "textBoxEstTyre";
      this.textBoxEstTyre.Size = new Size(40, 20);
      this.textBoxEstTyre.TabIndex = 1;
      this.textBoxEstTyre.TextAlign = HorizontalAlignment.Right;
      this.textBoxEstTyre.KeyUp += new KeyEventHandler(this.textBoxEstTyre_KeyUp);
      this.label4.Location = new Point(160, 56);
      this.label4.Name = "label4";
      this.label4.Size = new Size(32, 16);
      this.label4.TabIndex = 5;
      this.label4.Text = "Km";
      this.groupBox2.Controls.Add((Control) this.label28);
      this.groupBox2.Controls.Add((Control) this.label27);
      this.groupBox2.Controls.Add((Control) this.textBoxTrackRaceLength);
      this.groupBox2.Controls.Add((Control) this.textBoxTrackLapLength);
      this.groupBox2.Controls.Add((Control) this.textBoxTrackLaps);
      this.groupBox2.Controls.Add((Control) this.textBoxTrackFuelConsumption);
      this.groupBox2.Controls.Add((Control) this.textBoxTrackTyreWear);
      this.groupBox2.Controls.Add((Control) this.label10);
      this.groupBox2.Controls.Add((Control) this.label9);
      this.groupBox2.Controls.Add((Control) this.label8);
      this.groupBox2.Controls.Add((Control) this.label7);
      this.groupBox2.Controls.Add((Control) this.label6);
      this.groupBox2.Controls.Add((Control) this.textBoxTrackName);
      this.groupBox2.Controls.Add((Control) this.label5);
      this.groupBox2.Location = new Point(8, 8);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(248, 176);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Track data";
      this.label28.Location = new Point(168, 152);
      this.label28.Name = "label28";
      this.label28.Size = new Size(32, 16);
      this.label28.TabIndex = 13;
      this.label28.Text = "Km";
      this.label27.Location = new Point(168, 128);
      this.label27.Name = "label27";
      this.label27.Size = new Size(32, 16);
      this.label27.TabIndex = 12;
      this.label27.Text = "Km";
      this.textBoxTrackRaceLength.Location = new Point(128, 148);
      this.textBoxTrackRaceLength.Name = "textBoxTrackRaceLength";
      this.textBoxTrackRaceLength.ReadOnly = true;
      this.textBoxTrackRaceLength.Size = new Size(40, 20);
      this.textBoxTrackRaceLength.TabIndex = 11;
      this.textBoxTrackRaceLength.TabStop = false;
      this.textBoxTrackRaceLength.Text = "888,8";
      this.textBoxTrackRaceLength.TextAlign = HorizontalAlignment.Right;
      this.textBoxTrackLapLength.Location = new Point(128, 124);
      this.textBoxTrackLapLength.Name = "textBoxTrackLapLength";
      this.textBoxTrackLapLength.ReadOnly = true;
      this.textBoxTrackLapLength.Size = new Size(40, 20);
      this.textBoxTrackLapLength.TabIndex = 10;
      this.textBoxTrackLapLength.TabStop = false;
      this.textBoxTrackLapLength.Text = "8,888";
      this.textBoxTrackLapLength.TextAlign = HorizontalAlignment.Right;
      this.textBoxTrackLaps.Location = new Point(128, 100);
      this.textBoxTrackLaps.Name = "textBoxTrackLaps";
      this.textBoxTrackLaps.ReadOnly = true;
      this.textBoxTrackLaps.Size = new Size(24, 20);
      this.textBoxTrackLaps.TabIndex = 9;
      this.textBoxTrackLaps.TabStop = false;
      this.textBoxTrackLaps.Text = "88";
      this.textBoxTrackLaps.TextAlign = HorizontalAlignment.Right;
      this.textBoxTrackFuelConsumption.Location = new Point(128, 76);
      this.textBoxTrackFuelConsumption.Name = "textBoxTrackFuelConsumption";
      this.textBoxTrackFuelConsumption.ReadOnly = true;
      this.textBoxTrackFuelConsumption.Size = new Size(56, 20);
      this.textBoxTrackFuelConsumption.TabIndex = 8;
      this.textBoxTrackFuelConsumption.TabStop = false;
      this.textBoxTrackFuelConsumption.Text = "Very high";
      this.textBoxTrackTyreWear.Location = new Point(128, 52);
      this.textBoxTrackTyreWear.Name = "textBoxTrackTyreWear";
      this.textBoxTrackTyreWear.ReadOnly = true;
      this.textBoxTrackTyreWear.Size = new Size(56, 20);
      this.textBoxTrackTyreWear.TabIndex = 7;
      this.textBoxTrackTyreWear.TabStop = false;
      this.textBoxTrackTyreWear.Text = "Very high";
      this.label10.Location = new Point(16, 152);
      this.label10.Name = "label10";
      this.label10.Size = new Size(80, 16);
      this.label10.TabIndex = 6;
      this.label10.Text = "Race length:";
      this.label9.Location = new Point(16, 128);
      this.label9.Name = "label9";
      this.label9.Size = new Size(80, 16);
      this.label9.TabIndex = 5;
      this.label9.Text = "Lap length:";
      this.label8.Location = new Point(16, 104);
      this.label8.Name = "label8";
      this.label8.Size = new Size(80, 16);
      this.label8.TabIndex = 4;
      this.label8.Text = "Laps:";
      this.label7.Location = new Point(16, 80);
      this.label7.Name = "label7";
      this.label7.Size = new Size(104, 16);
      this.label7.TabIndex = 3;
      this.label7.Text = "Fuel consumption:";
      this.label6.Location = new Point(16, 56);
      this.label6.Name = "label6";
      this.label6.Size = new Size(80, 16);
      this.label6.TabIndex = 2;
      this.label6.Text = "Tyre wear:";
      this.textBoxTrackName.Location = new Point(128, 28);
      this.textBoxTrackName.Name = "textBoxTrackName";
      this.textBoxTrackName.ReadOnly = true;
      this.textBoxTrackName.Size = new Size(80, 20);
      this.textBoxTrackName.TabIndex = 1;
      this.textBoxTrackName.TabStop = false;
      this.textBoxTrackName.Text = "Oesterreichring";
      this.label5.Location = new Point(16, 32);
      this.label5.Name = "label5";
      this.label5.Size = new Size(80, 16);
      this.label5.TabIndex = 0;
      this.label5.Text = "Name:";
      this.groupBox3.Controls.Add((Control) this.groupBox7);
      this.groupBox3.Controls.Add((Control) this.groupBox6);
      this.groupBox3.Controls.Add((Control) this.groupBox5);
      this.groupBox3.Controls.Add((Control) this.groupBox4);
      this.groupBox3.Location = new Point(8, 192);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(488, 128);
      this.groupBox3.TabIndex = 6;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Pitstop strategy planning";
      this.groupBox7.Controls.Add((Control) this.label21);
      this.groupBox7.Controls.Add((Control) this.label22);
      this.groupBox7.Controls.Add((Control) this.label23);
      this.groupBox7.Controls.Add((Control) this.textBox4laps);
      this.groupBox7.Controls.Add((Control) this.textBox4fuel);
      this.groupBox7.Controls.Add((Control) this.textBox4tyre);
      this.groupBox7.Location = new Point(368, 24);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new Size(112, 96);
      this.groupBox7.TabIndex = 3;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Stint 4";
      this.label21.Location = new Point(32, 24);
      this.label21.Name = "label21";
      this.label21.Size = new Size(32, 16);
      this.label21.TabIndex = 5;
      this.label21.Text = "laps";
      this.label22.Location = new Point(32, 72);
      this.label22.Name = "label22";
      this.label22.Size = new Size(40, 16);
      this.label22.TabIndex = 4;
      this.label22.Text = "l fuel";
      this.label23.Location = new Point(32, 48);
      this.label23.Name = "label23";
      this.label23.Size = new Size(64, 16);
      this.label23.TabIndex = 3;
      this.label23.Text = "% tyre wear";
      this.textBox4laps.Location = new Point(8, 20);
      this.textBox4laps.Name = "textBox4laps";
      this.textBox4laps.ReadOnly = true;
      this.textBox4laps.Size = new Size(24, 20);
      this.textBox4laps.TabIndex = 0;
      this.textBox4laps.TabStop = false;
      this.textBox4laps.TextAlign = HorizontalAlignment.Right;
      this.textBox4fuel.Location = new Point(8, 68);
      this.textBox4fuel.Name = "textBox4fuel";
      this.textBox4fuel.ReadOnly = true;
      this.textBox4fuel.Size = new Size(24, 20);
      this.textBox4fuel.TabIndex = 2;
      this.textBox4fuel.TabStop = false;
      this.textBox4fuel.TextAlign = HorizontalAlignment.Right;
      this.textBox4tyre.Location = new Point(8, 44);
      this.textBox4tyre.Name = "textBox4tyre";
      this.textBox4tyre.ReadOnly = true;
      this.textBox4tyre.Size = new Size(24, 20);
      this.textBox4tyre.TabIndex = 1;
      this.textBox4tyre.TabStop = false;
      this.textBox4tyre.TextAlign = HorizontalAlignment.Right;
      this.groupBox6.Controls.Add((Control) this.label18);
      this.groupBox6.Controls.Add((Control) this.label19);
      this.groupBox6.Controls.Add((Control) this.label20);
      this.groupBox6.Controls.Add((Control) this.textBox3laps);
      this.groupBox6.Controls.Add((Control) this.textBox3fuel);
      this.groupBox6.Controls.Add((Control) this.textBox3tyre);
      this.groupBox6.Location = new Point(248, 24);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(112, 96);
      this.groupBox6.TabIndex = 2;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Stint 3";
      this.label18.Location = new Point(32, 24);
      this.label18.Name = "label18";
      this.label18.Size = new Size(32, 16);
      this.label18.TabIndex = 5;
      this.label18.Text = "laps";
      this.label19.Location = new Point(32, 72);
      this.label19.Name = "label19";
      this.label19.Size = new Size(40, 16);
      this.label19.TabIndex = 4;
      this.label19.Text = "l fuel";
      this.label20.Location = new Point(32, 48);
      this.label20.Name = "label20";
      this.label20.Size = new Size(64, 16);
      this.label20.TabIndex = 3;
      this.label20.Text = "% tyre wear";
      this.textBox3laps.Location = new Point(8, 20);
      this.textBox3laps.Name = "textBox3laps";
      this.textBox3laps.ReadOnly = true;
      this.textBox3laps.Size = new Size(24, 20);
      this.textBox3laps.TabIndex = 0;
      this.textBox3laps.TextAlign = HorizontalAlignment.Right;
      this.textBox3laps.KeyUp += new KeyEventHandler(this.textBox3laps_KeyUp);
      this.textBox3fuel.Location = new Point(8, 68);
      this.textBox3fuel.Name = "textBox3fuel";
      this.textBox3fuel.ReadOnly = true;
      this.textBox3fuel.Size = new Size(24, 20);
      this.textBox3fuel.TabIndex = 2;
      this.textBox3fuel.TextAlign = HorizontalAlignment.Right;
      this.textBox3fuel.KeyUp += new KeyEventHandler(this.textBox3fuel_KeyUp);
      this.textBox3tyre.Location = new Point(8, 44);
      this.textBox3tyre.Name = "textBox3tyre";
      this.textBox3tyre.ReadOnly = true;
      this.textBox3tyre.Size = new Size(24, 20);
      this.textBox3tyre.TabIndex = 1;
      this.textBox3tyre.TextAlign = HorizontalAlignment.Right;
      this.textBox3tyre.KeyUp += new KeyEventHandler(this.textBox3tyre_KeyUp);
      this.groupBox5.Controls.Add((Control) this.label15);
      this.groupBox5.Controls.Add((Control) this.label16);
      this.groupBox5.Controls.Add((Control) this.label17);
      this.groupBox5.Controls.Add((Control) this.textBox2laps);
      this.groupBox5.Controls.Add((Control) this.textBox2fuel);
      this.groupBox5.Controls.Add((Control) this.textBox2tyre);
      this.groupBox5.Location = new Point(128, 24);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(112, 96);
      this.groupBox5.TabIndex = 1;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Stint 2";
      this.label15.Location = new Point(32, 24);
      this.label15.Name = "label15";
      this.label15.Size = new Size(32, 16);
      this.label15.TabIndex = 5;
      this.label15.Text = "laps";
      this.label16.Location = new Point(32, 72);
      this.label16.Name = "label16";
      this.label16.Size = new Size(40, 16);
      this.label16.TabIndex = 4;
      this.label16.Text = "l fuel";
      this.label17.Location = new Point(32, 48);
      this.label17.Name = "label17";
      this.label17.Size = new Size(64, 16);
      this.label17.TabIndex = 3;
      this.label17.Text = "% tyre wear";
      this.textBox2laps.Location = new Point(8, 20);
      this.textBox2laps.Name = "textBox2laps";
      this.textBox2laps.ReadOnly = true;
      this.textBox2laps.Size = new Size(24, 20);
      this.textBox2laps.TabIndex = 0;
      this.textBox2laps.TextAlign = HorizontalAlignment.Right;
      this.textBox2laps.KeyUp += new KeyEventHandler(this.textBox2laps_KeyUp);
      this.textBox2fuel.Location = new Point(8, 68);
      this.textBox2fuel.Name = "textBox2fuel";
      this.textBox2fuel.ReadOnly = true;
      this.textBox2fuel.Size = new Size(24, 20);
      this.textBox2fuel.TabIndex = 2;
      this.textBox2fuel.TextAlign = HorizontalAlignment.Right;
      this.textBox2fuel.KeyUp += new KeyEventHandler(this.textBox2fuel_KeyUp);
      this.textBox2tyre.Location = new Point(8, 44);
      this.textBox2tyre.Name = "textBox2tyre";
      this.textBox2tyre.ReadOnly = true;
      this.textBox2tyre.Size = new Size(24, 20);
      this.textBox2tyre.TabIndex = 1;
      this.textBox2tyre.TextAlign = HorizontalAlignment.Right;
      this.textBox2tyre.KeyUp += new KeyEventHandler(this.textBox2tyre_KeyUp);
      this.groupBox4.Controls.Add((Control) this.label14);
      this.groupBox4.Controls.Add((Control) this.label13);
      this.groupBox4.Controls.Add((Control) this.label12);
      this.groupBox4.Controls.Add((Control) this.textBox1laps);
      this.groupBox4.Controls.Add((Control) this.textBox1fuel);
      this.groupBox4.Controls.Add((Control) this.textBox1tyre);
      this.groupBox4.Location = new Point(8, 24);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(112, 96);
      this.groupBox4.TabIndex = 0;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Stint 1";
      this.label14.Location = new Point(32, 24);
      this.label14.Name = "label14";
      this.label14.Size = new Size(32, 16);
      this.label14.TabIndex = 5;
      this.label14.Text = "laps";
      this.label13.Location = new Point(32, 72);
      this.label13.Name = "label13";
      this.label13.Size = new Size(40, 16);
      this.label13.TabIndex = 4;
      this.label13.Text = "l fuel";
      this.label12.Location = new Point(32, 48);
      this.label12.Name = "label12";
      this.label12.Size = new Size(64, 16);
      this.label12.TabIndex = 3;
      this.label12.Text = "% tyre wear";
      this.textBox1laps.Location = new Point(8, 20);
      this.textBox1laps.Name = "textBox1laps";
      this.textBox1laps.ReadOnly = true;
      this.textBox1laps.Size = new Size(24, 20);
      this.textBox1laps.TabIndex = 0;
      this.textBox1laps.TextAlign = HorizontalAlignment.Right;
      this.textBox1laps.KeyUp += new KeyEventHandler(this.textBox1laps_KeyUp);
      this.textBox1fuel.Location = new Point(8, 68);
      this.textBox1fuel.Name = "textBox1fuel";
      this.textBox1fuel.ReadOnly = true;
      this.textBox1fuel.Size = new Size(24, 20);
      this.textBox1fuel.TabIndex = 2;
      this.textBox1fuel.TextAlign = HorizontalAlignment.Right;
      this.textBox1fuel.KeyUp += new KeyEventHandler(this.textBox1fuel_KeyUp);
      this.textBox1tyre.Location = new Point(8, 44);
      this.textBox1tyre.Name = "textBox1tyre";
      this.textBox1tyre.ReadOnly = true;
      this.textBox1tyre.Size = new Size(24, 20);
      this.textBox1tyre.TabIndex = 1;
      this.textBox1tyre.TextAlign = HorizontalAlignment.Right;
      this.textBox1tyre.KeyUp += new KeyEventHandler(this.textBox1tyre_KeyUp);
      this.groupBox8.Controls.Add((Control) this.label26);
      this.groupBox8.Controls.Add((Control) this.textBoxNeededStops);
      this.groupBox8.Controls.Add((Control) this.textBoxNeededFuel);
      this.groupBox8.Controls.Add((Control) this.label24);
      this.groupBox8.Controls.Add((Control) this.label11);
      this.groupBox8.Location = new Point(280, 104);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new Size(216, 80);
      this.groupBox8.TabIndex = 7;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "Fuel and stints needed";
      this.label26.Location = new Point(152, 24);
      this.label26.Name = "label26";
      this.label26.Size = new Size(32, 16);
      this.label26.TabIndex = 7;
      this.label26.Text = "l";
      this.textBoxNeededStops.Location = new Point(136, 52);
      this.textBoxNeededStops.Name = "textBoxNeededStops";
      this.textBoxNeededStops.ReadOnly = true;
      this.textBoxNeededStops.Size = new Size(16, 20);
      this.textBoxNeededStops.TabIndex = 6;
      this.textBoxNeededStops.TabStop = false;
      this.textBoxNeededStops.TextAlign = HorizontalAlignment.Right;
      this.textBoxNeededFuel.Location = new Point(128, 20);
      this.textBoxNeededFuel.Name = "textBoxNeededFuel";
      this.textBoxNeededFuel.ReadOnly = true;
      this.textBoxNeededFuel.Size = new Size(24, 20);
      this.textBoxNeededFuel.TabIndex = 5;
      this.textBoxNeededFuel.TabStop = false;
      this.textBoxNeededFuel.TextAlign = HorizontalAlignment.Right;
      this.label24.Location = new Point(8, 56);
      this.label24.Name = "label24";
      this.label24.Size = new Size(104, 16);
      this.label24.TabIndex = 2;
      this.label24.Text = "Minimum stints:";
      this.label11.Location = new Point(8, 24);
      this.label11.Name = "label11";
      this.label11.Size = new Size(104, 16);
      this.label11.TabIndex = 1;
      this.label11.Text = "Fuel needed:";
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(416, 328);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 8;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(504, 358);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.groupBox8);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Icon = Resources.Resources.Car;
      this.Name = nameof (StrategyToolForm);
      this.Text = "GPRO Organizer : Pit strategy tool";
      this.KeyUp += new KeyEventHandler(this.textBox1laps_KeyUp);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      this.ResumeLayout(false);
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void textBoxEstFuel_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
        this.FillComputationboxes();
      if (e.KeyValue >= 48 && e.KeyValue <= 57)
        return;
      string text = this.textBoxEstFuel.Text;
      string str = "";
      for (int index = 0; index < text.Length; ++index)
      {
        if (text[index] == '0' || text[index] == '1' || text[index] == '2' || text[index] == '3' || text[index] == '4' || text[index] == '5' || text[index] == '6' || text[index] == '7' || text[index] == '8' || text[index] == '9' || text[index] == '.' || text[index] == ',')
          str += text[index].ToString();
      }
      this.textBoxEstFuel.Text = str;
    }

    private double GetDouble(string input, double standardValue)
    {
      bool flag1 = input.IndexOf(".") >= 0;
      bool flag2 = input.IndexOf(",") >= 0;
      if (!(flag1 & flag2))
      {
        if (flag1)
        {
          if (input.Split('.').Length > 2)
            goto label_5;
        }
        if (flag1)
        {
          if (input.Split(',').Length > 2)
            goto label_5;
        }
        int length = !flag1 ? input.IndexOf(",") : input.IndexOf(".");
        double num1;
        if (length > 0)
        {
          num1 = (double) int.Parse(input.Substring(0, length));
          if (length < input.Length - 1)
          {
            string s = input.Substring(length + 1);
            double num2 = (double) int.Parse(s);
            for (int index = 0; index < s.Length; ++index)
              num2 /= 10.0;
            num1 += num2;
          }
        }
        else
          num1 = (double) int.Parse(input);
        return num1;
      }
label_5:
      return standardValue;
    }

    private void textBoxEstTyre_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
        this.FillComputationboxes();
      this.ValidateIntBox(ref this.textBoxEstTyre, e);
    }

    private void ValidateIntBox(ref TextBox box, KeyEventArgs e)
    {
      if (e.KeyValue >= 48 && e.KeyValue <= 57)
        return;
      string text = box.Text;
      string str = "";
      for (int index = 0; index < text.Length; ++index)
      {
        if (text[index] == '0' || text[index] == '1' || text[index] == '2' || text[index] == '3' || text[index] == '4' || text[index] == '5' || text[index] == '6' || text[index] == '7' || text[index] == '8' || text[index] == '9')
          str += text[index].ToString();
      }
      box.Text = str;
    }

    private void ReadEstFuelBox()
    {
      if (this.textBoxEstFuel.Text == "")
        return;
      this.estFuel = this.GetDouble(this.textBoxEstFuel.Text, this.estFuel);
    }

    private void ReadEstTyreBox()
    {
      if (this.textBoxEstTyre.Text == "")
        return;
      this.estTyre = int.Parse(this.textBoxEstTyre.Text);
    }

    private void FillComputationboxes()
    {
      this.ReadEstFuelBox();
      this.ReadEstTyreBox();
      if (this.estFuel == 0.0 || this.estTyre == 0)
        return;
      this.neededFuel = (int) (this.track.distance / this.estFuel);
      if (this.track.distance % this.estFuel > 0.0)
        ++this.neededFuel;
      this.textBoxNeededFuel.Text = this.neededFuel.ToString();
      int i1 = (int) (this.track.distance / (double) this.estTyre);
      if (this.track.distance % (double) this.estTyre > 0.0)
        ++i1;
      int i2 = (this.neededFuel + 179) / 180;
      this.neededStints = this.Max(i1, i2);
      this.textBoxNeededStops.Text = this.neededStints.ToString();
      this.tyreWearPerLap = 100.0 * this.track.lapDistance / (double) this.estTyre;
      this.fuelPerLap = this.track.lapDistance / this.estFuel;
      this.FillStintBoxes(0);
    }

    private void FillStintBoxes(int firstBox)
    {
      if (this.neededStints < 4 && firstBox < 4)
        this.ClearStint4Boxes();
      if (this.neededStints < 3 && firstBox < 3)
        this.ClearStint3Boxes();
      if (this.neededStints < 2 && firstBox < 2)
        this.ClearStint2Boxes();
      this.maxLaps = this.Min((int) ((double) this.estTyre / this.track.lapDistance), (int) (180.0 * this.estFuel / this.track.lapDistance));
      if (this.maxLaps == 0)
        ++this.maxLaps;
      int laps1 = this.track.laps / this.neededStints;
      int num1 = laps1;
      double num2 = (double) laps1 * this.track.lapDistance;
      int fuel = (int) (num2 / this.estFuel);
      if (num2 % this.estFuel > 0.0)
        ++fuel;
      int tyres = (int) (100.0 * num2 / (double) this.estTyre);
      if (num2 % (double) this.estTyre > 0.0)
        ++tyres;
      if (firstBox < 1)
      {
        this.FillStint1Boxes(fuel, tyres, laps1);
      }
      else
      {
        int num3 = int.Parse(this.textBox1laps.Text);
        num1 = num3;
        if (num1 > this.track.laps)
        {
          this.textBox1laps.Text = (num3 - num1 + this.track.laps).ToString();
          this.textBox1laps_KeyUp((object) null, new KeyEventArgs(Keys.Return));
        }
      }
      if (firstBox < 2)
      {
        if (num1 < this.track.laps)
        {
          int num4 = this.Ceiling((double) (this.track.laps - num1) / (double) this.maxLaps);
          int laps2 = (this.track.laps - num1) / num4;
          if (laps2 > this.maxLaps)
            laps2 = this.maxLaps;
          num1 += laps2;
          double num5 = (double) laps2 * this.track.lapDistance;
          this.FillStint2Boxes(this.Ceiling(num5 / this.estFuel), this.Ceiling(100.0 * num5 / (double) this.estTyre), laps2);
        }
      }
      else
      {
        int num6 = int.Parse(this.textBox2laps.Text);
        num1 += num6;
        if (num1 > this.track.laps)
        {
          this.textBox2laps.Text = (num6 - num1 + this.track.laps).ToString();
          this.textBox2laps_KeyUp((object) null, new KeyEventArgs(Keys.Return));
        }
      }
      if (firstBox < 3)
      {
        if (num1 < this.track.laps)
        {
          int num7 = this.Ceiling((double) (this.track.laps - num1) / (double) this.maxLaps);
          int laps3 = (this.track.laps - num1) / num7;
          if (laps3 > this.maxLaps)
            laps3 = this.maxLaps;
          num1 += laps3;
          double num8 = (double) laps3 * this.track.lapDistance;
          this.FillStint3Boxes(this.Ceiling(num8 / this.estFuel), this.Ceiling(100.0 * num8 / (double) this.estTyre), laps3);
        }
      }
      else
      {
        int num9 = int.Parse(this.textBox3laps.Text);
        num1 += num9;
        if (num1 > this.track.laps)
        {
          this.textBox3laps.Text = (num9 - num1 + this.track.laps).ToString();
          this.textBox3laps_KeyUp((object) null, new KeyEventArgs(Keys.Return));
        }
      }
      if (num1 >= this.track.laps)
        return;
      int laps4 = this.track.laps - num1;
      int num10 = num1 + laps4;
      double num11 = (double) laps4 * this.track.lapDistance;
      this.FillStint4Boxes(this.Ceiling(num11 / this.estFuel), this.Ceiling(100.0 * num11 / (double) this.estTyre), laps4);
    }

    private void FillStint1Boxes(int fuel, int tyres, int laps)
    {
      this.textBox1tyre.ReadOnly = false;
      this.textBox1fuel.ReadOnly = false;
      this.textBox1laps.ReadOnly = false;
      this.textBox1laps.Text = laps.ToString();
      this.textBox1tyre.Text = tyres.ToString();
      this.textBox1fuel.Text = fuel.ToString();
    }

    private void FillStint2Boxes(int fuel, int tyres, int laps)
    {
      this.textBox2tyre.ReadOnly = false;
      this.textBox2fuel.ReadOnly = false;
      this.textBox2laps.ReadOnly = false;
      this.textBox2laps.Text = laps.ToString();
      this.textBox2tyre.Text = tyres.ToString();
      this.textBox2fuel.Text = fuel.ToString();
    }

    private void FillStint3Boxes(int fuel, int tyres, int laps)
    {
      this.textBox3tyre.ReadOnly = false;
      this.textBox3fuel.ReadOnly = false;
      this.textBox3laps.ReadOnly = false;
      this.textBox3laps.Text = laps.ToString();
      this.textBox3tyre.Text = tyres.ToString();
      this.textBox3fuel.Text = fuel.ToString();
    }

    private void FillStint4Boxes(int fuel, int tyres, int laps)
    {
      this.textBox4laps.Text = laps.ToString();
      this.textBox4tyre.Text = tyres.ToString();
      this.textBox4fuel.Text = fuel.ToString();
    }

    private void ClearStint1Boxes()
    {
      this.textBox1tyre.Text = "";
      this.textBox1fuel.Text = "";
      this.textBox1laps.Text = "";
      this.textBox1tyre.ReadOnly = true;
      this.textBox1fuel.ReadOnly = true;
      this.textBox1laps.ReadOnly = true;
    }

    private void ClearStint2Boxes()
    {
      this.textBox2tyre.Text = "";
      this.textBox2fuel.Text = "";
      this.textBox2laps.Text = "";
      this.textBox2tyre.ReadOnly = true;
      this.textBox2fuel.ReadOnly = true;
      this.textBox2laps.ReadOnly = true;
    }

    private void ClearStint3Boxes()
    {
      this.textBox3tyre.Text = "";
      this.textBox3fuel.Text = "";
      this.textBox3laps.Text = "";
      this.textBox3tyre.ReadOnly = true;
      this.textBox3fuel.ReadOnly = true;
      this.textBox3laps.ReadOnly = true;
    }

    private void ClearStint4Boxes()
    {
      this.textBox4tyre.Text = "";
      this.textBox4fuel.Text = "";
      this.textBox4laps.Text = "";
      this.textBox4tyre.ReadOnly = true;
      this.textBox4fuel.ReadOnly = true;
      this.textBox4laps.ReadOnly = true;
    }

    private int Ceiling(double noget)
    {
      int num = (int) noget;
      if (noget % 1.0 > 0.0)
        ++num;
      return num;
    }

    private int Max(int i1, int i2) => i1 > i2 ? i1 : i2;

    private int Min(int i1, int i2) => i1 < i2 ? i1 : i2;

    private void textBox1tyre_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
      {
        this.textBox1laps.Text = ((int) ((double) int.Parse(this.textBox1tyre.Text) / this.tyreWearPerLap)).ToString();
        this.textBox1laps_KeyUp(sender, e);
      }
      this.ValidateIntBox(ref this.textBox1tyre, e);
    }

    private void textBox1laps_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
      {
        int maxLaps = int.Parse(this.textBox1laps.Text);
        if (maxLaps > this.maxLaps)
        {
          maxLaps = this.maxLaps;
          this.textBox1laps.Text = maxLaps.ToString();
        }
        double noget = (double) maxLaps * this.tyreWearPerLap;
        TextBox textBox1tyre = this.textBox1tyre;
        int num1 = this.Ceiling(noget);
        string str1 = num1.ToString();
        textBox1tyre.Text = str1;
        double num2 = (double) maxLaps * this.track.lapDistance;
        TextBox textBox1fuel = this.textBox1fuel;
        num1 = this.Ceiling(num2 / this.estFuel);
        string str2 = num1.ToString();
        textBox1fuel.Text = str2;
        this.FillStintBoxes(1);
      }
      this.ValidateIntBox(ref this.textBox1laps, e);
    }

    private void textBox1fuel_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
      {
        this.textBox1laps.Text = ((int) ((double) int.Parse(this.textBox1fuel.Text) / this.fuelPerLap)).ToString();
        this.textBox1laps_KeyUp(sender, e);
      }
      this.ValidateIntBox(ref this.textBox1fuel, e);
    }

    private void textBox2tyre_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
      {
        this.textBox2laps.Text = ((int) ((double) int.Parse(this.textBox2tyre.Text) / this.tyreWearPerLap)).ToString();
        this.textBox2laps_KeyUp(sender, e);
      }
      this.ValidateIntBox(ref this.textBox2tyre, e);
    }

    private void textBox2laps_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
      {
        int maxLaps = int.Parse(this.textBox2laps.Text);
        if (maxLaps > this.maxLaps)
        {
          maxLaps = this.maxLaps;
          this.textBox2laps.Text = maxLaps.ToString();
        }
        double noget = (double) maxLaps * this.tyreWearPerLap;
        TextBox textBox2tyre = this.textBox2tyre;
        int num1 = this.Ceiling(noget);
        string str1 = num1.ToString();
        textBox2tyre.Text = str1;
        double num2 = (double) maxLaps * this.track.lapDistance;
        TextBox textBox2fuel = this.textBox2fuel;
        num1 = this.Ceiling(num2 / this.estFuel);
        string str2 = num1.ToString();
        textBox2fuel.Text = str2;
        this.FillStintBoxes(2);
      }
      this.ValidateIntBox(ref this.textBox2laps, e);
    }

    private void textBox2fuel_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
      {
        this.textBox2laps.Text = ((int) ((double) int.Parse(this.textBox2fuel.Text) / this.fuelPerLap)).ToString();
        this.textBox2laps_KeyUp(sender, e);
      }
      this.ValidateIntBox(ref this.textBox2fuel, e);
    }

    private void textBox3tyre_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
      {
        this.textBox3laps.Text = ((int) ((double) int.Parse(this.textBox3tyre.Text) / this.tyreWearPerLap)).ToString();
        this.textBox3laps_KeyUp(sender, e);
      }
      this.ValidateIntBox(ref this.textBox3tyre, e);
    }

    private void textBox3laps_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
      {
        int maxLaps = int.Parse(this.textBox3laps.Text);
        if (maxLaps > this.maxLaps)
        {
          maxLaps = this.maxLaps;
          this.textBox3laps.Text = maxLaps.ToString();
        }
        double noget = (double) maxLaps * this.tyreWearPerLap;
        TextBox textBox3tyre = this.textBox3tyre;
        int num1 = this.Ceiling(noget);
        string str1 = num1.ToString();
        textBox3tyre.Text = str1;
        double num2 = (double) maxLaps * this.track.lapDistance;
        TextBox textBox3fuel = this.textBox3fuel;
        num1 = this.Ceiling(num2 / this.estFuel);
        string str2 = num1.ToString();
        textBox3fuel.Text = str2;
        this.FillStintBoxes(3);
      }
      this.ValidateIntBox(ref this.textBox3laps, e);
    }

    private void textBox3fuel_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
      {
        this.textBox3laps.Text = ((int) ((double) int.Parse(this.textBox3fuel.Text) / this.fuelPerLap)).ToString();
        this.textBox3laps_KeyUp(sender, e);
      }
      this.ValidateIntBox(ref this.textBox3fuel, e);
    }
  }
}
