using go.Comms;
using go.Enums;
using go.History;
using go.Parsers;
using go.Utils;
using go.Utils.Sourceforge;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
    public class MainForm : Form
    {
        private MainMenu mainMenu1;
        private MenuItem menuItem1;
        private MenuItem menuItem3;
        private MenuItem menuItem4;
        private StatusBar statusBar1;
        private StatusBarPanel statusBarPanel1;
        private StatusBarPanel statusBarPanel2;
        private StatusBarPanel statusBarPanel3;
        private MenuItem mniSave;
        private TabControl tabControl1;
        private GroupBox groupBox1;
        private TextBox textBoxbr2;
        private TextBox textBoxbr1;
        private TextBox textBoxco2;
        private TextBox textBoxco1;
        private TextBox textBoxsi2;
        private TextBox textBoxsi1;
        private TextBox textBoxel2;
        private TextBox textBoxel1;
        private TextBox textBoxun2;
        private TextBox textBoxun1;
        private TextBox textBoxsu2;
        private TextBox textBoxsu1;
        private TextBox textBoxch2;
        private TextBox textBoxch1;
        private TextBox textBoxgb2;
        private TextBox textBoxgb1;
        private TextBox textBoxen2;
        private TextBox textBoxen1;
        private TextBox textBoxrw2;
        private TextBox textBoxrw1;
        private Label label12;
        private TextBox textBoxfw2;
        private TextBox textBoxfw1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ColumnHeader trackname;
        private ColumnHeader carUpdated;
        private ColumnHeader DriverUpdated;
        private ColumnHeader PractiseUpdated;
        private ColumnHeader Qualify2Updated;
        private ColumnHeader StrategyUpdated;
        private ColumnHeader raceUpdated;
        private ListView listViewSeason;
        private ColumnHeader number;
        private Label label14;
        private TextBox textBoxPracWeather;
        private Label label15;
        private Label label16;
        private TextBox textBoxPracTemp;
        private TextBox textBoxPracHum;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ListView listViewPractice;
        private MenuItem menuItem12;
        private MenuItem menuItem16;
        private Button buttonPracErr;
        private TextBox textBoxPracComments;
        private MenuItem menuItem17;
        private ComboBox comboBoxPrac;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox textBoxPower;
        private TextBox textBoxHandling;
        private TextBox textBoxAcceleration;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label label29;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private TextBox textBoxFuel;
        private TextBox textBoxOvertake;
        private TextBox textBoxClear;
        private TextBox textBoxDefend;
        private TextBox textBoxMalfunction;
        private TextBox textBoxFWing;
        private TextBox textBoxRWing;
        private TextBox textBoxEng;
        private TextBox textBoxBra;
        private TextBox textBoxGear;
        private TextBox textBoxSusp;
        private TextBox textBoxTyresStart;
        private TextBox textBoxTyresRain;
        private TextBox textBoxTyresDry;
        private TextBox textBoxStartStrategy;
        private CheckBox checkBoxRefuel;
        private TextBox textBoxPitLimit;
        private TextBox textBoxWaitDry;
        private Label label45;
        private TextBox textBoxFuel5;
        private TextBox textBoxFuel4;
        private TextBox textBoxFuel3;
        private TextBox textBoxFuel2;
        private TextBox textBoxFuel1;
        private TextBox textBoxWaitRain;
        private TextBox textBoxPitIfSolvableProblem;
        private Label labelWaitRain;
        private Label labelWaitDry;
        private ColumnHeader QualifyUpdated;
        private Button buttonCarError;
        private Button buttonRaceError;
        private Button buttonGetTracks;
        private MenuItem menuItem19;
        private Button buttonDriver;
        private ContextMenu contextMenuSeason;
        private MenuItem menuItem2;
        private Button buttonExport;
        private ToolTip toolTipCarPower;
        private ToolTip toolTipCarHandling;
        private ToolTip toolTipCarAcceleration;
        private ToolTip toolTipCarTestPower;
        private ToolTip toolTipCarTestHandling;
        private ToolTip toolTipCarTestAcceleration;
        private ToolTip toolTipCarFW;
        private ToolTip toolTipCarRW;
        private ToolTip toolTipCarEng;
        private ToolTip toolTipCarGea;
        private ToolTip toolTipCarCha;
        private ToolTip toolTipCarSus;
        private ToolTip toolTipCarUnd;
        private ToolTip toolTipCarEle;
        private ToolTip toolTipCarSid;
        private ToolTip toolTipCarCoo;
        private ToolTip toolTipCarBra;
        private IContainer components;
        private Label label58;
        private TextBox textBoxCharisma;
        private TextBox textBoxAverage;
        private TextBox textBoxnationality;
        private TextBox textBoxname;
        private TextBox textBoxContract;
        private TextBox textBoxSalary;
        private TextBox textBoxAge;
        private TextBox textBoxWeight;
        private TextBox textBoxMotivation;
        private TextBox textBoxStamina;
        private TextBox textBoxTechnicalInsight;
        private TextBox textBoxExperience;
        private TextBox textBoxAggresiveness;
        private TextBox textBoxTalent;
        private TextBox textBoxConcentration;
        private TextBox textBoxOverall;
        private TextBox textBoxFastestLaps;
        private TextBox textBoxPoles;
        private TextBox textBoxPoints;
        private TextBox textBoxPodiums;
        private TextBox textBoxWins;
        private TextBox textBoxnumGPs;
        private TextBox textBoxtrophies;
        private Label label46;
        private Label Races;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label55;
        private Label label59;
        private Label label60;
        private Label label61;
        private Label label62;
        private Label label63;
        private Label label56;
        private Label label65;
        private Label label66;
        private Label label67;
        private Label label68;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private GroupBox groupBox10;
        private Label label64;
        private Label label57;
        private GroupBox groupBox12;
        private Label label77;
        private Label label78;
        private Label label79;
        private TextBox textBoxForecast1r;
        private TextBox textBoxForecast1h;
        private TextBox textBoxForecast1t;
        private GroupBox groupBox13;
        private Label label80;
        private Label label81;
        private Label label82;
        private GroupBox groupBox14;
        private Label label83;
        private Label label84;
        private Label label85;
        private GroupBox groupBox15;
        private Label label86;
        private Label label87;
        private Label label88;
        private GroupBox groupBox16;
        private Label label90;
        private Label label91;
        private Label label89;
        private GroupBox groupBox17;
        private Label label92;
        private Label label93;
        private Label label94;
        private TextBox textBoxForecast4t;
        private TextBox textBoxForecast4h;
        private TextBox textBoxForecast4r;
        private TextBox textBoxForecast3t;
        private TextBox textBoxForecast3h;
        private TextBox textBoxForecast3r;
        private TextBox textBoxForecast2t;
        private TextBox textBoxForecast2h;
        private TextBox textBoxPracT;
        private TextBox textBoxPracH;
        private TextBox textBoxPracW;
        private TextBox textBoxQualW;
        private TextBox textBoxQualT;
        private TextBox textBoxQualH;
        private TextBox textBoxForecast2r;
        private GroupBox groupBox18;
        private ToolTip toolTipTal;
        private ToolTip ToolTipWei;
        private ToolTip toolTipAgg;
        private ToolTip toolTipTI;
        private ToolTip toolTipExp;
        private ToolTip toolTipSta;
        private ToolTip toolTipOA;
        private ToolTip toolTipCha;
        private ToolTip toolTipConc;
        private ToolTip toolTipMot;
        private TabPage tabPageDriver;
        private TabPage tabPageCar;
        private TabPage tabPageSeason;
        private TabPage tabPagePractice;
        private TabPage tabPageStrategy;
        private TabPage tabPageWeather;
        private MenuItem menuItem13;
        private MenuItem menuItem18;
        private MenuItem menuItem20;
        private MenuItem mniGetAllDatas;
        private Button buttonTestErr;
        private ContextMenu contextMenuDriver;
        private MenuItem menuItem5;
        private StatusBarPanel statusBarPanelVersion;
        private TabPage tabPageTesting;
        private GroupBox groupBox19;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ListView listViewTest;
        private Label label95;
        private TextBox textBoxTestPower;
        private TextBox textBoxTestHandling;
        private TextBox textBoxTestAcceleration;
        private TextBox textBoxFwWear;
        private TextBox textBoxBrWear;
        private TextBox textBoxSuWear;
        private TextBox textBoxGeWear;
        private TextBox textBoxEnWear;
        private TextBox textBoxRwWear;
        private TextBox textBoxCoWear;
        private TextBox textBoxElWear;
        private TextBox textBoxSiWear;
        private TextBox textBoxUnWear;
        private TextBox textBoxChWear;
        private Label label13;
        private Label label96;
        private Label label97;
        private MenuItem menuItemHistoricalFuel;
        private MenuItem menuItemPitStrategy;
        private MenuItem menuItem6;
        private MenuItem menuItemRaces;
        private MenuItem menuItemCurrentSeason;
        private MenuItem mniOpen;
        private TabPage tabPageFinance;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ListView listViewFinance;
        private MenuItem menuItemSaveAs;
        private MenuItem menuItemFiscalReport;
        private MenuItem menuItemAvgCarWear;
        private Button buttonFinance;
        private TabPage tabPageStaff;
        private Label label98;
        private Label label99;
        private Label label100;
        private Label label101;
        private Label label102;
        private Label label103;
        private Label label104;
        private Label label105;
        private Label label106;
        private Label label107;
        private Label label108;
        private Label label109;
        private Label label110;
        private GroupBox groupBox20;
        private GroupBox groupBox21;
        private Label label111;
        private Panel panel1;
        private GroupBox groupBox22;
        private GroupBox groupBox23;
        private Label label112;
        private Label label113;
        private TextBox textBoxStaffOverall;
        private TextBox textBoxStaffPitstop;
        private TextBox textBoxStaffExperience;
        private TextBox textBoxStaffMotivation;
        private TextBox textBoxStaffStressHandling;
        private TextBox textBoxStaffConcentration;
        private TextBox textBoxStaffEfficiency;
        private TextBox textBoxStaffWindtunnel;
        private TextBox textBoxStaffRDWorkshop;
        private TextBox textBoxStaffRDDesign;
        private TextBox textBoxStaffEngineering;
        private TextBox textBoxStaffAlloy;
        private TextBox textBoxStaffCommercial;
        private TextBox textBoxStaffSalary;
        private TextBox textBoxStaffFacilities;
        private ToolTip toolTipStaffOverall;
        private ToolTip toolTipStaffExperience;
        private ToolTip toolTipStaffMotivation;
        private ToolTip toolTipStaffTechnicalSkill;
        private ToolTip toolTipStaffStress;
        private ToolTip toolTipStaffConcentration;
        private ToolTip toolTipStaffEfficiency;
        private ToolTip toolTipStaffWindtunnel;
        private ToolTip toolTipStaffPitstop;
        private ToolTip toolTipStaffRDWorkshop;
        private ToolTip toolTipStaffRDDesign;
        private ToolTip toolTipStaffAlloy;
        private ToolTip toolTipStaffCommercial;
        private ToolTip toolTipStaffSalary;
        private ToolTip toolTipStaffFacilities;
        private ToolTip toolTipStaffEngineering;
        private TextBox textBoxStaffTechnicalSkill;
        private MenuItem menuItem8;
        private MenuItem menuItemDriverTraining;
        private MenuItem menuItemPitstops;
        private TabPage tabPageTechnicalDirector;
        private GroupBox groupBox24;
        private TextBox textBoxTDNationality;
        private TextBox textBoxTDName;
        private Label label114;
        private Label label115;
        private GroupBox groupBox25;
        private TextBox textBoxTDMotivation;
        private TextBox textBoxTDPitCoordination;
        private TextBox textBoxTDExperience;
        private TextBox textBoxTDAerodynamics;
        private TextBox textBoxTDElectronics;
        private TextBox textBoxTDMechanics;
        private TextBox textBoxTDLeadership;
        private TextBox textBoxTDOverall;
        private Label label119;
        private Label label120;
        private Label label121;
        private Label label122;
        private Label label123;
        private Label label124;
        private Label label125;
        private Label label126;
        private TextBox textBoxTDWins;
        private TextBox textBoxTDNumGps;
        private TextBox textBoxTDTrophies;
        private Label label116;
        private Label label117;
        private Label label118;
        private TextBox textBoxTDContract;
        private TextBox textBoxTDSalary;
        private Label label127;
        private Label label128;
        private Label label129;
        private GroupBox groupBox26;
        private GroupBox groupBox27;
        private TextBox textBoxTDAge;
        private Label label130;
        private Button buttonGetSummary;
        private Label label131;
        private TextBox textBoxReputation;
        private ToolTip toolTipRep;
        private ListView listViewTesting;
        private ColumnHeader meanTimeHeader;
        private ColumnHeader bestTimeHeader;
        private ColumnHeader lapLimitHeader;
        private ColumnHeader lapsDoneHeader;
        private ColumnHeader fWingTestHeader;
        private ColumnHeader rWingTestHeader;
        private ColumnHeader engineTestHeader;
        private ColumnHeader brakesTestHeader;
        private ColumnHeader gearTestHeader;
        private ColumnHeader suspTestHeader;
        private ColumnHeader tyresTestHeader;
        private TextBox textBoxTestingComments;
        private ColumnHeader fuelStartHeader;
        private ColumnHeader fuelLeftHeader;
        private ColumnHeader priorityHeader;
        private ColumnHeader lapsTestHeader;
        private Button buttonTDError;
        private MenuItem menuItem7;
        private Button buttonSummaryError;
        private TabPage tabPageQualify;
        private GroupBox groupQualify2;
        private GroupBox groupQualify1;
        private ListView listViewQualify1;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader26;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader28;
        private ColumnHeader columnHeader30;
        private ColumnHeader columnHeader31;
        private ListView listViewQualify2;
        private ColumnHeader columnHeader32;
        private ColumnHeader columnHeader33;
        private ColumnHeader columnHeader34;
        private ColumnHeader columnHeader35;
        private ColumnHeader columnHeader36;
        private ColumnHeader columnHeader37;
        private ColumnHeader columnHeader38;
        private ColumnHeader columnHeader39;
        private ColumnHeader columnHeader40;
        private ColumnHeader columnHeader41;
        private MenuItem menuItemHistoricalPractice;
        private GroupBox groupBox31;
        private TextBox testWeather;
        private Label label69;
        private TextBox testTemp;
        private TextBox testHumidity;
        private Label label70;
        private Label label71;
        private MenuItem mniMerge;
        private ColumnHeader TyreSupplierUpdated;
        private TabPage tabPageTyreSupplier;
        private GroupBox groupBox11;
        private Label label76;
        private Label label75;
        private Label label74;
        private Label label73;
        private Label label72;
        private TextBox textBoxWarmupDistance;
        private TextBox textBoxDurability;
        private TextBox textBoxPeakTemperature;
        private TextBox textBoxWetPerformance;
        private TextBox textBoxDryPerformance;
        private Button buttonTyreSupplierError;
        private MenuItem menuItemHistoricalRaceSetup;
        private ColumnHeader tyreWearHeader;
        public NotifyIcon notifyIconGO;
        private ContextMenuStrip contextMenuNotification;
        private ToolStripMenuItem menuItemNotificationUpdateAll;
        private ToolStripMenuItem menuItemNotificationExit;
        private ToolStripMenuItem menuItemNotificationOpen;
        private MenuItem menuItemImportOldSetups;
        private Button buttonQualifyError;
        private MenuItem menuItemHistoricalWear;
        private Button buttonMainPageError;
        private GroupBox groupBox28;
        private ListBox FavoriteTracksView;
        private MenuItem menuItemHistoricalQ1Setup;
        private TabPage tabPageSponsor;
        private GroupBox groupBox29;
        private ListView listViewOngoingSponsorContracts;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader29;
        private ColumnHeader columnHeader42;
        private ColumnHeader columnHeader43;
        private ColumnHeader columnHeader44;
        private GroupBox groupBox30;
        private ListView listViewOngoingSponsorNegotiations;
        private ColumnHeader columnHeader45;
        private ColumnHeader columnHeader46;
        private ColumnHeader columnHeader47;
        private ColumnHeader columnHeader48;
        private ColumnHeader columnHeader49;
        private ColumnHeader columnHeader50;
        private ColumnHeader sponsorUpdated;
        private Button buttonSponsorError;
        private TextBox textBoxWet;
        private Label label132;
        private Button buttonStrategyError;
        private GroupBox groupBox32;
        private TextBox textBoxBoostLaps1;
        private TextBox textBoxBoostLaps3;
        private TextBox textBoxBoostLaps2;
        private TextBox textBoxEnergy;
        private Label label133;
        private MenuItem menuItem9;
        private MenuItem menuItem10;
        private MenuItem menuItem11;
        private MenuItem mniCheckUpdate;
        private MenuItem menuItemAllTracks;
        private Button LoadButton;
        private static readonly RegexOptions options = RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline;
        private static Regex reg = new Regex("((?<val>\\d{1,10})([.]?))", MainForm.options);
        private bool _initialized;

        public MainForm()
        {
            Datas.KeepDataWithApp = false;
            Datas.AutoCheck = false;

            InitializeComponent();

            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.AppStarting;

            GetRegistrySettings();

            WireCommunication(); 

            Cursor.Current = current;

            Shown += OnMainFormShown;
        }

        private void WireCommunication()
        {
            Datas.Communications.CredentialProvider = () =>
            {
                return (Datas.Username, Datas.Password);
            };
        }
        
        //public string ConvertToHtmlEncoding(string input) => HttpUtility.UrlEncode(input);
        private bool _initializing;
        
        private void InitializeApplicationData()
        {
            if (_initializing) return;

            try
            {
                _initializing = true;

                Cursor.Current = Cursors.WaitCursor;


                LoadTracks();
                LoadData();
                Datas.Communications.EnsureSession();

                statusBarPanel3.Text = "Ready";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to initialize application:\n" + ex.Message,
                    "Startup Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                _initializing = false;
            }
        }
        private void OnMainFormShown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (_initialized)
                return;

            _initialized = true;

            this.BeginInvoke(new Action(() =>
            {
                InitializeApplicationData();
            }));
            this.statusBarPanel3.Text = "Ready";
            
            Cursor.Current = Cursors.AppStarting;
        }

        private void InitializeComponent()
        {
            this.components = (IContainer)new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            this.LoadButton = new Button();
            this.mainMenu1 = new MainMenu(this.components);
            this.menuItem1 = new MenuItem();
            this.mniOpen = new MenuItem();
            this.mniSave = new MenuItem();
            this.menuItemSaveAs = new MenuItem();
            this.mniMerge = new MenuItem();
            this.menuItem17 = new MenuItem();
            this.menuItem3 = new MenuItem();
            this.mniGetAllDatas = new MenuItem();
            this.menuItem11 = new MenuItem();
            this.mniCheckUpdate = new MenuItem();
            this.menuItem4 = new MenuItem();
            this.menuItemAllTracks = new MenuItem();
            this.menuItemCurrentSeason = new MenuItem();
            this.menuItem9 = new MenuItem();
            this.menuItem19 = new MenuItem();
            this.menuItemHistoricalFuel = new MenuItem();
            this.menuItemHistoricalPractice = new MenuItem();
            this.menuItemHistoricalQ1Setup = new MenuItem();
            this.menuItemHistoricalRaceSetup = new MenuItem();
            this.menuItemHistoricalWear = new MenuItem();
            this.menuItem10 = new MenuItem();
            this.menuItem13 = new MenuItem();
            this.menuItemRaces = new MenuItem();
            this.menuItemFiscalReport = new MenuItem();
            this.menuItemAvgCarWear = new MenuItem();
            this.menuItemPitstops = new MenuItem();
            this.menuItem8 = new MenuItem();
            this.menuItemDriverTraining = new MenuItem();
            this.menuItem18 = new MenuItem();
            this.menuItemPitStrategy = new MenuItem();
            this.menuItem7 = new MenuItem();
            this.menuItem6 = new MenuItem();
            this.menuItem20 = new MenuItem();
            this.menuItemImportOldSetups = new MenuItem();
            this.menuItem12 = new MenuItem();
            this.menuItem16 = new MenuItem();
            this.statusBar1 = new StatusBar();
            this.statusBarPanel1 = new StatusBarPanel();
            this.statusBarPanel2 = new StatusBarPanel();
            this.statusBarPanel3 = new StatusBarPanel();
            this.statusBarPanelVersion = new StatusBarPanel();
            this.tabControl1 = new TabControl();
            this.tabPageDriver = new TabPage();
            this.contextMenuDriver = new ContextMenu();
            this.menuItem5 = new MenuItem();
            this.textBoxEnergy = new TextBox();
            this.label133 = new Label();
            this.groupBox28 = new GroupBox();
            this.FavoriteTracksView = new ListBox();
            this.textBoxCharisma = new TextBox();
            this.textBoxAverage = new TextBox();
            this.textBoxnationality = new TextBox();
            this.textBoxname = new TextBox();
            this.textBoxContract = new TextBox();
            this.textBoxSalary = new TextBox();
            this.textBoxAge = new TextBox();
            this.textBoxWeight = new TextBox();
            this.textBoxMotivation = new TextBox();
            this.textBoxStamina = new TextBox();
            this.textBoxTechnicalInsight = new TextBox();
            this.textBoxExperience = new TextBox();
            this.textBoxAggresiveness = new TextBox();
            this.textBoxTalent = new TextBox();
            this.textBoxConcentration = new TextBox();
            this.textBoxOverall = new TextBox();
            this.textBoxFastestLaps = new TextBox();
            this.textBoxPoles = new TextBox();
            this.textBoxPoints = new TextBox();
            this.textBoxPodiums = new TextBox();
            this.textBoxWins = new TextBox();
            this.textBoxnumGPs = new TextBox();
            this.textBoxtrophies = new TextBox();
            this.label46 = new Label();
            this.Races = new Label();
            this.label47 = new Label();
            this.label48 = new Label();
            this.label49 = new Label();
            this.label50 = new Label();
            this.label51 = new Label();
            this.label52 = new Label();
            this.label53 = new Label();
            this.label54 = new Label();
            this.label55 = new Label();
            this.label56 = new Label();
            this.label57 = new Label();
            this.label58 = new Label();
            this.label59 = new Label();
            this.label60 = new Label();
            this.label61 = new Label();
            this.label62 = new Label();
            this.label63 = new Label();
            this.label64 = new Label();
            this.label65 = new Label();
            this.label66 = new Label();
            this.label67 = new Label();
            this.label68 = new Label();
            this.groupBox7 = new GroupBox();
            this.groupBox8 = new GroupBox();
            this.textBoxReputation = new TextBox();
            this.label131 = new Label();
            this.groupBox9 = new GroupBox();
            this.groupBox10 = new GroupBox();
            this.tabPageTechnicalDirector = new TabPage();
            this.groupBox27 = new GroupBox();
            this.textBoxTDAge = new TextBox();
            this.label130 = new Label();
            this.textBoxTDContract = new TextBox();
            this.textBoxTDSalary = new TextBox();
            this.label127 = new Label();
            this.label128 = new Label();
            this.label129 = new Label();
            this.groupBox26 = new GroupBox();
            this.groupBox25 = new GroupBox();
            this.textBoxTDMotivation = new TextBox();
            this.textBoxTDPitCoordination = new TextBox();
            this.textBoxTDExperience = new TextBox();
            this.textBoxTDAerodynamics = new TextBox();
            this.textBoxTDElectronics = new TextBox();
            this.textBoxTDMechanics = new TextBox();
            this.textBoxTDLeadership = new TextBox();
            this.textBoxTDOverall = new TextBox();
            this.label119 = new Label();
            this.label120 = new Label();
            this.label121 = new Label();
            this.label122 = new Label();
            this.label123 = new Label();
            this.label124 = new Label();
            this.label125 = new Label();
            this.label126 = new Label();
            this.groupBox24 = new GroupBox();
            this.textBoxTDWins = new TextBox();
            this.textBoxTDNumGps = new TextBox();
            this.textBoxTDTrophies = new TextBox();
            this.label116 = new Label();
            this.label117 = new Label();
            this.label118 = new Label();
            this.textBoxTDNationality = new TextBox();
            this.textBoxTDName = new TextBox();
            this.label114 = new Label();
            this.label115 = new Label();
            this.tabPageCar = new TabPage();
            this.buttonStrategyError = new Button();
            this.buttonSponsorError = new Button();
            this.buttonMainPageError = new Button();
            this.buttonQualifyError = new Button();
            this.buttonTyreSupplierError = new Button();
            this.buttonSummaryError = new Button();
            this.buttonTDError = new Button();
            this.buttonGetSummary = new Button();
            this.buttonFinance = new Button();
            this.buttonTestErr = new Button();
            this.buttonDriver = new Button();
            this.buttonCarError = new Button();
            this.buttonRaceError = new Button();
            this.buttonPracErr = new Button();
            this.groupBox1 = new GroupBox();
            this.textBoxCoWear = new TextBox();
            this.textBoxElWear = new TextBox();
            this.textBoxSiWear = new TextBox();
            this.textBoxUnWear = new TextBox();
            this.textBoxChWear = new TextBox();
            this.textBoxFwWear = new TextBox();
            this.textBoxBrWear = new TextBox();
            this.textBoxEnWear = new TextBox();
            this.textBoxSuWear = new TextBox();
            this.textBoxGeWear = new TextBox();
            this.textBoxRwWear = new TextBox();
            this.label13 = new Label();
            this.label3 = new Label();
            this.textBoxen1 = new TextBox();
            this.textBoxTestAcceleration = new TextBox();
            this.textBoxen2 = new TextBox();
            this.textBoxTestHandling = new TextBox();
            this.label5 = new Label();
            this.textBoxch1 = new TextBox();
            this.textBoxTestPower = new TextBox();
            this.textBoxch2 = new TextBox();
            this.label95 = new Label();
            this.textBoxHandling = new TextBox();
            this.textBoxAcceleration = new TextBox();
            this.textBoxPower = new TextBox();
            this.label19 = new Label();
            this.label18 = new Label();
            this.label17 = new Label();
            this.textBoxbr2 = new TextBox();
            this.textBoxbr1 = new TextBox();
            this.textBoxco2 = new TextBox();
            this.textBoxco1 = new TextBox();
            this.textBoxsi2 = new TextBox();
            this.textBoxsi1 = new TextBox();
            this.textBoxel2 = new TextBox();
            this.textBoxel1 = new TextBox();
            this.textBoxun2 = new TextBox();
            this.textBoxun1 = new TextBox();
            this.textBoxsu2 = new TextBox();
            this.textBoxsu1 = new TextBox();
            this.textBoxgb2 = new TextBox();
            this.textBoxgb1 = new TextBox();
            this.textBoxrw2 = new TextBox();
            this.textBoxrw1 = new TextBox();
            this.label12 = new Label();
            this.textBoxfw2 = new TextBox();
            this.textBoxfw1 = new TextBox();
            this.label11 = new Label();
            this.label10 = new Label();
            this.label9 = new Label();
            this.label8 = new Label();
            this.label7 = new Label();
            this.label6 = new Label();
            this.label4 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.label96 = new Label();
            this.label97 = new Label();
            this.buttonGetTracks = new Button();
            this.tabPageStaff = new TabPage();
            this.groupBox23 = new GroupBox();
            this.textBoxStaffFacilities = new TextBox();
            this.textBoxStaffSalary = new TextBox();
            this.label112 = new Label();
            this.label113 = new Label();
            this.groupBox22 = new GroupBox();
            this.textBoxStaffCommercial = new TextBox();
            this.textBoxStaffAlloy = new TextBox();
            this.textBoxStaffEngineering = new TextBox();
            this.textBoxStaffRDDesign = new TextBox();
            this.textBoxStaffRDWorkshop = new TextBox();
            this.textBoxStaffWindtunnel = new TextBox();
            this.label108 = new Label();
            this.label106 = new Label();
            this.label104 = new Label();
            this.label110 = new Label();
            this.label107 = new Label();
            this.label109 = new Label();
            this.label105 = new Label();
            this.textBoxStaffPitstop = new TextBox();
            this.groupBox21 = new GroupBox();
            this.textBoxStaffEfficiency = new TextBox();
            this.textBoxStaffConcentration = new TextBox();
            this.textBoxStaffStressHandling = new TextBox();
            this.textBoxStaffTechnicalSkill = new TextBox();
            this.textBoxStaffMotivation = new TextBox();
            this.panel1 = new Panel();
            this.label99 = new Label();
            this.label111 = new Label();
            this.label100 = new Label();
            this.label101 = new Label();
            this.label102 = new Label();
            this.label103 = new Label();
            this.textBoxStaffExperience = new TextBox();
            this.groupBox20 = new GroupBox();
            this.label98 = new Label();
            this.textBoxStaffOverall = new TextBox();
            this.tabPageSeason = new TabPage();
            this.listViewSeason = new ListView();
            this.number = new ColumnHeader();
            this.trackname = new ColumnHeader();
            this.carUpdated = new ColumnHeader();
            this.DriverUpdated = new ColumnHeader();
            this.TyreSupplierUpdated = new ColumnHeader();
            this.PractiseUpdated = new ColumnHeader();
            this.QualifyUpdated = new ColumnHeader();
            this.Qualify2Updated = new ColumnHeader();
            this.StrategyUpdated = new ColumnHeader();
            this.raceUpdated = new ColumnHeader();
            this.sponsorUpdated = new ColumnHeader();
            this.contextMenuSeason = new ContextMenu();
            this.menuItem2 = new MenuItem();
            this.tabPageTesting = new TabPage();
            this.groupBox31 = new GroupBox();
            this.testWeather = new TextBox();
            this.label69 = new Label();
            this.testTemp = new TextBox();
            this.testHumidity = new TextBox();
            this.label70 = new Label();
            this.label71 = new Label();
            this.textBoxTestingComments = new TextBox();
            this.listViewTesting = new ListView();
            this.lapsTestHeader = new ColumnHeader();
            this.meanTimeHeader = new ColumnHeader();
            this.bestTimeHeader = new ColumnHeader();
            this.lapLimitHeader = new ColumnHeader();
            this.lapsDoneHeader = new ColumnHeader();
            this.fuelStartHeader = new ColumnHeader();
            this.tyreWearHeader = new ColumnHeader();
            this.fuelLeftHeader = new ColumnHeader();
            this.priorityHeader = new ColumnHeader();
            this.fWingTestHeader = new ColumnHeader();
            this.rWingTestHeader = new ColumnHeader();
            this.engineTestHeader = new ColumnHeader();
            this.brakesTestHeader = new ColumnHeader();
            this.gearTestHeader = new ColumnHeader();
            this.suspTestHeader = new ColumnHeader();
            this.tyresTestHeader = new ColumnHeader();
            this.groupBox19 = new GroupBox();
            this.listViewTest = new ListView();
            this.columnHeader13 = new ColumnHeader();
            this.columnHeader14 = new ColumnHeader();
            this.columnHeader15 = new ColumnHeader();
            this.columnHeader16 = new ColumnHeader();
            this.tabPagePractice = new TabPage();
            this.buttonExport = new Button();
            this.comboBoxPrac = new ComboBox();
            this.textBoxPracHum = new TextBox();
            this.textBoxPracTemp = new TextBox();
            this.label16 = new Label();
            this.label15 = new Label();
            this.textBoxPracWeather = new TextBox();
            this.label14 = new Label();
            this.listViewPractice = new ListView();
            this.columnHeader1 = new ColumnHeader();
            this.columnHeader2 = new ColumnHeader();
            this.columnHeader3 = new ColumnHeader();
            this.columnHeader4 = new ColumnHeader();
            this.columnHeader5 = new ColumnHeader();
            this.columnHeader6 = new ColumnHeader();
            this.columnHeader7 = new ColumnHeader();
            this.columnHeader8 = new ColumnHeader();
            this.columnHeader9 = new ColumnHeader();
            this.columnHeader10 = new ColumnHeader();
            this.columnHeader11 = new ColumnHeader();
            this.textBoxPracComments = new TextBox();
            this.tabPageQualify = new TabPage();
            this.groupQualify2 = new GroupBox();
            this.listViewQualify2 = new ListView();
            this.columnHeader32 = new ColumnHeader();
            this.columnHeader33 = new ColumnHeader();
            this.columnHeader34 = new ColumnHeader();
            this.columnHeader35 = new ColumnHeader();
            this.columnHeader36 = new ColumnHeader();
            this.columnHeader37 = new ColumnHeader();
            this.columnHeader38 = new ColumnHeader();
            this.columnHeader39 = new ColumnHeader();
            this.columnHeader40 = new ColumnHeader();
            this.columnHeader41 = new ColumnHeader();
            this.groupQualify1 = new GroupBox();
            this.listViewQualify1 = new ListView();
            this.columnHeader22 = new ColumnHeader();
            this.columnHeader23 = new ColumnHeader();
            this.columnHeader24 = new ColumnHeader();
            this.columnHeader25 = new ColumnHeader();
            this.columnHeader26 = new ColumnHeader();
            this.columnHeader27 = new ColumnHeader();
            this.columnHeader28 = new ColumnHeader();
            this.columnHeader30 = new ColumnHeader();
            this.columnHeader31 = new ColumnHeader();
            this.tabPageStrategy = new TabPage();
            this.groupBox32 = new GroupBox();
            this.textBoxBoostLaps3 = new TextBox();
            this.textBoxBoostLaps2 = new TextBox();
            this.textBoxBoostLaps1 = new TextBox();
            this.groupBox3 = new GroupBox();
            this.labelWaitDry = new Label();
            this.labelWaitRain = new Label();
            this.label35 = new Label();
            this.textBoxWaitDry = new TextBox();
            this.textBoxTyresDry = new TextBox();
            this.textBoxTyresRain = new TextBox();
            this.label27 = new Label();
            this.label28 = new Label();
            this.label34 = new Label();
            this.label26 = new Label();
            this.textBoxTyresStart = new TextBox();
            this.textBoxWaitRain = new TextBox();
            this.groupBox6 = new GroupBox();
            this.textBoxSusp = new TextBox();
            this.textBoxGear = new TextBox();
            this.textBoxBra = new TextBox();
            this.textBoxEng = new TextBox();
            this.textBoxRWing = new TextBox();
            this.label44 = new Label();
            this.label43 = new Label();
            this.label42 = new Label();
            this.label41 = new Label();
            this.label40 = new Label();
            this.label29 = new Label();
            this.textBoxFWing = new TextBox();
            this.groupBox5 = new GroupBox();
            this.label45 = new Label();
            this.textBoxStartStrategy = new TextBox();
            this.label36 = new Label();
            this.label39 = new Label();
            this.label38 = new Label();
            this.textBoxPitLimit = new TextBox();
            this.textBoxPitIfSolvableProblem = new TextBox();
            this.checkBoxRefuel = new CheckBox();
            this.label37 = new Label();
            this.groupBox4 = new GroupBox();
            this.textBoxWet = new TextBox();
            this.label132 = new Label();
            this.textBoxMalfunction = new TextBox();
            this.textBoxDefend = new TextBox();
            this.textBoxClear = new TextBox();
            this.label30 = new Label();
            this.label33 = new Label();
            this.label32 = new Label();
            this.label31 = new Label();
            this.textBoxOvertake = new TextBox();
            this.groupBox2 = new GroupBox();
            this.textBoxFuel5 = new TextBox();
            this.textBoxFuel4 = new TextBox();
            this.textBoxFuel3 = new TextBox();
            this.textBoxFuel2 = new TextBox();
            this.textBoxFuel1 = new TextBox();
            this.label22 = new Label();
            this.label21 = new Label();
            this.label20 = new Label();
            this.label24 = new Label();
            this.label25 = new Label();
            this.label23 = new Label();
            this.textBoxFuel = new TextBox();
            this.tabPageWeather = new TabPage();
            this.groupBox16 = new GroupBox();
            this.textBoxPracW = new TextBox();
            this.label89 = new Label();
            this.textBoxPracT = new TextBox();
            this.textBoxPracH = new TextBox();
            this.label90 = new Label();
            this.label91 = new Label();
            this.groupBox15 = new GroupBox();
            this.textBoxForecast4t = new TextBox();
            this.textBoxForecast4h = new TextBox();
            this.textBoxForecast4r = new TextBox();
            this.label86 = new Label();
            this.label87 = new Label();
            this.label88 = new Label();
            this.groupBox14 = new GroupBox();
            this.textBoxForecast3t = new TextBox();
            this.textBoxForecast3h = new TextBox();
            this.textBoxForecast3r = new TextBox();
            this.label83 = new Label();
            this.label84 = new Label();
            this.label85 = new Label();
            this.groupBox13 = new GroupBox();
            this.textBoxForecast2t = new TextBox();
            this.textBoxForecast2h = new TextBox();
            this.textBoxForecast2r = new TextBox();
            this.label80 = new Label();
            this.label81 = new Label();
            this.label82 = new Label();
            this.groupBox12 = new GroupBox();
            this.textBoxForecast1t = new TextBox();
            this.textBoxForecast1h = new TextBox();
            this.textBoxForecast1r = new TextBox();
            this.label79 = new Label();
            this.label78 = new Label();
            this.label77 = new Label();
            this.groupBox17 = new GroupBox();
            this.textBoxQualW = new TextBox();
            this.label92 = new Label();
            this.textBoxQualT = new TextBox();
            this.textBoxQualH = new TextBox();
            this.label93 = new Label();
            this.label94 = new Label();
            this.groupBox18 = new GroupBox();
            this.tabPageFinance = new TabPage();
            this.listViewFinance = new ListView();
            this.columnHeader17 = new ColumnHeader();
            this.columnHeader18 = new ColumnHeader();
            this.columnHeader19 = new ColumnHeader();
            this.columnHeader20 = new ColumnHeader();
            this.columnHeader21 = new ColumnHeader();
            this.tabPageTyreSupplier = new TabPage();
            this.groupBox11 = new GroupBox();
            this.textBoxWarmupDistance = new TextBox();
            this.textBoxDurability = new TextBox();
            this.textBoxPeakTemperature = new TextBox();
            this.textBoxWetPerformance = new TextBox();
            this.textBoxDryPerformance = new TextBox();
            this.label76 = new Label();
            this.label75 = new Label();
            this.label74 = new Label();
            this.label73 = new Label();
            this.label72 = new Label();
            this.tabPageSponsor = new TabPage();
            this.groupBox30 = new GroupBox();
            this.listViewOngoingSponsorNegotiations = new ListView();
            this.columnHeader45 = new ColumnHeader();
            this.columnHeader46 = new ColumnHeader();
            this.columnHeader47 = new ColumnHeader();
            this.columnHeader48 = new ColumnHeader();
            this.columnHeader49 = new ColumnHeader();
            this.columnHeader50 = new ColumnHeader();
            this.groupBox29 = new GroupBox();
            this.listViewOngoingSponsorContracts = new ListView();
            this.columnHeader12 = new ColumnHeader();
            this.columnHeader29 = new ColumnHeader();
            this.columnHeader42 = new ColumnHeader();
            this.columnHeader43 = new ColumnHeader();
            this.columnHeader44 = new ColumnHeader();
            this.toolTipCarPower = new ToolTip(this.components);
            this.toolTipCarHandling = new ToolTip(this.components);
            this.toolTipCarAcceleration = new ToolTip(this.components);
            this.toolTipCarTestPower = new ToolTip(this.components);
            this.toolTipCarTestHandling = new ToolTip(this.components);
            this.toolTipCarTestAcceleration = new ToolTip(this.components);
            this.toolTipCarFW = new ToolTip(this.components);
            this.toolTipCarRW = new ToolTip(this.components);
            this.toolTipCarEng = new ToolTip(this.components);
            this.toolTipCarGea = new ToolTip(this.components);
            this.toolTipCarCha = new ToolTip(this.components);
            this.toolTipCarSus = new ToolTip(this.components);
            this.toolTipCarUnd = new ToolTip(this.components);
            this.toolTipCarEle = new ToolTip(this.components);
            this.toolTipCarSid = new ToolTip(this.components);
            this.toolTipCarCoo = new ToolTip(this.components);
            this.toolTipCarBra = new ToolTip(this.components);
            this.toolTipTal = new ToolTip(this.components);
            this.ToolTipWei = new ToolTip(this.components);
            this.toolTipAgg = new ToolTip(this.components);
            this.toolTipTI = new ToolTip(this.components);
            this.toolTipExp = new ToolTip(this.components);
            this.toolTipSta = new ToolTip(this.components);
            this.toolTipOA = new ToolTip(this.components);
            this.toolTipCha = new ToolTip(this.components);
            this.toolTipConc = new ToolTip(this.components);
            this.toolTipMot = new ToolTip(this.components);
            this.toolTipStaffOverall = new ToolTip(this.components);
            this.toolTipStaffExperience = new ToolTip(this.components);
            this.toolTipStaffMotivation = new ToolTip(this.components);
            this.toolTipStaffTechnicalSkill = new ToolTip(this.components);
            this.toolTipStaffStress = new ToolTip(this.components);
            this.toolTipStaffConcentration = new ToolTip(this.components);
            this.toolTipStaffEfficiency = new ToolTip(this.components);
            this.toolTipStaffWindtunnel = new ToolTip(this.components);
            this.toolTipStaffPitstop = new ToolTip(this.components);
            this.toolTipStaffRDWorkshop = new ToolTip(this.components);
            this.toolTipStaffRDDesign = new ToolTip(this.components);
            this.toolTipStaffAlloy = new ToolTip(this.components);
            this.toolTipStaffCommercial = new ToolTip(this.components);
            this.toolTipStaffSalary = new ToolTip(this.components);
            this.toolTipStaffFacilities = new ToolTip(this.components);
            this.toolTipStaffEngineering = new ToolTip(this.components);
            this.toolTipRep = new ToolTip(this.components);
            this.notifyIconGO = new NotifyIcon(this.components);
            this.contextMenuNotification = new ContextMenuStrip(this.components);
            this.menuItemNotificationOpen = new ToolStripMenuItem();
            this.menuItemNotificationUpdateAll = new ToolStripMenuItem();
            this.menuItemNotificationExit = new ToolStripMenuItem();
            this.statusBarPanel1.BeginInit();
            this.statusBarPanel2.BeginInit();
            this.statusBarPanel3.BeginInit();
            this.statusBarPanelVersion.BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageDriver.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPageTechnicalDirector.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.tabPageCar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageStaff.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.tabPageSeason.SuspendLayout();
            this.tabPageTesting.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.tabPagePractice.SuspendLayout();
            this.tabPageQualify.SuspendLayout();
            this.groupQualify2.SuspendLayout();
            this.groupQualify1.SuspendLayout();
            this.tabPageStrategy.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageWeather.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.tabPageFinance.SuspendLayout();
            this.tabPageTyreSupplier.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPageSponsor.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.contextMenuNotification.SuspendLayout();
            this.SuspendLayout();
            this.LoadButton.Location = new Point(504, 16);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new Size(80, 23);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load";
            this.LoadButton.Visible = false;
            this.LoadButton.Click += new EventHandler(this.LoadButton_Click);
            this.mainMenu1.MenuItems.AddRange(new MenuItem[6]
            {
        this.menuItem1,
        this.menuItem3,
        this.menuItem4,
        this.menuItem8,
        this.menuItem18,
        this.menuItem12
            });
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new MenuItem[5]
            {
        this.mniOpen,
        this.mniSave,
        this.menuItemSaveAs,
        this.mniMerge,
        this.menuItem17
            });
            this.menuItem1.Text = "&File";
            this.mniOpen.Index = 0;
            this.mniOpen.Shortcut = Shortcut.CtrlO;
            this.mniOpen.Text = "&Open";
            this.mniOpen.Click += new EventHandler(this.MniOpenClick);
            this.mniSave.Index = 1;
            this.mniSave.Shortcut = Shortcut.CtrlS;
            this.mniSave.Text = "&Save";
            this.mniSave.Click += new EventHandler(this.MniSaveClick);
            this.menuItemSaveAs.Index = 2;
            this.menuItemSaveAs.Shortcut = Shortcut.CtrlA;
            this.menuItemSaveAs.Text = "Save &as...";
            this.menuItemSaveAs.Click += new EventHandler(this.menuItemSaveAs_Click);
            this.mniMerge.Index = 3;
            this.mniMerge.Shortcut = Shortcut.CtrlM;
            this.mniMerge.Text = "&Merge from other file";
            this.mniMerge.Click += new EventHandler(this.MniMergeClick);
            this.mniMerge.Enabled = false;
            this.menuItem17.Index = 4;
            this.menuItem17.Shortcut = Shortcut.CtrlX;
            this.menuItem17.Text = "E&xit";
            this.menuItem17.Click += new EventHandler(this.menuItem17_Click);
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new MenuItem[3]
            {
        this.mniGetAllDatas,
        this.menuItem11,
        this.mniCheckUpdate
            });
            this.menuItem3.Text = "&Online";
            this.mniGetAllDatas.Index = 0;
            this.mniGetAllDatas.Shortcut = Shortcut.F5;
            this.mniGetAllDatas.Text = "&Get All Data";
            this.mniGetAllDatas.Click += new EventHandler(this.menuItem21_Click);
            this.menuItem11.Index = 1;
            this.menuItem11.Text = "-";
            this.mniCheckUpdate.Index = 2;
            this.mniCheckUpdate.Shortcut = Shortcut.F12;
            this.mniCheckUpdate.Text = "&Check for update";
            this.mniCheckUpdate.Click += new EventHandler(this.MniCheckUpdateClick);
            this.menuItem4.Index = 2;
            this.menuItem4.MenuItems.AddRange(new MenuItem[15]
            {
        this.menuItemAllTracks,
        this.menuItemCurrentSeason,
        this.menuItem9,
        this.menuItem19,
        this.menuItemHistoricalFuel,
        this.menuItemHistoricalPractice,
        this.menuItemHistoricalQ1Setup,
        this.menuItemHistoricalRaceSetup,
        this.menuItemHistoricalWear,
        this.menuItem10,
        this.menuItem13,
        this.menuItemRaces,
        this.menuItemFiscalReport,
        this.menuItemAvgCarWear,
        this.menuItemPitstops
            });
            this.menuItem4.Text = "&View";
            this.menuItemAllTracks.Index = 0;
            this.menuItemAllTracks.Text = "&All Tracks...";
            this.menuItemAllTracks.Click += new EventHandler(this.menuItemAllTracks_Click);
            this.menuItemCurrentSeason.Index = 1;
            this.menuItemCurrentSeason.Text = "&Tracks for current season...";
            this.menuItemCurrentSeason.Click += new EventHandler(this.menuItem11_Click_1);
            this.menuItem9.Index = 2;
            this.menuItem9.Text = "-";
            this.menuItem19.Index = 3;
            this.menuItem19.Text = "Historical Tyre &Wear...";
            this.menuItem19.Click += new EventHandler(this.menuItem18_Click);
            this.menuItemHistoricalFuel.Index = 4;
            this.menuItemHistoricalFuel.Text = "Historical Fuel &Consumption...";
            this.menuItemHistoricalFuel.Click += new EventHandler(this.menuItemHistoricalFuel_Click);
            this.menuItemHistoricalPractice.Index = 5;
            this.menuItemHistoricalPractice.Text = "Historical &Practice ...";
            this.menuItemHistoricalPractice.Click += new EventHandler(this.menuItemHistoricalPractice_Click);
            this.menuItemHistoricalQ1Setup.Index = 6;
            this.menuItemHistoricalQ1Setup.Text = "Historical &Q1 Setup";
            this.menuItemHistoricalQ1Setup.Click += new EventHandler(this.menuItemHistoricalQ1Setup_Click);
            this.menuItemHistoricalRaceSetup.Index = 7;
            this.menuItemHistoricalRaceSetup.Text = "Historical Race &Setup";
            this.menuItemHistoricalRaceSetup.Click += new EventHandler(this.menuItemHistoricalRaceSetup_Click);
            this.menuItemHistoricalWear.Index = 8;
            this.menuItemHistoricalWear.Text = "H&istorical Car Parts Wear";
            this.menuItemHistoricalWear.Click += new EventHandler(this.menuItemHistoricalWear_Click);
            this.menuItem10.Index = 9;
            this.menuItem10.Text = "-";
            this.menuItem13.Index = 10;
            this.menuItem13.Text = "Car &History...";
            this.menuItem13.Click += new EventHandler(this.menuItem13_Click_1);
            this.menuItemRaces.Index = 11;
            this.menuItemRaces.Text = "&Races...";
            this.menuItemRaces.Click += new EventHandler(this.menuItemRaces_Click);
            this.menuItemFiscalReport.Index = 12;
            this.menuItemFiscalReport.Text = "&Fiscal Report...";
            this.menuItemFiscalReport.Click += new EventHandler(this.menuItemFiscalReport_Click);
            this.menuItemAvgCarWear.Index = 13;
            this.menuItemAvgCarWear.Text = "A&verage Car Wear...";
            this.menuItemAvgCarWear.Click += new EventHandler(this.menuItemAvgCarWear_Click);
            this.menuItemPitstops.Index = 14;
            this.menuItemPitstops.Text = "Pitst&ops...";
            this.menuItemPitstops.Click += new EventHandler(this.menuItemPitstops_Click);
            this.menuItem8.Index = 3;
            this.menuItem8.MenuItems.AddRange(new MenuItem[1]
            {
        this.menuItemDriverTraining
            });
            this.menuItem8.Text = "T&raining";
            this.menuItemDriverTraining.Index = 0;
            this.menuItemDriverTraining.Text = "&Driver...";
            this.menuItemDriverTraining.Click += new EventHandler(this.menuItemDriverTraining_Click);
            this.menuItem18.Index = 4;
            this.menuItem18.MenuItems.AddRange(new MenuItem[5]
            {
        this.menuItemPitStrategy,
        this.menuItem7,
        this.menuItem6,
        this.menuItem20,
        this.menuItemImportOldSetups
            });
            this.menuItem18.Text = "&Tools";
            this.menuItemPitStrategy.Index = 0;
            this.menuItemPitStrategy.Text = "&Pit strategy...";
            this.menuItemPitStrategy.Click += new EventHandler(this.menuItemPitStrategy_Click);
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "&Update tracks";
            this.menuItem7.Click += new EventHandler(this.MniAllTracksClick);
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "-";
            this.menuItem20.Index = 3;
            this.menuItem20.Text = "&Settings...";
            this.menuItem20.Click += new EventHandler(this.menuItem20_Click);
            this.menuItemImportOldSetups.Index = 4;
            this.menuItemImportOldSetups.Text = "&Import old setups";
            this.menuItemImportOldSetups.Visible = false;
            this.menuItem12.Index = 5;
            this.menuItem12.MenuItems.AddRange(new MenuItem[1]
            {
        this.menuItem16
            });
            this.menuItem12.Text = "&Help";
            this.menuItem16.Index = 0;
            this.menuItem16.Text = "&About...";
            this.menuItem16.Click += new EventHandler(this.menuItem16_Click);
            this.statusBar1.Location = new Point(0, 383);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new StatusBarPanel[4]
            {
        this.statusBarPanel1,
        this.statusBarPanel2,
        this.statusBarPanel3,
        this.statusBarPanelVersion
            });
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new Size(813, 22);
            this.statusBar1.TabIndex = 8;
            this.statusBar1.Text = "statusBar1gg";
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 50;
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Text = "Next race:";
            this.statusBarPanel2.Width = 150;
            this.statusBarPanel3.Name = "statusBarPanel3";
            this.statusBarPanel3.Width = 450;
            this.statusBarPanelVersion.Name = "statusBarPanelVersion";
            this.statusBarPanelVersion.Width = 124;
            this.tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.tabControl1.Controls.Add((Control)this.tabPageDriver);
            this.tabControl1.Controls.Add((Control)this.tabPageTechnicalDirector);
            this.tabControl1.Controls.Add((Control)this.tabPageCar);
            this.tabControl1.Controls.Add((Control)this.tabPageStaff);
            this.tabControl1.Controls.Add((Control)this.tabPageSeason);
            this.tabControl1.Controls.Add((Control)this.tabPageTesting);
            this.tabControl1.Controls.Add((Control)this.tabPagePractice);
            this.tabControl1.Controls.Add((Control)this.tabPageQualify);
            this.tabControl1.Controls.Add((Control)this.tabPageStrategy);
            this.tabControl1.Controls.Add((Control)this.tabPageWeather);
            this.tabControl1.Controls.Add((Control)this.tabPageFinance);
            this.tabControl1.Controls.Add((Control)this.tabPageTyreSupplier);
            this.tabControl1.Controls.Add((Control)this.tabPageSponsor);
            this.tabControl1.Location = new Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(805, 369);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.KeyUp += new KeyEventHandler(this.Form1_KeyUp);
            this.tabPageDriver.ContextMenu = this.contextMenuDriver;
            this.tabPageDriver.Controls.Add((Control)this.textBoxEnergy);
            this.tabPageDriver.Controls.Add((Control)this.label133);
            this.tabPageDriver.Controls.Add((Control)this.groupBox28);
            this.tabPageDriver.Controls.Add((Control)this.textBoxCharisma);
            this.tabPageDriver.Controls.Add((Control)this.textBoxAverage);
            this.tabPageDriver.Controls.Add((Control)this.textBoxnationality);
            this.tabPageDriver.Controls.Add((Control)this.textBoxname);
            this.tabPageDriver.Controls.Add((Control)this.textBoxContract);
            this.tabPageDriver.Controls.Add((Control)this.textBoxSalary);
            this.tabPageDriver.Controls.Add((Control)this.textBoxAge);
            this.tabPageDriver.Controls.Add((Control)this.textBoxWeight);
            this.tabPageDriver.Controls.Add((Control)this.textBoxMotivation);
            this.tabPageDriver.Controls.Add((Control)this.textBoxStamina);
            this.tabPageDriver.Controls.Add((Control)this.textBoxTechnicalInsight);
            this.tabPageDriver.Controls.Add((Control)this.textBoxExperience);
            this.tabPageDriver.Controls.Add((Control)this.textBoxAggresiveness);
            this.tabPageDriver.Controls.Add((Control)this.textBoxTalent);
            this.tabPageDriver.Controls.Add((Control)this.textBoxConcentration);
            this.tabPageDriver.Controls.Add((Control)this.textBoxOverall);
            this.tabPageDriver.Controls.Add((Control)this.textBoxFastestLaps);
            this.tabPageDriver.Controls.Add((Control)this.textBoxPoles);
            this.tabPageDriver.Controls.Add((Control)this.textBoxPoints);
            this.tabPageDriver.Controls.Add((Control)this.textBoxPodiums);
            this.tabPageDriver.Controls.Add((Control)this.textBoxWins);
            this.tabPageDriver.Controls.Add((Control)this.textBoxnumGPs);
            this.tabPageDriver.Controls.Add((Control)this.textBoxtrophies);
            this.tabPageDriver.Controls.Add((Control)this.label46);
            this.tabPageDriver.Controls.Add((Control)this.Races);
            this.tabPageDriver.Controls.Add((Control)this.label47);
            this.tabPageDriver.Controls.Add((Control)this.label48);
            this.tabPageDriver.Controls.Add((Control)this.label49);
            this.tabPageDriver.Controls.Add((Control)this.label50);
            this.tabPageDriver.Controls.Add((Control)this.label51);
            this.tabPageDriver.Controls.Add((Control)this.label52);
            this.tabPageDriver.Controls.Add((Control)this.label53);
            this.tabPageDriver.Controls.Add((Control)this.label54);
            this.tabPageDriver.Controls.Add((Control)this.label55);
            this.tabPageDriver.Controls.Add((Control)this.label56);
            this.tabPageDriver.Controls.Add((Control)this.label57);
            this.tabPageDriver.Controls.Add((Control)this.label58);
            this.tabPageDriver.Controls.Add((Control)this.label59);
            this.tabPageDriver.Controls.Add((Control)this.label60);
            this.tabPageDriver.Controls.Add((Control)this.label61);
            this.tabPageDriver.Controls.Add((Control)this.label62);
            this.tabPageDriver.Controls.Add((Control)this.label63);
            this.tabPageDriver.Controls.Add((Control)this.label64);
            this.tabPageDriver.Controls.Add((Control)this.label65);
            this.tabPageDriver.Controls.Add((Control)this.label66);
            this.tabPageDriver.Controls.Add((Control)this.label67);
            this.tabPageDriver.Controls.Add((Control)this.label68);
            this.tabPageDriver.Controls.Add((Control)this.groupBox7);
            this.tabPageDriver.Controls.Add((Control)this.groupBox8);
            this.tabPageDriver.Controls.Add((Control)this.groupBox9);
            this.tabPageDriver.Controls.Add((Control)this.groupBox10);
            this.tabPageDriver.Location = new Point(4, 22);
            this.tabPageDriver.Name = "tabPageDriver";
            this.tabPageDriver.Size = new Size(797, 343);
            this.tabPageDriver.TabIndex = 4;
            this.tabPageDriver.Text = "Driver";
            this.tabPageDriver.UseVisualStyleBackColor = true;
            this.contextMenuDriver.MenuItems.AddRange(new MenuItem[1]
            {
        this.menuItem5
            });
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Copy to clipboard";
            this.menuItem5.Click += new EventHandler(this.menuItem5_Click_1);
            this.textBoxEnergy.BorderStyle = BorderStyle.None;
            this.textBoxEnergy.Location = new Point(120, 226);
            this.textBoxEnergy.Name = "textBoxEnergy";
            this.textBoxEnergy.ReadOnly = true;
            this.textBoxEnergy.Size = new Size(24, 13);
            this.textBoxEnergy.TabIndex = 106;
            this.textBoxEnergy.TabStop = false;
            this.textBoxEnergy.TextAlign = HorizontalAlignment.Right;
            this.label133.Location = new Point(16, 226);
            this.label133.Name = "label133";
            this.label133.Size = new Size(80, 16);
            this.label133.TabIndex = 105;
            this.label133.Text = "Energy:";
            this.groupBox28.Controls.Add((Control)this.FavoriteTracksView);
            this.groupBox28.Location = new Point(368, 116);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new Size(200, 84);
            this.groupBox28.TabIndex = 104;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Favorite tracks";
            this.FavoriteTracksView.Location = new Point(11, 25);
            this.FavoriteTracksView.Name = "FavoriteTracksView";
            this.FavoriteTracksView.SelectionMode = SelectionMode.None;
            this.FavoriteTracksView.Size = new Size(170, 43);
            this.FavoriteTracksView.TabIndex = 1;
            this.textBoxCharisma.BorderStyle = BorderStyle.None;
            this.textBoxCharisma.Location = new Point(296, 152);
            this.textBoxCharisma.Name = "textBoxCharisma";
            this.textBoxCharisma.ReadOnly = true;
            this.textBoxCharisma.Size = new Size(24, 13);
            this.textBoxCharisma.TabIndex = 99;
            this.textBoxCharisma.TabStop = false;
            this.textBoxCharisma.TextAlign = HorizontalAlignment.Right;
            this.textBoxAverage.BorderStyle = BorderStyle.None;
            this.textBoxAverage.Location = new Point(104, 192);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new Size(32, 13);
            this.textBoxAverage.TabIndex = 97;
            this.textBoxAverage.TabStop = false;
            this.textBoxAverage.TextAlign = HorizontalAlignment.Right;
            this.textBoxnationality.BorderStyle = BorderStyle.None;
            this.textBoxnationality.Location = new Point(64, 33);
            this.textBoxnationality.Name = "textBoxnationality";
            this.textBoxnationality.ReadOnly = true;
            this.textBoxnationality.Size = new Size(120, 13);
            this.textBoxnationality.TabIndex = 95;
            this.textBoxnationality.TabStop = false;
            this.textBoxname.BorderStyle = BorderStyle.None;
            this.textBoxname.Location = new Point(64, 17);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.ReadOnly = true;
            this.textBoxname.Size = new Size(120, 13);
            this.textBoxname.TabIndex = 94;
            this.textBoxname.TabStop = false;
            this.textBoxname.Text = "Supporter feature";
            this.textBoxContract.BorderStyle = BorderStyle.None;
            this.textBoxContract.Location = new Point(456, 64);
            this.textBoxContract.Name = "textBoxContract";
            this.textBoxContract.ReadOnly = true;
            this.textBoxContract.Size = new Size(24, 13);
            this.textBoxContract.TabIndex = 92;
            this.textBoxContract.TabStop = false;
            this.textBoxContract.TextAlign = HorizontalAlignment.Right;
            this.textBoxSalary.BorderStyle = BorderStyle.None;
            this.textBoxSalary.Location = new Point(432, 48);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.ReadOnly = true;
            this.textBoxSalary.Size = new Size(72, 13);
            this.textBoxSalary.TabIndex = 91;
            this.textBoxSalary.TabStop = false;
            this.textBoxSalary.TextAlign = HorizontalAlignment.Right;
            this.textBoxAge.BorderStyle = BorderStyle.None;
            this.textBoxAge.Location = new Point(296, 242);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new Size(24, 13);
            this.textBoxAge.TabIndex = 90;
            this.textBoxAge.TabStop = false;
            this.textBoxAge.TextAlign = HorizontalAlignment.Right;
            this.textBoxWeight.BorderStyle = BorderStyle.None;
            this.textBoxWeight.Location = new Point(296, 226);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.ReadOnly = true;
            this.textBoxWeight.Size = new Size(24, 13);
            this.textBoxWeight.TabIndex = 89;
            this.textBoxWeight.TabStop = false;
            this.textBoxWeight.TextAlign = HorizontalAlignment.Right;
            this.textBoxMotivation.BorderStyle = BorderStyle.None;
            this.textBoxMotivation.Location = new Point(296, 168);
            this.textBoxMotivation.Name = "textBoxMotivation";
            this.textBoxMotivation.ReadOnly = true;
            this.textBoxMotivation.Size = new Size(24, 13);
            this.textBoxMotivation.TabIndex = 88;
            this.textBoxMotivation.TabStop = false;
            this.textBoxMotivation.TextAlign = HorizontalAlignment.Right;
            this.textBoxStamina.BorderStyle = BorderStyle.None;
            this.textBoxStamina.Location = new Point(296, 136);
            this.textBoxStamina.Name = "textBoxStamina";
            this.textBoxStamina.ReadOnly = true;
            this.textBoxStamina.Size = new Size(24, 13);
            this.textBoxStamina.TabIndex = 87;
            this.textBoxStamina.TabStop = false;
            this.textBoxStamina.TextAlign = HorizontalAlignment.Right;
            this.textBoxTechnicalInsight.BorderStyle = BorderStyle.None;
            this.textBoxTechnicalInsight.Location = new Point(296, 120);
            this.textBoxTechnicalInsight.Name = "textBoxTechnicalInsight";
            this.textBoxTechnicalInsight.ReadOnly = true;
            this.textBoxTechnicalInsight.Size = new Size(24, 13);
            this.textBoxTechnicalInsight.TabIndex = 86;
            this.textBoxTechnicalInsight.TabStop = false;
            this.textBoxTechnicalInsight.TextAlign = HorizontalAlignment.Right;
            this.textBoxExperience.BorderStyle = BorderStyle.None;
            this.textBoxExperience.Location = new Point(296, 104);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.ReadOnly = true;
            this.textBoxExperience.Size = new Size(24, 13);
            this.textBoxExperience.TabIndex = 85;
            this.textBoxExperience.TabStop = false;
            this.textBoxExperience.TextAlign = HorizontalAlignment.Right;
            this.textBoxAggresiveness.BorderStyle = BorderStyle.None;
            this.textBoxAggresiveness.Location = new Point(296, 88);
            this.textBoxAggresiveness.Name = "textBoxAggresiveness";
            this.textBoxAggresiveness.ReadOnly = true;
            this.textBoxAggresiveness.Size = new Size(24, 13);
            this.textBoxAggresiveness.TabIndex = 84;
            this.textBoxAggresiveness.TabStop = false;
            this.textBoxAggresiveness.TextAlign = HorizontalAlignment.Right;
            this.textBoxTalent.BorderStyle = BorderStyle.None;
            this.textBoxTalent.Location = new Point(296, 72);
            this.textBoxTalent.Name = "textBoxTalent";
            this.textBoxTalent.ReadOnly = true;
            this.textBoxTalent.Size = new Size(24, 13);
            this.textBoxTalent.TabIndex = 83;
            this.textBoxTalent.TabStop = false;
            this.textBoxTalent.TextAlign = HorizontalAlignment.Right;
            this.textBoxConcentration.BorderStyle = BorderStyle.None;
            this.textBoxConcentration.Location = new Point(296, 56);
            this.textBoxConcentration.Name = "textBoxConcentration";
            this.textBoxConcentration.ReadOnly = true;
            this.textBoxConcentration.Size = new Size(24, 13);
            this.textBoxConcentration.TabIndex = 82;
            this.textBoxConcentration.TabStop = false;
            this.textBoxConcentration.TextAlign = HorizontalAlignment.Right;
            this.textBoxOverall.BorderStyle = BorderStyle.None;
            this.textBoxOverall.Location = new Point(296, 40);
            this.textBoxOverall.Name = "textBoxOverall";
            this.textBoxOverall.ReadOnly = true;
            this.textBoxOverall.Size = new Size(24, 13);
            this.textBoxOverall.TabIndex = 81;
            this.textBoxOverall.TabStop = false;
            this.textBoxOverall.TextAlign = HorizontalAlignment.Right;
            this.textBoxFastestLaps.BorderStyle = BorderStyle.None;
            this.textBoxFastestLaps.Location = new Point(112, 176);
            this.textBoxFastestLaps.Name = "textBoxFastestLaps";
            this.textBoxFastestLaps.ReadOnly = true;
            this.textBoxFastestLaps.Size = new Size(24, 13);
            this.textBoxFastestLaps.TabIndex = 80;
            this.textBoxFastestLaps.TabStop = false;
            this.textBoxFastestLaps.TextAlign = HorizontalAlignment.Right;
            this.textBoxPoles.BorderStyle = BorderStyle.None;
            this.textBoxPoles.Location = new Point(112, 160);
            this.textBoxPoles.Name = "textBoxPoles";
            this.textBoxPoles.ReadOnly = true;
            this.textBoxPoles.Size = new Size(24, 13);
            this.textBoxPoles.TabIndex = 79;
            this.textBoxPoles.TabStop = false;
            this.textBoxPoles.TextAlign = HorizontalAlignment.Right;
            this.textBoxPoints.BorderStyle = BorderStyle.None;
            this.textBoxPoints.Location = new Point(112, 144);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.ReadOnly = true;
            this.textBoxPoints.Size = new Size(24, 13);
            this.textBoxPoints.TabIndex = 78;
            this.textBoxPoints.TabStop = false;
            this.textBoxPoints.TextAlign = HorizontalAlignment.Right;
            this.textBoxPodiums.BorderStyle = BorderStyle.None;
            this.textBoxPodiums.Location = new Point(112, 128);
            this.textBoxPodiums.Name = "textBoxPodiums";
            this.textBoxPodiums.ReadOnly = true;
            this.textBoxPodiums.Size = new Size(24, 13);
            this.textBoxPodiums.TabIndex = 77;
            this.textBoxPodiums.TabStop = false;
            this.textBoxPodiums.TextAlign = HorizontalAlignment.Right;
            this.textBoxWins.BorderStyle = BorderStyle.None;
            this.textBoxWins.Location = new Point(112, 112);
            this.textBoxWins.Name = "textBoxWins";
            this.textBoxWins.ReadOnly = true;
            this.textBoxWins.Size = new Size(24, 13);
            this.textBoxWins.TabIndex = 76;
            this.textBoxWins.TabStop = false;
            this.textBoxWins.TextAlign = HorizontalAlignment.Right;
            this.textBoxnumGPs.BorderStyle = BorderStyle.None;
            this.textBoxnumGPs.Location = new Point(112, 96);
            this.textBoxnumGPs.Name = "textBoxnumGPs";
            this.textBoxnumGPs.ReadOnly = true;
            this.textBoxnumGPs.Size = new Size(24, 13);
            this.textBoxnumGPs.TabIndex = 75;
            this.textBoxnumGPs.TabStop = false;
            this.textBoxnumGPs.TextAlign = HorizontalAlignment.Right;
            this.textBoxtrophies.BorderStyle = BorderStyle.None;
            this.textBoxtrophies.Location = new Point(112, 80);
            this.textBoxtrophies.Name = "textBoxtrophies";
            this.textBoxtrophies.ReadOnly = true;
            this.textBoxtrophies.Size = new Size(24, 13);
            this.textBoxtrophies.TabIndex = 74;
            this.textBoxtrophies.TabStop = false;
            this.textBoxtrophies.TextAlign = HorizontalAlignment.Right;
            this.label46.Location = new Point(192, 152);
            this.label46.Name = "label46";
            this.label46.Size = new Size(80, 16);
            this.label46.TabIndex = 98;
            this.label46.Text = "Charisma:";
            this.Races.Location = new Point(480, 64);
            this.Races.Name = "Races";
            this.Races.Size = new Size(32, 16);
            this.Races.TabIndex = 93;
            this.Races.Text = "races";
            this.label47.Location = new Point(376, 64);
            this.label47.Name = "label47";
            this.label47.Size = new Size(88, 16);
            this.label47.TabIndex = 73;
            this.label47.Text = "Contract length:";
            this.label48.Location = new Point(192, 242);
            this.label48.Name = "label48";
            this.label48.Size = new Size(40, 16);
            this.label48.TabIndex = 72;
            this.label48.Text = "Age:";
            this.label49.Location = new Point(192, 226);
            this.label49.Name = "label49";
            this.label49.Size = new Size(48, 16);
            this.label49.TabIndex = 71;
            this.label49.Text = "Weight:";
            this.label50.Location = new Point(376, 48);
            this.label50.Name = "label50";
            this.label50.Size = new Size(80, 16);
            this.label50.TabIndex = 70;
            this.label50.Text = "Salary:";
            this.label51.Location = new Point(192, 168);
            this.label51.Name = "label51";
            this.label51.Size = new Size(80, 16);
            this.label51.TabIndex = 69;
            this.label51.Text = "Motivation:";
            this.label52.Location = new Point(192, 136);
            this.label52.Name = "label52";
            this.label52.Size = new Size(80, 16);
            this.label52.TabIndex = 68;
            this.label52.Text = "Stamina:";
            this.label53.Location = new Point(192, 120);
            this.label53.Name = "label53";
            this.label53.Size = new Size(96, 16);
            this.label53.TabIndex = 67;
            this.label53.Text = "Technical Insight:";
            this.label54.Location = new Point(192, 104);
            this.label54.Name = "label54";
            this.label54.Size = new Size(80, 16);
            this.label54.TabIndex = 66;
            this.label54.Text = "Experience:";
            this.label55.Location = new Point(192, 88);
            this.label55.Name = "label55";
            this.label55.Size = new Size(80, 16);
            this.label55.TabIndex = 65;
            this.label55.Text = "Aggresiveness:";
            this.label56.Location = new Point(192, 72);
            this.label56.Name = "label56";
            this.label56.Size = new Size(80, 16);
            this.label56.TabIndex = 64;
            this.label56.Text = "Talent:";
            this.label57.Location = new Point(192, 56);
            this.label57.Name = "label57";
            this.label57.Size = new Size(80, 16);
            this.label57.TabIndex = 63;
            this.label57.Text = "Concentration:";
            this.label58.Location = new Point(192, 40);
            this.label58.Name = "label58";
            this.label58.Size = new Size(64, 16);
            this.label58.TabIndex = 62;
            this.label58.Text = "Overall:";
            this.label59.Location = new Point(16, 192);
            this.label59.Name = "label59";
            this.label59.Size = new Size(64, 16);
            this.label59.TabIndex = 61;
            this.label59.Text = "Av pts/race:";
            this.label60.Location = new Point(16, 176);
            this.label60.Name = "label60";
            this.label60.Size = new Size(72, 16);
            this.label60.TabIndex = 60;
            this.label60.Text = "Fastest Laps:";
            this.label61.Location = new Point(16, 160);
            this.label61.Name = "label61";
            this.label61.Size = new Size(80, 16);
            this.label61.TabIndex = 59;
            this.label61.Text = "Pole Positions:";
            this.label62.Location = new Point(16, 144);
            this.label62.Name = "label62";
            this.label62.Size = new Size(80, 16);
            this.label62.TabIndex = 58;
            this.label62.Text = "Points Scored:";
            this.label63.Location = new Point(16, 128);
            this.label63.Name = "label63";
            this.label63.Size = new Size(64, 16);
            this.label63.TabIndex = 57;
            this.label63.Text = "Podiums:";
            this.label64.Location = new Point(16, 112);
            this.label64.Name = "label64";
            this.label64.Size = new Size(64, 16);
            this.label64.TabIndex = 56;
            this.label64.Text = "Wins:";
            this.label65.Location = new Point(16, 96);
            this.label65.Name = "label65";
            this.label65.Size = new Size(88, 16);
            this.label65.TabIndex = 55;
            this.label65.Text = "Number of GPs:";
            this.label66.Location = new Point(16, 80);
            this.label66.Name = "label66";
            this.label66.Size = new Size(64, 16);
            this.label66.TabIndex = 54;
            this.label66.Text = "Trophies:";
            this.label67.Location = new Point(8, 33);
            this.label67.Name = "label67";
            this.label67.Size = new Size(64, 16);
            this.label67.TabIndex = 53;
            this.label67.Text = "Nationality:";
            this.label68.Location = new Point(8, 17);
            this.label68.Name = "label68";
            this.label68.Size = new Size(48, 16);
            this.label68.TabIndex = 52;
            this.label68.Text = "Name:";
            this.groupBox7.Location = new Point(8, 56);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new Size(144, 160);
            this.groupBox7.TabIndex = 100;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Career";
            this.groupBox8.Controls.Add((Control)this.textBoxReputation);
            this.groupBox8.Controls.Add((Control)this.label131);
            this.groupBox8.Location = new Point(184, 16);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new Size(152, 188);
            this.groupBox8.TabIndex = 101;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Skills";
            this.textBoxReputation.BorderStyle = BorderStyle.None;
            this.textBoxReputation.Location = new Point(112, 168);
            this.textBoxReputation.Name = "textBoxReputation";
            this.textBoxReputation.ReadOnly = true;
            this.textBoxReputation.Size = new Size(24, 13);
            this.textBoxReputation.TabIndex = 121;
            this.textBoxReputation.TabStop = false;
            this.textBoxReputation.TextAlign = HorizontalAlignment.Right;
            this.label131.Location = new Point(8, 168);
            this.label131.Name = "label131";
            this.label131.Size = new Size(80, 16);
            this.label131.TabIndex = 121;
            this.label131.Text = "Reputation:";
            this.groupBox9.Location = new Point(368, 24);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new Size(152, 64);
            this.groupBox9.TabIndex = 102;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Contract Details";
            this.groupBox10.Location = new Point(184, 210);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new Size(152, 56);
            this.groupBox10.TabIndex = 103;
            this.groupBox10.TabStop = false;
            this.tabPageTechnicalDirector.Controls.Add((Control)this.groupBox27);
            this.tabPageTechnicalDirector.Controls.Add((Control)this.textBoxTDContract);
            this.tabPageTechnicalDirector.Controls.Add((Control)this.textBoxTDSalary);
            this.tabPageTechnicalDirector.Controls.Add((Control)this.label127);
            this.tabPageTechnicalDirector.Controls.Add((Control)this.label128);
            this.tabPageTechnicalDirector.Controls.Add((Control)this.label129);
            this.tabPageTechnicalDirector.Controls.Add((Control)this.groupBox26);
            this.tabPageTechnicalDirector.Controls.Add((Control)this.groupBox25);
            this.tabPageTechnicalDirector.Controls.Add((Control)this.groupBox24);
            this.tabPageTechnicalDirector.Controls.Add((Control)this.textBoxTDNationality);
            this.tabPageTechnicalDirector.Controls.Add((Control)this.textBoxTDName);
            this.tabPageTechnicalDirector.Controls.Add((Control)this.label114);
            this.tabPageTechnicalDirector.Controls.Add((Control)this.label115);
            this.tabPageTechnicalDirector.Location = new Point(4, 22);
            this.tabPageTechnicalDirector.Name = "tabPageTechnicalDirector";
            this.tabPageTechnicalDirector.Padding = new Padding(3);
            this.tabPageTechnicalDirector.Size = new Size(797, 343);
            this.tabPageTechnicalDirector.TabIndex = 9;
            this.tabPageTechnicalDirector.Text = "Tech. D.";
            this.tabPageTechnicalDirector.UseVisualStyleBackColor = true;
            this.groupBox27.Controls.Add((Control)this.textBoxTDAge);
            this.groupBox27.Controls.Add((Control)this.label130);
            this.groupBox27.Location = new Point(211, 194);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new Size(152, 42);
            this.groupBox27.TabIndex = 111;
            this.groupBox27.TabStop = false;
            this.textBoxTDAge.BorderStyle = BorderStyle.None;
            this.textBoxTDAge.Location = new Point(116, 14);
            this.textBoxTDAge.Name = "textBoxTDAge";
            this.textBoxTDAge.ReadOnly = true;
            this.textBoxTDAge.Size = new Size(24, 13);
            this.textBoxTDAge.TabIndex = 110;
            this.textBoxTDAge.TabStop = false;
            this.textBoxTDAge.TextAlign = HorizontalAlignment.Right;
            this.label130.Location = new Point(12, 14);
            this.label130.Name = "label130";
            this.label130.Size = new Size(40, 16);
            this.label130.TabIndex = 109;
            this.label130.Text = "Age:";
            this.textBoxTDContract.BorderStyle = BorderStyle.None;
            this.textBoxTDContract.Location = new Point(485, 52);
            this.textBoxTDContract.Name = "textBoxTDContract";
            this.textBoxTDContract.ReadOnly = true;
            this.textBoxTDContract.Size = new Size(24, 13);
            this.textBoxTDContract.TabIndex = 106;
            this.textBoxTDContract.TabStop = false;
            this.textBoxTDContract.TextAlign = HorizontalAlignment.Right;
            this.textBoxTDSalary.BorderStyle = BorderStyle.None;
            this.textBoxTDSalary.Location = new Point(461, 36);
            this.textBoxTDSalary.Name = "textBoxTDSalary";
            this.textBoxTDSalary.ReadOnly = true;
            this.textBoxTDSalary.Size = new Size(72, 13);
            this.textBoxTDSalary.TabIndex = 105;
            this.textBoxTDSalary.TabStop = false;
            this.textBoxTDSalary.TextAlign = HorizontalAlignment.Right;
            this.label127.Location = new Point(509, 52);
            this.label127.Name = "label127";
            this.label127.Size = new Size(32, 16);
            this.label127.TabIndex = 107;
            this.label127.Text = "races";
            this.label128.Location = new Point(405, 52);
            this.label128.Name = "label128";
            this.label128.Size = new Size(88, 16);
            this.label128.TabIndex = 104;
            this.label128.Text = "Contract length:";
            this.label129.Location = new Point(405, 36);
            this.label129.Name = "label129";
            this.label129.Size = new Size(80, 16);
            this.label129.TabIndex = 103;
            this.label129.Text = "Salary:";
            this.groupBox26.Location = new Point(397, 12);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new Size(152, 64);
            this.groupBox26.TabIndex = 108;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Contract Details";
            this.groupBox25.Controls.Add((Control)this.textBoxTDMotivation);
            this.groupBox25.Controls.Add((Control)this.textBoxTDPitCoordination);
            this.groupBox25.Controls.Add((Control)this.textBoxTDExperience);
            this.groupBox25.Controls.Add((Control)this.textBoxTDAerodynamics);
            this.groupBox25.Controls.Add((Control)this.textBoxTDElectronics);
            this.groupBox25.Controls.Add((Control)this.textBoxTDMechanics);
            this.groupBox25.Controls.Add((Control)this.textBoxTDLeadership);
            this.groupBox25.Controls.Add((Control)this.textBoxTDOverall);
            this.groupBox25.Controls.Add((Control)this.label119);
            this.groupBox25.Controls.Add((Control)this.label120);
            this.groupBox25.Controls.Add((Control)this.label121);
            this.groupBox25.Controls.Add((Control)this.label122);
            this.groupBox25.Controls.Add((Control)this.label123);
            this.groupBox25.Controls.Add((Control)this.label124);
            this.groupBox25.Controls.Add((Control)this.label125);
            this.groupBox25.Controls.Add((Control)this.label126);
            this.groupBox25.Location = new Point(211, 12);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new Size(152, 176);
            this.groupBox25.TabIndex = 102;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Skills";
            this.textBoxTDMotivation.BorderStyle = BorderStyle.None;
            this.textBoxTDMotivation.Location = new Point(116, 136);
            this.textBoxTDMotivation.Name = "textBoxTDMotivation";
            this.textBoxTDMotivation.ReadOnly = true;
            this.textBoxTDMotivation.Size = new Size(24, 13);
            this.textBoxTDMotivation.TabIndex = 115;
            this.textBoxTDMotivation.TabStop = false;
            this.textBoxTDMotivation.TextAlign = HorizontalAlignment.Right;
            this.textBoxTDPitCoordination.BorderStyle = BorderStyle.None;
            this.textBoxTDPitCoordination.Location = new Point(116, 120);
            this.textBoxTDPitCoordination.Name = "textBoxTDPitCoordination";
            this.textBoxTDPitCoordination.ReadOnly = true;
            this.textBoxTDPitCoordination.Size = new Size(24, 13);
            this.textBoxTDPitCoordination.TabIndex = 113;
            this.textBoxTDPitCoordination.TabStop = false;
            this.textBoxTDPitCoordination.TextAlign = HorizontalAlignment.Right;
            this.textBoxTDExperience.BorderStyle = BorderStyle.None;
            this.textBoxTDExperience.Location = new Point(116, 104);
            this.textBoxTDExperience.Name = "textBoxTDExperience";
            this.textBoxTDExperience.ReadOnly = true;
            this.textBoxTDExperience.Size = new Size(24, 13);
            this.textBoxTDExperience.TabIndex = 112;
            this.textBoxTDExperience.TabStop = false;
            this.textBoxTDExperience.TextAlign = HorizontalAlignment.Right;
            this.textBoxTDAerodynamics.BorderStyle = BorderStyle.None;
            this.textBoxTDAerodynamics.Location = new Point(116, 88);
            this.textBoxTDAerodynamics.Name = "textBoxTDAerodynamics";
            this.textBoxTDAerodynamics.ReadOnly = true;
            this.textBoxTDAerodynamics.Size = new Size(24, 13);
            this.textBoxTDAerodynamics.TabIndex = 111;
            this.textBoxTDAerodynamics.TabStop = false;
            this.textBoxTDAerodynamics.TextAlign = HorizontalAlignment.Right;
            this.textBoxTDElectronics.BorderStyle = BorderStyle.None;
            this.textBoxTDElectronics.Location = new Point(116, 72);
            this.textBoxTDElectronics.Name = "textBoxTDElectronics";
            this.textBoxTDElectronics.ReadOnly = true;
            this.textBoxTDElectronics.Size = new Size(24, 13);
            this.textBoxTDElectronics.TabIndex = 110;
            this.textBoxTDElectronics.TabStop = false;
            this.textBoxTDElectronics.TextAlign = HorizontalAlignment.Right;
            this.textBoxTDMechanics.BorderStyle = BorderStyle.None;
            this.textBoxTDMechanics.Location = new Point(116, 56);
            this.textBoxTDMechanics.Name = "textBoxTDMechanics";
            this.textBoxTDMechanics.ReadOnly = true;
            this.textBoxTDMechanics.Size = new Size(24, 13);
            this.textBoxTDMechanics.TabIndex = 109;
            this.textBoxTDMechanics.TabStop = false;
            this.textBoxTDMechanics.TextAlign = HorizontalAlignment.Right;
            this.textBoxTDLeadership.BorderStyle = BorderStyle.None;
            this.textBoxTDLeadership.Location = new Point(116, 40);
            this.textBoxTDLeadership.Name = "textBoxTDLeadership";
            this.textBoxTDLeadership.ReadOnly = true;
            this.textBoxTDLeadership.Size = new Size(24, 13);
            this.textBoxTDLeadership.TabIndex = 108;
            this.textBoxTDLeadership.TabStop = false;
            this.textBoxTDLeadership.TextAlign = HorizontalAlignment.Right;
            this.textBoxTDOverall.BorderStyle = BorderStyle.None;
            this.textBoxTDOverall.Location = new Point(116, 24);
            this.textBoxTDOverall.Name = "textBoxTDOverall";
            this.textBoxTDOverall.ReadOnly = true;
            this.textBoxTDOverall.Size = new Size(24, 13);
            this.textBoxTDOverall.TabIndex = 107;
            this.textBoxTDOverall.TabStop = false;
            this.textBoxTDOverall.TextAlign = HorizontalAlignment.Right;
            this.label119.Location = new Point(12, 136);
            this.label119.Name = "label119";
            this.label119.Size = new Size(80, 16);
            this.label119.TabIndex = 114;
            this.label119.Text = "Motivation:";
            this.label120.Location = new Point(12, 120);
            this.label120.Name = "label120";
            this.label120.Size = new Size(96, 16);
            this.label120.TabIndex = 106;
            this.label120.Text = "Pit coordination:";
            this.label121.Location = new Point(12, 104);
            this.label121.Name = "label121";
            this.label121.Size = new Size(96, 16);
            this.label121.TabIndex = 105;
            this.label121.Text = "Experience:";
            this.label122.Location = new Point(12, 88);
            this.label122.Name = "label122";
            this.label122.Size = new Size(105, 16);
            this.label122.TabIndex = 104;
            this.label122.Text = "R&D aerodynamics:";
            this.label122.UseMnemonic = false;
            this.label123.Location = new Point(12, 72);
            this.label123.Name = "label123";
            this.label123.Size = new Size(96, 16);
            this.label123.TabIndex = 103;
            this.label123.Text = "R&D electronics:";
            this.label123.UseMnemonic = false;
            this.label124.Location = new Point(12, 56);
            this.label124.Name = "label124";
            this.label124.Size = new Size(96, 16);
            this.label124.TabIndex = 102;
            this.label124.Text = "R&D mechanics";
            this.label124.UseMnemonic = false;
            this.label125.Location = new Point(12, 40);
            this.label125.Name = "label125";
            this.label125.Size = new Size(80, 16);
            this.label125.TabIndex = 101;
            this.label125.Text = "Leadership:";
            this.label126.Location = new Point(12, 24);
            this.label126.Name = "label126";
            this.label126.Size = new Size(64, 16);
            this.label126.TabIndex = 100;
            this.label126.Text = "Overall:";
            this.groupBox24.Controls.Add((Control)this.textBoxTDWins);
            this.groupBox24.Controls.Add((Control)this.textBoxTDNumGps);
            this.groupBox24.Controls.Add((Control)this.textBoxTDTrophies);
            this.groupBox24.Controls.Add((Control)this.label116);
            this.groupBox24.Controls.Add((Control)this.label117);
            this.groupBox24.Controls.Add((Control)this.label118);
            this.groupBox24.Location = new Point(19, 64);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new Size(144, 160);
            this.groupBox24.TabIndex = 101;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Career";
            this.textBoxTDWins.BorderStyle = BorderStyle.None;
            this.textBoxTDWins.Location = new Point(107, 51);
            this.textBoxTDWins.Name = "textBoxTDWins";
            this.textBoxTDWins.ReadOnly = true;
            this.textBoxTDWins.Size = new Size(24, 13);
            this.textBoxTDWins.TabIndex = 82;
            this.textBoxTDWins.TabStop = false;
            this.textBoxTDWins.TextAlign = HorizontalAlignment.Right;
            this.textBoxTDNumGps.BorderStyle = BorderStyle.None;
            this.textBoxTDNumGps.Location = new Point(107, 35);
            this.textBoxTDNumGps.Name = "textBoxTDNumGps";
            this.textBoxTDNumGps.ReadOnly = true;
            this.textBoxTDNumGps.Size = new Size(24, 13);
            this.textBoxTDNumGps.TabIndex = 81;
            this.textBoxTDNumGps.TabStop = false;
            this.textBoxTDNumGps.TextAlign = HorizontalAlignment.Right;
            this.textBoxTDTrophies.BorderStyle = BorderStyle.None;
            this.textBoxTDTrophies.Location = new Point(107, 19);
            this.textBoxTDTrophies.Name = "textBoxTDTrophies";
            this.textBoxTDTrophies.ReadOnly = true;
            this.textBoxTDTrophies.Size = new Size(24, 13);
            this.textBoxTDTrophies.TabIndex = 80;
            this.textBoxTDTrophies.TabStop = false;
            this.textBoxTDTrophies.TextAlign = HorizontalAlignment.Right;
            this.label116.Location = new Point(11, 51);
            this.label116.Name = "label116";
            this.label116.Size = new Size(64, 16);
            this.label116.TabIndex = 79;
            this.label116.Text = "Wins:";
            this.label117.Location = new Point(11, 35);
            this.label117.Name = "label117";
            this.label117.Size = new Size(88, 16);
            this.label117.TabIndex = 78;
            this.label117.Text = "Number of GPs:";
            this.label118.Location = new Point(11, 19);
            this.label118.Name = "label118";
            this.label118.Size = new Size(64, 16);
            this.label118.TabIndex = 77;
            this.label118.Text = "Trophies:";
            this.textBoxTDNationality.BorderStyle = BorderStyle.None;
            this.textBoxTDNationality.Location = new Point(72, 28);
            this.textBoxTDNationality.Name = "textBoxTDNationality";
            this.textBoxTDNationality.ReadOnly = true;
            this.textBoxTDNationality.Size = new Size(120, 13);
            this.textBoxTDNationality.TabIndex = 99;
            this.textBoxTDNationality.TabStop = false;
            this.textBoxTDName.BorderStyle = BorderStyle.None;
            this.textBoxTDName.Location = new Point(72, 12);
            this.textBoxTDName.Name = "textBoxTDName";
            this.textBoxTDName.ReadOnly = true;
            this.textBoxTDName.Size = new Size(120, 13);
            this.textBoxTDName.TabIndex = 98;
            this.textBoxTDName.TabStop = false;
            this.textBoxTDName.Text = "Supporter feature";
            this.label114.Location = new Point(16, 28);
            this.label114.Name = "label114";
            this.label114.Size = new Size(64, 16);
            this.label114.TabIndex = 97;
            this.label114.Text = "Nationality:";
            this.label115.Location = new Point(16, 12);
            this.label115.Name = "label115";
            this.label115.Size = new Size(48, 16);
            this.label115.TabIndex = 96;
            this.label115.Text = "Name:";
            this.tabPageCar.Controls.Add((Control)this.buttonStrategyError);
            this.tabPageCar.Controls.Add((Control)this.buttonSponsorError);
            this.tabPageCar.Controls.Add((Control)this.buttonMainPageError);
            this.tabPageCar.Controls.Add((Control)this.buttonQualifyError);
            this.tabPageCar.Controls.Add((Control)this.buttonTyreSupplierError);
            this.tabPageCar.Controls.Add((Control)this.buttonSummaryError);
            this.tabPageCar.Controls.Add((Control)this.buttonTDError);
            this.tabPageCar.Controls.Add((Control)this.buttonGetSummary);
            this.tabPageCar.Controls.Add((Control)this.buttonFinance);
            this.tabPageCar.Controls.Add((Control)this.buttonTestErr);
            this.tabPageCar.Controls.Add((Control)this.buttonDriver);
            this.tabPageCar.Controls.Add((Control)this.buttonCarError);
            this.tabPageCar.Controls.Add((Control)this.buttonRaceError);
            this.tabPageCar.Controls.Add((Control)this.buttonPracErr);
            this.tabPageCar.Controls.Add((Control)this.groupBox1);
            this.tabPageCar.Controls.Add((Control)this.buttonGetTracks);
            this.tabPageCar.Controls.Add((Control)this.LoadButton);
            this.tabPageCar.Location = new Point(4, 22);
            this.tabPageCar.Name = "tabPageCar";
            this.tabPageCar.Size = new Size(797, 343);
            this.tabPageCar.TabIndex = 0;
            this.tabPageCar.Text = "Car";
            this.tabPageCar.UseVisualStyleBackColor = true;
            this.buttonStrategyError.Location = new Point(504, 292);
            this.buttonStrategyError.Name = "buttonStrategyError";
            this.buttonStrategyError.Size = new Size(80, 23);
            this.buttonStrategyError.TabIndex = 27;
            this.buttonStrategyError.Text = "Strategy error";
            this.buttonStrategyError.Visible = false;
            this.buttonSponsorError.Location = new Point(384, 292);
            this.buttonSponsorError.Name = "buttonSponsorError";
            this.buttonSponsorError.Size = new Size(80, 23);
            this.buttonSponsorError.TabIndex = 26;
            this.buttonSponsorError.Text = "Sponsor error";
            this.buttonSponsorError.Visible = false;
            this.buttonMainPageError.Location = new Point(504, 219);
            this.buttonMainPageError.Name = "buttonMainPageError";
            this.buttonMainPageError.Size = new Size(80, 23);
            this.buttonMainPageError.TabIndex = 25;
            this.buttonMainPageError.Text = "Main page Error";
            this.buttonMainPageError.Visible = false;
            this.buttonQualifyError.Location = new Point(504, 263);
            this.buttonQualifyError.Name = "buttonQualifyError";
            this.buttonQualifyError.Size = new Size(80, 23);
            this.buttonQualifyError.TabIndex = 24;
            this.buttonQualifyError.Text = "Qualify error";
            this.buttonQualifyError.Visible = false;
            this.buttonTyreSupplierError.Location = new Point(384, 263);
            this.buttonTyreSupplierError.Name = "buttonTyreSupplierError";
            this.buttonTyreSupplierError.Size = new Size(80, 23);
            this.buttonTyreSupplierError.TabIndex = 23;
            this.buttonTyreSupplierError.Text = "TyreSupplier error";
            this.buttonTyreSupplierError.Visible = false;
            this.buttonSummaryError.Location = new Point(384, 234);
            this.buttonSummaryError.Name = "buttonSummaryError";
            this.buttonSummaryError.Size = new Size(80, 23);
            this.buttonSummaryError.TabIndex = 22;
            this.buttonSummaryError.Text = "Summary error";
            this.buttonSummaryError.Visible = false;
            this.buttonTDError.Location = new Point(384, 205);
            this.buttonTDError.Name = "buttonTDError";
            this.buttonTDError.Size = new Size(80, 23);
            this.buttonTDError.TabIndex = 21;
            this.buttonTDError.Text = "TD error";
            this.buttonTDError.Visible = false;
            this.buttonGetSummary.Location = new Point(504, 143);
            this.buttonGetSummary.Name = "buttonGetSummary";
            this.buttonGetSummary.Size = new Size(75, 23);
            this.buttonGetSummary.TabIndex = 20;
            this.buttonGetSummary.Text = "GetSummary";
            this.buttonGetSummary.UseVisualStyleBackColor = true;
            this.buttonGetSummary.Visible = false;
            this.buttonGetSummary.Click += new EventHandler(this.buttonGetSummary_Click);
            this.buttonFinance.Location = new Point(384, 144);
            this.buttonFinance.Name = "buttonFinance";
            this.buttonFinance.Size = new Size(80, 23);
            this.buttonFinance.TabIndex = 19;
            this.buttonFinance.Text = "Finances";
            this.buttonFinance.Visible = false;
            this.buttonTestErr.Location = new Point(384, 80);
            this.buttonTestErr.Name = "buttonTestErr";
            this.buttonTestErr.Size = new Size(80, 23);
            this.buttonTestErr.TabIndex = 18;
            this.buttonTestErr.Text = "Test error";
            this.buttonTestErr.Visible = false;
            this.buttonDriver.Location = new Point(384, 16);
            this.buttonDriver.Name = "buttonDriver";
            this.buttonDriver.Size = new Size(80, 23);
            this.buttonDriver.TabIndex = 15;
            this.buttonDriver.Text = "Driver Error";
            this.buttonDriver.Visible = false;
            this.buttonCarError.Location = new Point(384, 48);
            this.buttonCarError.Name = "buttonCarError";
            this.buttonCarError.Size = new Size(80, 23);
            this.buttonCarError.TabIndex = 14;
            this.buttonCarError.Text = "Car Error";
            this.buttonCarError.Visible = false;
            this.buttonRaceError.Location = new Point(384, 176);
            this.buttonRaceError.Name = "buttonRaceError";
            this.buttonRaceError.Size = new Size(80, 23);
            this.buttonRaceError.TabIndex = 13;
            this.buttonRaceError.Text = "Race error";
            this.buttonRaceError.Visible = false;
            this.buttonPracErr.Location = new Point(384, 112);
            this.buttonPracErr.Name = "buttonPracErr";
            this.buttonPracErr.Size = new Size(80, 23);
            this.buttonPracErr.TabIndex = 12;
            this.buttonPracErr.Text = "Practice error";
            this.buttonPracErr.Visible = false;
            this.groupBox1.Controls.Add((Control)this.textBoxCoWear);
            this.groupBox1.Controls.Add((Control)this.textBoxElWear);
            this.groupBox1.Controls.Add((Control)this.textBoxSiWear);
            this.groupBox1.Controls.Add((Control)this.textBoxUnWear);
            this.groupBox1.Controls.Add((Control)this.textBoxChWear);
            this.groupBox1.Controls.Add((Control)this.textBoxFwWear);
            this.groupBox1.Controls.Add((Control)this.textBoxBrWear);
            this.groupBox1.Controls.Add((Control)this.textBoxEnWear);
            this.groupBox1.Controls.Add((Control)this.textBoxSuWear);
            this.groupBox1.Controls.Add((Control)this.textBoxGeWear);
            this.groupBox1.Controls.Add((Control)this.textBoxRwWear);
            this.groupBox1.Controls.Add((Control)this.label13);
            this.groupBox1.Controls.Add((Control)this.label3);
            this.groupBox1.Controls.Add((Control)this.textBoxen1);
            this.groupBox1.Controls.Add((Control)this.textBoxTestAcceleration);
            this.groupBox1.Controls.Add((Control)this.textBoxen2);
            this.groupBox1.Controls.Add((Control)this.textBoxTestHandling);
            this.groupBox1.Controls.Add((Control)this.label5);
            this.groupBox1.Controls.Add((Control)this.textBoxch1);
            this.groupBox1.Controls.Add((Control)this.textBoxTestPower);
            this.groupBox1.Controls.Add((Control)this.textBoxch2);
            this.groupBox1.Controls.Add((Control)this.label95);
            this.groupBox1.Controls.Add((Control)this.textBoxHandling);
            this.groupBox1.Controls.Add((Control)this.textBoxAcceleration);
            this.groupBox1.Controls.Add((Control)this.textBoxPower);
            this.groupBox1.Controls.Add((Control)this.label19);
            this.groupBox1.Controls.Add((Control)this.label18);
            this.groupBox1.Controls.Add((Control)this.label17);
            this.groupBox1.Controls.Add((Control)this.textBoxbr2);
            this.groupBox1.Controls.Add((Control)this.textBoxbr1);
            this.groupBox1.Controls.Add((Control)this.textBoxco2);
            this.groupBox1.Controls.Add((Control)this.textBoxco1);
            this.groupBox1.Controls.Add((Control)this.textBoxsi2);
            this.groupBox1.Controls.Add((Control)this.textBoxsi1);
            this.groupBox1.Controls.Add((Control)this.textBoxel2);
            this.groupBox1.Controls.Add((Control)this.textBoxel1);
            this.groupBox1.Controls.Add((Control)this.textBoxun2);
            this.groupBox1.Controls.Add((Control)this.textBoxun1);
            this.groupBox1.Controls.Add((Control)this.textBoxsu2);
            this.groupBox1.Controls.Add((Control)this.textBoxsu1);
            this.groupBox1.Controls.Add((Control)this.textBoxgb2);
            this.groupBox1.Controls.Add((Control)this.textBoxgb1);
            this.groupBox1.Controls.Add((Control)this.textBoxrw2);
            this.groupBox1.Controls.Add((Control)this.textBoxrw1);
            this.groupBox1.Controls.Add((Control)this.label12);
            this.groupBox1.Controls.Add((Control)this.textBoxfw2);
            this.groupBox1.Controls.Add((Control)this.textBoxfw1);
            this.groupBox1.Controls.Add((Control)this.label11);
            this.groupBox1.Controls.Add((Control)this.label10);
            this.groupBox1.Controls.Add((Control)this.label9);
            this.groupBox1.Controls.Add((Control)this.label8);
            this.groupBox1.Controls.Add((Control)this.label7);
            this.groupBox1.Controls.Add((Control)this.label6);
            this.groupBox1.Controls.Add((Control)this.label4);
            this.groupBox1.Controls.Add((Control)this.label2);
            this.groupBox1.Controls.Add((Control)this.label1);
            this.groupBox1.Controls.Add((Control)this.label96);
            this.groupBox1.Controls.Add((Control)this.label97);
            this.groupBox1.Location = new Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(368, 240);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car";
            this.textBoxCoWear.BorderStyle = BorderStyle.None;
            this.textBoxCoWear.Location = new Point(304, 93);
            this.textBoxCoWear.Name = "textBoxCoWear";
            this.textBoxCoWear.ReadOnly = true;
            this.textBoxCoWear.Size = new Size(32, 13);
            this.textBoxCoWear.TabIndex = 86;
            this.textBoxCoWear.TextAlign = HorizontalAlignment.Right;
            this.textBoxElWear.BorderStyle = BorderStyle.None;
            this.textBoxElWear.Location = new Point(304, 192);
            this.textBoxElWear.Name = "textBoxElWear";
            this.textBoxElWear.ReadOnly = true;
            this.textBoxElWear.Size = new Size(32, 13);
            this.textBoxElWear.TabIndex = 85;
            this.textBoxElWear.TextAlign = HorizontalAlignment.Right;
            this.textBoxSiWear.BorderStyle = BorderStyle.None;
            this.textBoxSiWear.Location = new Point(128, 221);
            this.textBoxSiWear.Name = "textBoxSiWear";
            this.textBoxSiWear.ReadOnly = true;
            this.textBoxSiWear.Size = new Size(32, 13);
            this.textBoxSiWear.TabIndex = 84;
            this.textBoxSiWear.TextAlign = HorizontalAlignment.Right;
            this.textBoxUnWear.BorderStyle = BorderStyle.None;
            this.textBoxUnWear.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.textBoxUnWear.Location = new Point(128, 192);
            this.textBoxUnWear.Name = "textBoxUnWear";
            this.textBoxUnWear.ReadOnly = true;
            this.textBoxUnWear.Size = new Size(32, 13);
            this.textBoxUnWear.TabIndex = 83;
            this.textBoxUnWear.TextAlign = HorizontalAlignment.Right;
            this.textBoxChWear.BorderStyle = BorderStyle.None;
            this.textBoxChWear.Location = new Point(128, 93);
            this.textBoxChWear.Name = "textBoxChWear";
            this.textBoxChWear.ReadOnly = true;
            this.textBoxChWear.Size = new Size(32, 13);
            this.textBoxChWear.TabIndex = 82;
            this.textBoxChWear.TextAlign = HorizontalAlignment.Right;
            this.textBoxFwWear.BorderStyle = BorderStyle.None;
            this.textBoxFwWear.Location = new Point(128, 143);
            this.textBoxFwWear.Name = "textBoxFwWear";
            this.textBoxFwWear.ReadOnly = true;
            this.textBoxFwWear.Size = new Size(32, 13);
            this.textBoxFwWear.TabIndex = 81;
            this.textBoxFwWear.TextAlign = HorizontalAlignment.Right;
            this.textBoxBrWear.BorderStyle = BorderStyle.None;
            this.textBoxBrWear.Location = new Point(304, 144);
            this.textBoxBrWear.Name = "textBoxBrWear";
            this.textBoxBrWear.ReadOnly = true;
            this.textBoxBrWear.Size = new Size(32, 13);
            this.textBoxBrWear.TabIndex = 80;
            this.textBoxBrWear.TextAlign = HorizontalAlignment.Right;
            this.textBoxEnWear.BorderStyle = BorderStyle.None;
            this.textBoxEnWear.Location = new Point(128, 117);
            this.textBoxEnWear.Name = "textBoxEnWear";
            this.textBoxEnWear.ReadOnly = true;
            this.textBoxEnWear.Size = new Size(32, 13);
            this.textBoxEnWear.TabIndex = 77;
            this.textBoxEnWear.TextAlign = HorizontalAlignment.Right;
            this.textBoxSuWear.BorderStyle = BorderStyle.None;
            this.textBoxSuWear.Location = new Point(304, 165);
            this.textBoxSuWear.Name = "textBoxSuWear";
            this.textBoxSuWear.ReadOnly = true;
            this.textBoxSuWear.Size = new Size(32, 13);
            this.textBoxSuWear.TabIndex = 79;
            this.textBoxSuWear.TextAlign = HorizontalAlignment.Right;
            this.textBoxGeWear.BorderStyle = BorderStyle.None;
            this.textBoxGeWear.Location = new Point(304, 117);
            this.textBoxGeWear.Name = "textBoxGeWear";
            this.textBoxGeWear.ReadOnly = true;
            this.textBoxGeWear.Size = new Size(32, 13);
            this.textBoxGeWear.TabIndex = 78;
            this.textBoxGeWear.TextAlign = HorizontalAlignment.Right;
            this.textBoxRwWear.BorderStyle = BorderStyle.None;
            this.textBoxRwWear.Location = new Point(128, 167);
            this.textBoxRwWear.Name = "textBoxRwWear";
            this.textBoxRwWear.ReadOnly = true;
            this.textBoxRwWear.Size = new Size(32, 13);
            this.textBoxRwWear.TabIndex = 76;
            this.textBoxRwWear.TextAlign = HorizontalAlignment.Right;
            this.label13.Location = new Point(232, 72);
            this.label13.Name = "label13";
            this.label13.Size = new Size(128, 16);
            this.label13.TabIndex = 87;
            this.label13.Text = "Level  Wear  Avg. wear";
            this.label3.Location = new Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Engine";
            this.textBoxen1.BorderStyle = BorderStyle.None;
            this.textBoxen1.Location = new Point(80, 117);
            this.textBoxen1.Name = "textBoxen1";
            this.textBoxen1.ReadOnly = true;
            this.textBoxen1.Size = new Size(12, 13);
            this.textBoxen1.TabIndex = 16;
            this.textBoxen1.TextAlign = HorizontalAlignment.Right;
            this.textBoxTestAcceleration.BorderStyle = BorderStyle.None;
            this.textBoxTestAcceleration.Location = new Point(304, 32);
            this.textBoxTestAcceleration.Name = "textBoxTestAcceleration";
            this.textBoxTestAcceleration.ReadOnly = true;
            this.textBoxTestAcceleration.Size = new Size(21, 13);
            this.textBoxTestAcceleration.TabIndex = 44;
            this.textBoxTestAcceleration.TextAlign = HorizontalAlignment.Right;
            this.textBoxen2.BorderStyle = BorderStyle.None;
            this.textBoxen2.Location = new Point(96, 117);
            this.textBoxen2.Name = "textBoxen2";
            this.textBoxen2.ReadOnly = true;
            this.textBoxen2.Size = new Size(18, 13);
            this.textBoxen2.TabIndex = 17;
            this.textBoxen2.TextAlign = HorizontalAlignment.Right;
            this.textBoxTestHandling.BorderStyle = BorderStyle.None;
            this.textBoxTestHandling.Location = new Point(179, 32);
            this.textBoxTestHandling.Name = "textBoxTestHandling";
            this.textBoxTestHandling.ReadOnly = true;
            this.textBoxTestHandling.Size = new Size(21, 13);
            this.textBoxTestHandling.TabIndex = 43;
            this.textBoxTestHandling.TextAlign = HorizontalAlignment.Right;
            this.label5.Location = new Point(16, 93);
            this.label5.Name = "label5";
            this.label5.Size = new Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chassis";
            this.textBoxch1.BorderStyle = BorderStyle.None;
            this.textBoxch1.Location = new Point(80, 93);
            this.textBoxch1.Name = "textBoxch1";
            this.textBoxch1.ReadOnly = true;
            this.textBoxch1.Size = new Size(12, 13);
            this.textBoxch1.TabIndex = 20;
            this.textBoxch1.TextAlign = HorizontalAlignment.Right;
            this.textBoxTestPower.BorderStyle = BorderStyle.None;
            this.textBoxTestPower.Location = new Point(71, 32);
            this.textBoxTestPower.Name = "textBoxTestPower";
            this.textBoxTestPower.ReadOnly = true;
            this.textBoxTestPower.Size = new Size(21, 13);
            this.textBoxTestPower.TabIndex = 42;
            this.textBoxTestPower.TextAlign = HorizontalAlignment.Right;
            this.textBoxch2.BorderStyle = BorderStyle.None;
            this.textBoxch2.Location = new Point(96, 93);
            this.textBoxch2.Name = "textBoxch2";
            this.textBoxch2.ReadOnly = true;
            this.textBoxch2.Size = new Size(18, 13);
            this.textBoxch2.TabIndex = 21;
            this.textBoxch2.TextAlign = HorizontalAlignment.Right;
            this.label95.Location = new Point(8, 32);
            this.label95.Name = "label95";
            this.label95.Size = new Size(56, 16);
            this.label95.TabIndex = 41;
            this.label95.Text = "From test:";
            this.textBoxHandling.BorderStyle = BorderStyle.None;
            this.textBoxHandling.Location = new Point(179, 16);
            this.textBoxHandling.Name = "textBoxHandling";
            this.textBoxHandling.ReadOnly = true;
            this.textBoxHandling.Size = new Size(21, 13);
            this.textBoxHandling.TabIndex = 40;
            this.textBoxHandling.TextAlign = HorizontalAlignment.Right;
            this.textBoxAcceleration.BorderStyle = BorderStyle.None;
            this.textBoxAcceleration.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.textBoxAcceleration.Location = new Point(304, 16);
            this.textBoxAcceleration.Name = "textBoxAcceleration";
            this.textBoxAcceleration.ReadOnly = true;
            this.textBoxAcceleration.Size = new Size(21, 13);
            this.textBoxAcceleration.TabIndex = 39;
            this.textBoxAcceleration.TextAlign = HorizontalAlignment.Right;
            this.textBoxPower.BorderStyle = BorderStyle.None;
            this.textBoxPower.Location = new Point(71, 16);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.ReadOnly = true;
            this.textBoxPower.Size = new Size(21, 13);
            this.textBoxPower.TabIndex = 38;
            this.textBoxPower.TextAlign = HorizontalAlignment.Right;
            this.label19.Location = new Point(128, 16);
            this.label19.Name = "label19";
            this.label19.Size = new Size(56, 16);
            this.label19.TabIndex = 37;
            this.label19.Text = "Handling:";
            this.label18.Location = new Point(240, 16);
            this.label18.Name = "label18";
            this.label18.Size = new Size(72, 16);
            this.label18.TabIndex = 36;
            this.label18.Text = "Acceleration:";
            this.label17.Location = new Point(8, 16);
            this.label17.Name = "label17";
            this.label17.Size = new Size(40, 16);
            this.label17.TabIndex = 35;
            this.label17.Text = "Power:";
            this.textBoxbr2.BorderStyle = BorderStyle.None;
            this.textBoxbr2.Location = new Point(272, 144);
            this.textBoxbr2.Name = "textBoxbr2";
            this.textBoxbr2.ReadOnly = true;
            this.textBoxbr2.Size = new Size(18, 13);
            this.textBoxbr2.TabIndex = 33;
            this.textBoxbr2.TextAlign = HorizontalAlignment.Right;
            this.textBoxbr1.BorderStyle = BorderStyle.None;
            this.textBoxbr1.Location = new Point(256, 144);
            this.textBoxbr1.Name = "textBoxbr1";
            this.textBoxbr1.ReadOnly = true;
            this.textBoxbr1.Size = new Size(12, 13);
            this.textBoxbr1.TabIndex = 32;
            this.textBoxbr1.TextAlign = HorizontalAlignment.Right;
            this.textBoxco2.BorderStyle = BorderStyle.None;
            this.textBoxco2.Location = new Point(272, 93);
            this.textBoxco2.Name = "textBoxco2";
            this.textBoxco2.ReadOnly = true;
            this.textBoxco2.Size = new Size(18, 13);
            this.textBoxco2.TabIndex = 31;
            this.textBoxco2.TextAlign = HorizontalAlignment.Right;
            this.textBoxco1.BorderStyle = BorderStyle.None;
            this.textBoxco1.Location = new Point(256, 93);
            this.textBoxco1.Name = "textBoxco1";
            this.textBoxco1.ReadOnly = true;
            this.textBoxco1.Size = new Size(12, 13);
            this.textBoxco1.TabIndex = 30;
            this.textBoxco1.TextAlign = HorizontalAlignment.Right;
            this.textBoxsi2.BorderStyle = BorderStyle.None;
            this.textBoxsi2.Location = new Point(96, 221);
            this.textBoxsi2.Name = "textBoxsi2";
            this.textBoxsi2.ReadOnly = true;
            this.textBoxsi2.Size = new Size(18, 13);
            this.textBoxsi2.TabIndex = 29;
            this.textBoxsi2.TextAlign = HorizontalAlignment.Right;
            this.textBoxsi1.BorderStyle = BorderStyle.None;
            this.textBoxsi1.Location = new Point(80, 221);
            this.textBoxsi1.Name = "textBoxsi1";
            this.textBoxsi1.ReadOnly = true;
            this.textBoxsi1.Size = new Size(12, 13);
            this.textBoxsi1.TabIndex = 28;
            this.textBoxsi1.TextAlign = HorizontalAlignment.Right;
            this.textBoxel2.BorderStyle = BorderStyle.None;
            this.textBoxel2.Location = new Point(272, 192);
            this.textBoxel2.Name = "textBoxel2";
            this.textBoxel2.ReadOnly = true;
            this.textBoxel2.Size = new Size(18, 13);
            this.textBoxel2.TabIndex = 27;
            this.textBoxel2.TextAlign = HorizontalAlignment.Right;
            this.textBoxel1.BorderStyle = BorderStyle.None;
            this.textBoxel1.Location = new Point(256, 192);
            this.textBoxel1.Name = "textBoxel1";
            this.textBoxel1.ReadOnly = true;
            this.textBoxel1.Size = new Size(12, 13);
            this.textBoxel1.TabIndex = 26;
            this.textBoxel1.TextAlign = HorizontalAlignment.Right;
            this.textBoxun2.BorderStyle = BorderStyle.None;
            this.textBoxun2.Location = new Point(96, 192);
            this.textBoxun2.Name = "textBoxun2";
            this.textBoxun2.ReadOnly = true;
            this.textBoxun2.Size = new Size(18, 13);
            this.textBoxun2.TabIndex = 25;
            this.textBoxun2.TextAlign = HorizontalAlignment.Right;
            this.textBoxun1.BorderStyle = BorderStyle.None;
            this.textBoxun1.Location = new Point(80, 192);
            this.textBoxun1.Name = "textBoxun1";
            this.textBoxun1.ReadOnly = true;
            this.textBoxun1.Size = new Size(12, 13);
            this.textBoxun1.TabIndex = 24;
            this.textBoxun1.TextAlign = HorizontalAlignment.Right;
            this.textBoxsu2.BorderStyle = BorderStyle.None;
            this.textBoxsu2.Location = new Point(272, 165);
            this.textBoxsu2.Name = "textBoxsu2";
            this.textBoxsu2.ReadOnly = true;
            this.textBoxsu2.Size = new Size(18, 13);
            this.textBoxsu2.TabIndex = 23;
            this.textBoxsu2.TextAlign = HorizontalAlignment.Right;
            this.textBoxsu1.BorderStyle = BorderStyle.None;
            this.textBoxsu1.Location = new Point(256, 165);
            this.textBoxsu1.Name = "textBoxsu1";
            this.textBoxsu1.ReadOnly = true;
            this.textBoxsu1.Size = new Size(12, 13);
            this.textBoxsu1.TabIndex = 22;
            this.textBoxsu1.TextAlign = HorizontalAlignment.Right;
            this.textBoxgb2.BorderStyle = BorderStyle.None;
            this.textBoxgb2.Location = new Point(272, 117);
            this.textBoxgb2.Name = "textBoxgb2";
            this.textBoxgb2.ReadOnly = true;
            this.textBoxgb2.Size = new Size(18, 13);
            this.textBoxgb2.TabIndex = 19;
            this.textBoxgb2.TextAlign = HorizontalAlignment.Right;
            this.textBoxgb1.BorderStyle = BorderStyle.None;
            this.textBoxgb1.Location = new Point(256, 117);
            this.textBoxgb1.Name = "textBoxgb1";
            this.textBoxgb1.ReadOnly = true;
            this.textBoxgb1.Size = new Size(12, 13);
            this.textBoxgb1.TabIndex = 18;
            this.textBoxgb1.TextAlign = HorizontalAlignment.Right;
            this.textBoxrw2.BorderStyle = BorderStyle.None;
            this.textBoxrw2.Location = new Point(96, 167);
            this.textBoxrw2.Name = "textBoxrw2";
            this.textBoxrw2.ReadOnly = true;
            this.textBoxrw2.Size = new Size(18, 13);
            this.textBoxrw2.TabIndex = 15;
            this.textBoxrw2.TextAlign = HorizontalAlignment.Right;
            this.textBoxrw1.BorderStyle = BorderStyle.None;
            this.textBoxrw1.Location = new Point(80, 167);
            this.textBoxrw1.Name = "textBoxrw1";
            this.textBoxrw1.ReadOnly = true;
            this.textBoxrw1.Size = new Size(12, 13);
            this.textBoxrw1.TabIndex = 14;
            this.textBoxrw1.TextAlign = HorizontalAlignment.Right;
            this.label12.Location = new Point(56, 72);
            this.label12.Name = "label12";
            this.label12.Size = new Size(128, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Level  Wear  Avg. wear";
            this.textBoxfw2.BorderStyle = BorderStyle.None;
            this.textBoxfw2.Location = new Point(96, 143);
            this.textBoxfw2.Name = "textBoxfw2";
            this.textBoxfw2.ReadOnly = true;
            this.textBoxfw2.Size = new Size(18, 13);
            this.textBoxfw2.TabIndex = 12;
            this.textBoxfw2.TextAlign = HorizontalAlignment.Right;
            this.textBoxfw1.BorderStyle = BorderStyle.None;
            this.textBoxfw1.Location = new Point(80, 143);
            this.textBoxfw1.Name = "textBoxfw1";
            this.textBoxfw1.ReadOnly = true;
            this.textBoxfw1.Size = new Size(12, 13);
            this.textBoxfw1.TabIndex = 11;
            this.textBoxfw1.TextAlign = HorizontalAlignment.Right;
            this.label11.Location = new Point(192, 165);
            this.label11.Name = "label11";
            this.label11.Size = new Size(64, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Suspension";
            this.label10.Location = new Point(192, 144);
            this.label10.Name = "label10";
            this.label10.Size = new Size(64, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Brakes";
            this.label9.Location = new Point(192, 93);
            this.label9.Name = "label9";
            this.label9.Size = new Size(64, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cooling";
            this.label8.Location = new Point(16, 221);
            this.label8.Name = "label8";
            this.label8.Size = new Size(64, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sidepods";
            this.label7.Location = new Point(192, 192);
            this.label7.Name = "label7";
            this.label7.Size = new Size(64, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Electronics";
            this.label6.Location = new Point(16, 192);
            this.label6.Name = "label6";
            this.label6.Size = new Size(64, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Underbody";
            this.label4.Location = new Point(192, 117);
            this.label4.Name = "label4";
            this.label4.Size = new Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gear Box";
            this.label2.Location = new Point(16, 167);
            this.label2.Name = "label2";
            this.label2.Size = new Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rear Wing";
            this.label1.Location = new Point(16, 143);
            this.label1.Name = "label1";
            this.label1.Size = new Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Front Wing";
            this.label96.Location = new Point(128, 32);
            this.label96.Name = "label96";
            this.label96.Size = new Size(56, 16);
            this.label96.TabIndex = 88;
            this.label96.Text = "From test:";
            this.label97.Location = new Point(240, 32);
            this.label97.Name = "label97";
            this.label97.Size = new Size(56, 16);
            this.label97.TabIndex = 89;
            this.label97.Text = "From test:";
            this.buttonGetTracks.Location = new Point(504, 112);
            this.buttonGetTracks.Name = "buttonGetTracks";
            this.buttonGetTracks.Size = new Size(80, 23);
            this.buttonGetTracks.TabIndex = 11;
            this.buttonGetTracks.Text = "GetTracks";
            this.buttonGetTracks.Visible = false;
            this.buttonGetTracks.Click += new EventHandler(this.MniAllTracksClick);
            this.tabPageStaff.Controls.Add((Control)this.groupBox23);
            this.tabPageStaff.Controls.Add((Control)this.groupBox22);
            this.tabPageStaff.Controls.Add((Control)this.groupBox21);
            this.tabPageStaff.Controls.Add((Control)this.groupBox20);
            this.tabPageStaff.Cursor = Cursors.Default;
            this.tabPageStaff.Location = new Point(4, 22);
            this.tabPageStaff.Name = "tabPageStaff";
            this.tabPageStaff.Size = new Size(797, 343);
            this.tabPageStaff.TabIndex = 8;
            this.tabPageStaff.Text = "Staff";
            this.tabPageStaff.UseVisualStyleBackColor = true;
            this.groupBox23.Controls.Add((Control)this.textBoxStaffFacilities);
            this.groupBox23.Controls.Add((Control)this.textBoxStaffSalary);
            this.groupBox23.Controls.Add((Control)this.label112);
            this.groupBox23.Controls.Add((Control)this.label113);
            this.groupBox23.Location = new Point(384, 8);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new Size(200, 80);
            this.groupBox23.TabIndex = 16;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Staff and Facilities cost per race";
            this.textBoxStaffFacilities.BorderStyle = BorderStyle.None;
            this.textBoxStaffFacilities.Location = new Point(132, 48);
            this.textBoxStaffFacilities.Name = "textBoxStaffFacilities";
            this.textBoxStaffFacilities.ReadOnly = true;
            this.textBoxStaffFacilities.Size = new Size(52, 13);
            this.textBoxStaffFacilities.TabIndex = 19;
            this.textBoxStaffFacilities.TextAlign = HorizontalAlignment.Right;
            this.textBoxStaffSalary.BorderStyle = BorderStyle.None;
            this.textBoxStaffSalary.Location = new Point(132, 24);
            this.textBoxStaffSalary.Name = "textBoxStaffSalary";
            this.textBoxStaffSalary.ReadOnly = true;
            this.textBoxStaffSalary.Size = new Size(52, 13);
            this.textBoxStaffSalary.TabIndex = 18;
            this.textBoxStaffSalary.TextAlign = HorizontalAlignment.Right;
            this.label112.Location = new Point(8, 24);
            this.label112.Name = "label112";
            this.label112.Size = new Size(80, 16);
            this.label112.TabIndex = 13;
            this.label112.Text = "Staff salary";
            this.label113.Location = new Point(8, 48);
            this.label113.Name = "label113";
            this.label113.Size = new Size(120, 16);
            this.label113.TabIndex = 17;
            this.label113.Text = "Facilities maintenance";
            this.groupBox22.Controls.Add((Control)this.textBoxStaffCommercial);
            this.groupBox22.Controls.Add((Control)this.textBoxStaffAlloy);
            this.groupBox22.Controls.Add((Control)this.textBoxStaffEngineering);
            this.groupBox22.Controls.Add((Control)this.textBoxStaffRDDesign);
            this.groupBox22.Controls.Add((Control)this.textBoxStaffRDWorkshop);
            this.groupBox22.Controls.Add((Control)this.textBoxStaffWindtunnel);
            this.groupBox22.Controls.Add((Control)this.label108);
            this.groupBox22.Controls.Add((Control)this.label106);
            this.groupBox22.Controls.Add((Control)this.label104);
            this.groupBox22.Controls.Add((Control)this.label110);
            this.groupBox22.Controls.Add((Control)this.label107);
            this.groupBox22.Controls.Add((Control)this.label109);
            this.groupBox22.Controls.Add((Control)this.label105);
            this.groupBox22.Controls.Add((Control)this.textBoxStaffPitstop);
            this.groupBox22.Location = new Point(192, 8);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new Size(184, 200);
            this.groupBox22.TabIndex = 15;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Facility levels";
            this.textBoxStaffCommercial.BorderStyle = BorderStyle.None;
            this.textBoxStaffCommercial.Location = new Point(144, 168);
            this.textBoxStaffCommercial.Name = "textBoxStaffCommercial";
            this.textBoxStaffCommercial.ReadOnly = true;
            this.textBoxStaffCommercial.Size = new Size(24, 13);
            this.textBoxStaffCommercial.TabIndex = 24;
            this.textBoxStaffCommercial.TextAlign = HorizontalAlignment.Right;
            this.textBoxStaffAlloy.BorderStyle = BorderStyle.None;
            this.textBoxStaffAlloy.Location = new Point(144, 144);
            this.textBoxStaffAlloy.Name = "textBoxStaffAlloy";
            this.textBoxStaffAlloy.ReadOnly = true;
            this.textBoxStaffAlloy.Size = new Size(24, 13);
            this.textBoxStaffAlloy.TabIndex = 23;
            this.textBoxStaffAlloy.TextAlign = HorizontalAlignment.Right;
            this.textBoxStaffEngineering.BorderStyle = BorderStyle.None;
            this.textBoxStaffEngineering.Location = new Point(144, 120);
            this.textBoxStaffEngineering.Name = "textBoxStaffEngineering";
            this.textBoxStaffEngineering.ReadOnly = true;
            this.textBoxStaffEngineering.Size = new Size(24, 13);
            this.textBoxStaffEngineering.TabIndex = 22;
            this.textBoxStaffEngineering.TextAlign = HorizontalAlignment.Right;
            this.textBoxStaffRDDesign.BorderStyle = BorderStyle.None;
            this.textBoxStaffRDDesign.Location = new Point(144, 96);
            this.textBoxStaffRDDesign.Name = "textBoxStaffRDDesign";
            this.textBoxStaffRDDesign.ReadOnly = true;
            this.textBoxStaffRDDesign.Size = new Size(24, 13);
            this.textBoxStaffRDDesign.TabIndex = 21;
            this.textBoxStaffRDDesign.TextAlign = HorizontalAlignment.Right;
            this.textBoxStaffRDWorkshop.BorderStyle = BorderStyle.None;
            this.textBoxStaffRDWorkshop.Location = new Point(144, 72);
            this.textBoxStaffRDWorkshop.Name = "textBoxStaffRDWorkshop";
            this.textBoxStaffRDWorkshop.ReadOnly = true;
            this.textBoxStaffRDWorkshop.Size = new Size(24, 13);
            this.textBoxStaffRDWorkshop.TabIndex = 20;
            this.textBoxStaffRDWorkshop.TextAlign = HorizontalAlignment.Right;
            this.textBoxStaffWindtunnel.BorderStyle = BorderStyle.None;
            this.textBoxStaffWindtunnel.Location = new Point(144, 24);
            this.textBoxStaffWindtunnel.Name = "textBoxStaffWindtunnel";
            this.textBoxStaffWindtunnel.ReadOnly = true;
            this.textBoxStaffWindtunnel.Size = new Size(24, 13);
            this.textBoxStaffWindtunnel.TabIndex = 19;
            this.textBoxStaffWindtunnel.TextAlign = HorizontalAlignment.Right;
            this.label108.Location = new Point(8, 120);
            this.label108.Name = "label108";
            this.label108.Size = new Size(120, 16);
            this.label108.TabIndex = 10;
            this.label108.Text = "Engineering workshop";
            this.label106.Location = new Point(8, 72);
            this.label106.Name = "label106";
            this.label106.Size = new Size(80, 16);
            this.label106.TabIndex = 8;
            this.label106.Text = "R&D workshop";
            this.label106.UseMnemonic = false;
            this.label104.Location = new Point(8, 24);
            this.label104.Name = "label104";
            this.label104.Size = new Size(80, 16);
            this.label104.TabIndex = 6;
            this.label104.Text = "Windtunnel";
            this.label110.Location = new Point(8, 168);
            this.label110.Name = "label110";
            this.label110.Size = new Size(80, 16);
            this.label110.TabIndex = 12;
            this.label110.Text = "Commercial";
            this.label107.Location = new Point(8, 96);
            this.label107.Name = "label107";
            this.label107.Size = new Size(97, 16);
            this.label107.TabIndex = 9;
            this.label107.Text = "R&D design center";
            this.label107.UseMnemonic = false;
            this.label109.Location = new Point(8, 144);
            this.label109.Name = "label109";
            this.label109.Size = new Size(120, 16);
            this.label109.TabIndex = 11;
            this.label109.Text = "Alloy and chemical lab";
            this.label105.Location = new Point(8, 48);
            this.label105.Name = "label105";
            this.label105.Size = new Size(121, 16);
            this.label105.TabIndex = 7;
            this.label105.Text = "Pitstop training center";
            this.textBoxStaffPitstop.BorderStyle = BorderStyle.None;
            this.textBoxStaffPitstop.Location = new Point(144, 48);
            this.textBoxStaffPitstop.Name = "textBoxStaffPitstop";
            this.textBoxStaffPitstop.ReadOnly = true;
            this.textBoxStaffPitstop.Size = new Size(24, 13);
            this.textBoxStaffPitstop.TabIndex = 18;
            this.textBoxStaffPitstop.TextAlign = HorizontalAlignment.Right;
            this.groupBox21.Controls.Add((Control)this.textBoxStaffEfficiency);
            this.groupBox21.Controls.Add((Control)this.textBoxStaffConcentration);
            this.groupBox21.Controls.Add((Control)this.textBoxStaffStressHandling);
            this.groupBox21.Controls.Add((Control)this.textBoxStaffTechnicalSkill);
            this.groupBox21.Controls.Add((Control)this.textBoxStaffMotivation);
            this.groupBox21.Controls.Add((Control)this.panel1);
            this.groupBox21.Controls.Add((Control)this.label99);
            this.groupBox21.Controls.Add((Control)this.label111);
            this.groupBox21.Controls.Add((Control)this.label100);
            this.groupBox21.Controls.Add((Control)this.label101);
            this.groupBox21.Controls.Add((Control)this.label102);
            this.groupBox21.Controls.Add((Control)this.label103);
            this.groupBox21.Controls.Add((Control)this.textBoxStaffExperience);
            this.groupBox21.Location = new Point(8, 64);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new Size(172, 144);
            this.groupBox21.TabIndex = 14;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Staff skills";
            this.textBoxStaffEfficiency.BorderStyle = BorderStyle.None;
            this.textBoxStaffEfficiency.Location = new Point(120, 120);
            this.textBoxStaffEfficiency.Name = "textBoxStaffEfficiency";
            this.textBoxStaffEfficiency.ReadOnly = true;
            this.textBoxStaffEfficiency.Size = new Size(24, 13);
            this.textBoxStaffEfficiency.TabIndex = 23;
            this.textBoxStaffEfficiency.TextAlign = HorizontalAlignment.Right;
            this.textBoxStaffConcentration.BorderStyle = BorderStyle.None;
            this.textBoxStaffConcentration.Location = new Point(120, 104);
            this.textBoxStaffConcentration.Name = "textBoxStaffConcentration";
            this.textBoxStaffConcentration.ReadOnly = true;
            this.textBoxStaffConcentration.Size = new Size(24, 13);
            this.textBoxStaffConcentration.TabIndex = 22;
            this.textBoxStaffConcentration.TextAlign = HorizontalAlignment.Right;
            this.textBoxStaffStressHandling.BorderStyle = BorderStyle.None;
            this.textBoxStaffStressHandling.Location = new Point(120, 88);
            this.textBoxStaffStressHandling.Name = "textBoxStaffStressHandling";
            this.textBoxStaffStressHandling.ReadOnly = true;
            this.textBoxStaffStressHandling.Size = new Size(24, 13);
            this.textBoxStaffStressHandling.TabIndex = 21;
            this.textBoxStaffStressHandling.TextAlign = HorizontalAlignment.Right;
            this.textBoxStaffTechnicalSkill.BorderStyle = BorderStyle.None;
            this.textBoxStaffTechnicalSkill.Location = new Point(120, 56);
            this.textBoxStaffTechnicalSkill.Name = "textBoxStaffTechnicalSkill";
            this.textBoxStaffTechnicalSkill.ReadOnly = true;
            this.textBoxStaffTechnicalSkill.Size = new Size(24, 13);
            this.textBoxStaffTechnicalSkill.TabIndex = 20;
            this.textBoxStaffTechnicalSkill.TextAlign = HorizontalAlignment.Right;
            this.textBoxStaffMotivation.BorderStyle = BorderStyle.None;
            this.textBoxStaffMotivation.Location = new Point(120, 40);
            this.textBoxStaffMotivation.Name = "textBoxStaffMotivation";
            this.textBoxStaffMotivation.ReadOnly = true;
            this.textBoxStaffMotivation.Size = new Size(24, 13);
            this.textBoxStaffMotivation.TabIndex = 19;
            this.textBoxStaffMotivation.TextAlign = HorizontalAlignment.Right;
            this.panel1.Location = new Point(8, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(152, 8);
            this.panel1.TabIndex = 16;
            this.label99.Location = new Point(8, 24);
            this.label99.Name = "label99";
            this.label99.Size = new Size(80, 16);
            this.label99.TabIndex = 1;
            this.label99.Text = "Experience";
            this.label111.Location = new Point(8, 40);
            this.label111.Name = "label111";
            this.label111.Size = new Size(80, 16);
            this.label111.TabIndex = 15;
            this.label111.Text = "Motivation";
            this.label100.Location = new Point(8, 56);
            this.label100.Name = "label100";
            this.label100.Size = new Size(80, 16);
            this.label100.TabIndex = 2;
            this.label100.Text = "Technical skill";
            this.label101.Location = new Point(8, 88);
            this.label101.Name = "label101";
            this.label101.Size = new Size(97, 16);
            this.label101.TabIndex = 3;
            this.label101.Text = "Stress handling";
            this.label102.Location = new Point(8, 104);
            this.label102.Name = "label102";
            this.label102.Size = new Size(80, 16);
            this.label102.TabIndex = 4;
            this.label102.Text = "Concentration";
            this.label103.Location = new Point(8, 120);
            this.label103.Name = "label103";
            this.label103.Size = new Size(80, 16);
            this.label103.TabIndex = 5;
            this.label103.Text = "Efficiency";
            this.textBoxStaffExperience.BorderStyle = BorderStyle.None;
            this.textBoxStaffExperience.Location = new Point(120, 24);
            this.textBoxStaffExperience.Name = "textBoxStaffExperience";
            this.textBoxStaffExperience.ReadOnly = true;
            this.textBoxStaffExperience.Size = new Size(24, 13);
            this.textBoxStaffExperience.TabIndex = 18;
            this.textBoxStaffExperience.TextAlign = HorizontalAlignment.Right;
            this.groupBox20.Controls.Add((Control)this.label98);
            this.groupBox20.Controls.Add((Control)this.textBoxStaffOverall);
            this.groupBox20.Location = new Point(8, 8);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new Size(172, 48);
            this.groupBox20.TabIndex = 13;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Staff and Facilities";
            this.label98.Location = new Point(8, 24);
            this.label98.Name = "label98";
            this.label98.Size = new Size(80, 16);
            this.label98.TabIndex = 0;
            this.label98.Text = "Overall";
            this.textBoxStaffOverall.BorderStyle = BorderStyle.None;
            this.textBoxStaffOverall.Location = new Point(120, 24);
            this.textBoxStaffOverall.Name = "textBoxStaffOverall";
            this.textBoxStaffOverall.ReadOnly = true;
            this.textBoxStaffOverall.Size = new Size(24, 13);
            this.textBoxStaffOverall.TabIndex = 18;
            this.textBoxStaffOverall.TextAlign = HorizontalAlignment.Right;
            this.tabPageSeason.Controls.Add((Control)this.listViewSeason);
            this.tabPageSeason.Location = new Point(4, 22);
            this.tabPageSeason.Name = "tabPageSeason";
            this.tabPageSeason.Size = new Size(797, 343);
            this.tabPageSeason.TabIndex = 1;
            this.tabPageSeason.Text = "Season";
            this.tabPageSeason.UseVisualStyleBackColor = true;
            this.listViewSeason.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.listViewSeason.Columns.AddRange(new ColumnHeader[11]
            {
        this.number,
        this.trackname,
        this.carUpdated,
        this.DriverUpdated,
        this.TyreSupplierUpdated,
        this.PractiseUpdated,
        this.QualifyUpdated,
        this.Qualify2Updated,
        this.StrategyUpdated,
        this.raceUpdated,
        this.sponsorUpdated
            });
            this.listViewSeason.ContextMenu = this.contextMenuSeason;
            this.listViewSeason.FullRowSelect = true;
            this.listViewSeason.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.listViewSeason.HideSelection = false;
            this.listViewSeason.Location = new Point(-4, 0);
            this.listViewSeason.MultiSelect = false;
            this.listViewSeason.Name = "listViewSeason";
            this.listViewSeason.Size = new Size(805, 329);
            this.listViewSeason.TabIndex = 0;
            this.listViewSeason.UseCompatibleStateImageBehavior = false;
            this.listViewSeason.View = View.Details;
            this.listViewSeason.DoubleClick += new EventHandler(this.listViewSeason_DoubleClick);
            this.listViewSeason.KeyPress += new KeyPressEventHandler(this.listViewSeason_KeyPress);
            this.number.Text = "Race";
            this.number.Width = 40;
            this.trackname.Text = "Track";
            this.trackname.Width = 77;
            this.carUpdated.Text = "Car";
            this.carUpdated.Width = 58;
            this.DriverUpdated.Text = "Driver";
            this.DriverUpdated.Width = 56;
            this.TyreSupplierUpdated.Text = "Tyre Supplier";
            this.TyreSupplierUpdated.Width = 88;
            this.PractiseUpdated.Text = "Practice";
            this.PractiseUpdated.Width = 64;
            this.QualifyUpdated.Text = "Qualify";
            this.Qualify2Updated.Text = "Qualify 2";
            this.Qualify2Updated.Width = 70;
            this.StrategyUpdated.Text = "Strategy";
            this.StrategyUpdated.Width = 65;
            this.raceUpdated.Text = "Race";
            this.raceUpdated.Width = 57;
            this.sponsorUpdated.Text = "Sponsor";
            this.contextMenuSeason.MenuItems.AddRange(new MenuItem[1]
            {
        this.menuItem2
            });
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Edit Note";
            this.menuItem2.Click += new EventHandler(this.menuItem2_Click);
            this.tabPageTesting.Controls.Add((Control)this.groupBox31);
            this.tabPageTesting.Controls.Add((Control)this.textBoxTestingComments);
            this.tabPageTesting.Controls.Add((Control)this.listViewTesting);
            this.tabPageTesting.Controls.Add((Control)this.groupBox19);
            this.tabPageTesting.Location = new Point(4, 22);
            this.tabPageTesting.Name = "tabPageTesting";
            this.tabPageTesting.Size = new Size(797, 343);
            this.tabPageTesting.TabIndex = 6;
            this.tabPageTesting.Text = "Testing";
            this.tabPageTesting.UseVisualStyleBackColor = true;
            this.groupBox31.Controls.Add((Control)this.testWeather);
            this.groupBox31.Controls.Add((Control)this.label69);
            this.groupBox31.Controls.Add((Control)this.testTemp);
            this.groupBox31.Controls.Add((Control)this.testHumidity);
            this.groupBox31.Controls.Add((Control)this.label70);
            this.groupBox31.Controls.Add((Control)this.label71);
            this.groupBox31.Location = new Point(610, 8);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new Size(176, 96);
            this.groupBox31.TabIndex = 16;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Weather";
            this.testWeather.BorderStyle = BorderStyle.None;
            this.testWeather.Location = new Point(96, 72);
            this.testWeather.Name = "testWeather";
            this.testWeather.ReadOnly = true;
            this.testWeather.Size = new Size(72, 13);
            this.testWeather.TabIndex = 7;
            this.label69.Location = new Point(8, 72);
            this.label69.Name = "label69";
            this.label69.Size = new Size(88, 16);
            this.label69.TabIndex = 6;
            this.label69.Text = "Weather:";
            this.testTemp.BorderStyle = BorderStyle.None;
            this.testTemp.Location = new Point(96, 24);
            this.testTemp.Name = "testTemp";
            this.testTemp.ReadOnly = true;
            this.testTemp.Size = new Size(72, 13);
            this.testTemp.TabIndex = 5;
            this.testHumidity.BorderStyle = BorderStyle.None;
            this.testHumidity.Location = new Point(96, 48);
            this.testHumidity.Name = "testHumidity";
            this.testHumidity.ReadOnly = true;
            this.testHumidity.Size = new Size(72, 13);
            this.testHumidity.TabIndex = 4;
            this.label70.Location = new Point(8, 48);
            this.label70.Name = "label70";
            this.label70.Size = new Size(72, 16);
            this.label70.TabIndex = 1;
            this.label70.Text = "Humidity:";
            this.label71.Location = new Point(8, 24);
            this.label71.Name = "label71";
            this.label71.Size = new Size(72, 16);
            this.label71.TabIndex = 0;
            this.label71.Text = "Temp:";
            this.textBoxTestingComments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxTestingComments.BorderStyle = BorderStyle.None;
            this.textBoxTestingComments.Location = new Point(3, 298);
            this.textBoxTestingComments.Multiline = true;
            this.textBoxTestingComments.Name = "textBoxTestingComments";
            this.textBoxTestingComments.ReadOnly = true;
            this.textBoxTestingComments.ScrollBars = ScrollBars.Vertical;
            this.textBoxTestingComments.Size = new Size(797, 42);
            this.textBoxTestingComments.TabIndex = 2;
            this.textBoxTestingComments.TabStop = false;
            this.listViewTesting.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.listViewTesting.Columns.AddRange(new ColumnHeader[16]
            {
        this.lapsTestHeader,
        this.meanTimeHeader,
        this.bestTimeHeader,
        this.lapLimitHeader,
        this.lapsDoneHeader,
        this.fuelStartHeader,
        this.tyreWearHeader,
        this.fuelLeftHeader,
        this.priorityHeader,
        this.fWingTestHeader,
        this.rWingTestHeader,
        this.engineTestHeader,
        this.brakesTestHeader,
        this.gearTestHeader,
        this.suspTestHeader,
        this.tyresTestHeader
            });
            this.listViewTesting.FullRowSelect = true;
            this.listViewTesting.HideSelection = false;
            this.listViewTesting.Location = new Point(8, 110);
            this.listViewTesting.Name = "listViewTesting";
            this.listViewTesting.Size = new Size(797, 182);
            this.listViewTesting.TabIndex = 1;
            this.listViewTesting.UseCompatibleStateImageBehavior = false;
            this.listViewTesting.View = View.Details;
            this.listViewTesting.SelectedIndexChanged += new EventHandler(this.listViewTesting_SelectedIndexChanged);
            this.lapsTestHeader.Text = "Lap";
            this.lapsTestHeader.Width = 35;
            this.meanTimeHeader.Text = "Mean time";
            this.meanTimeHeader.Width = 54;
            this.bestTimeHeader.Text = "Best time";
            this.bestTimeHeader.Width = 54;
            this.lapLimitHeader.Text = "Lap Limit";
            this.lapLimitHeader.TextAlign = HorizontalAlignment.Right;
            this.lapLimitHeader.Width = 65;
            this.lapsDoneHeader.Text = "Laps done";
            this.lapsDoneHeader.TextAlign = HorizontalAlignment.Right;
            this.lapsDoneHeader.Width = 65;
            this.fuelStartHeader.Text = "Fuel start";
            this.fuelStartHeader.TextAlign = HorizontalAlignment.Right;
            this.tyreWearHeader.Text = "Tyres cond.";
            this.tyreWearHeader.TextAlign = HorizontalAlignment.Right;
            this.fuelLeftHeader.Text = "Fuel left";
            this.fuelLeftHeader.TextAlign = HorizontalAlignment.Right;
            this.priorityHeader.Text = "Priority";
            this.priorityHeader.TextAlign = HorizontalAlignment.Right;
            this.fWingTestHeader.Text = "Fwing";
            this.fWingTestHeader.TextAlign = HorizontalAlignment.Right;
            this.fWingTestHeader.Width = 40;
            this.rWingTestHeader.Text = "RWing";
            this.rWingTestHeader.TextAlign = HorizontalAlignment.Right;
            this.rWingTestHeader.Width = 47;
            this.engineTestHeader.Text = "Engine";
            this.engineTestHeader.TextAlign = HorizontalAlignment.Right;
            this.engineTestHeader.Width = 46;
            this.brakesTestHeader.Text = "Brakes";
            this.brakesTestHeader.TextAlign = HorizontalAlignment.Right;
            this.brakesTestHeader.Width = 46;
            this.gearTestHeader.Text = "Gear";
            this.gearTestHeader.TextAlign = HorizontalAlignment.Right;
            this.gearTestHeader.Width = 37;
            this.suspTestHeader.Text = "Susp";
            this.suspTestHeader.TextAlign = HorizontalAlignment.Right;
            this.suspTestHeader.Width = 40;
            this.tyresTestHeader.Text = "Tyres";
            this.tyresTestHeader.Width = 66;
            this.groupBox19.Controls.Add((Control)this.listViewTest);
            this.groupBox19.Location = new Point(8, 8);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new Size(282, 96);
            this.groupBox19.TabIndex = 0;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Current points distribution";
            this.listViewTest.Columns.AddRange(new ColumnHeader[4]
            {
        this.columnHeader13,
        this.columnHeader14,
        this.columnHeader15,
        this.columnHeader16
            });
            this.listViewTest.HideSelection = false;
            this.listViewTest.Location = new Point(0, 16);
            this.listViewTest.Name = "listViewTest";
            this.listViewTest.Scrollable = false;
            this.listViewTest.Size = new Size(280, 80);
            this.listViewTest.TabIndex = 0;
            this.listViewTest.UseCompatibleStateImageBehavior = false;
            this.listViewTest.View = View.Details;
            this.columnHeader13.Text = "Points type";
            this.columnHeader13.Width = 104;
            this.columnHeader14.Text = "Power";
            this.columnHeader14.TextAlign = HorizontalAlignment.Center;
            this.columnHeader14.Width = 46;
            this.columnHeader15.Text = "Handling";
            this.columnHeader15.TextAlign = HorizontalAlignment.Center;
            this.columnHeader15.Width = 54;
            this.columnHeader16.Text = "Acceleration";
            this.columnHeader16.TextAlign = HorizontalAlignment.Center;
            this.columnHeader16.Width = 74;
            this.tabPagePractice.Controls.Add((Control)this.buttonExport);
            this.tabPagePractice.Controls.Add((Control)this.comboBoxPrac);
            this.tabPagePractice.Controls.Add((Control)this.textBoxPracHum);
            this.tabPagePractice.Controls.Add((Control)this.textBoxPracTemp);
            this.tabPagePractice.Controls.Add((Control)this.label16);
            this.tabPagePractice.Controls.Add((Control)this.label15);
            this.tabPagePractice.Controls.Add((Control)this.textBoxPracWeather);
            this.tabPagePractice.Controls.Add((Control)this.label14);
            this.tabPagePractice.Controls.Add((Control)this.listViewPractice);
            this.tabPagePractice.Controls.Add((Control)this.textBoxPracComments);
            this.tabPagePractice.Location = new Point(4, 22);
            this.tabPagePractice.Name = "tabPagePractice";
            this.tabPagePractice.Size = new Size(797, 343);
            this.tabPagePractice.TabIndex = 2;
            this.tabPagePractice.Text = "Practice";
            this.tabPagePractice.UseVisualStyleBackColor = true;
            this.buttonExport.Enabled = false;
            this.buttonExport.Location = new Point(496, 8);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new Size(72, 23);
            this.buttonExport.TabIndex = 8;
            this.buttonExport.Text = "Export data";
            this.buttonExport.Click += new EventHandler(this.buttonExport_Click);
            this.comboBoxPrac.Location = new Point(360, 8);
            this.comboBoxPrac.Name = "comboBoxPrac";
            this.comboBoxPrac.Size = new Size(121, 21);
            this.comboBoxPrac.TabIndex = 7;
            this.comboBoxPrac.SelectedIndexChanged += new EventHandler(this.comboBoxPrac_SelectedIndexChanged);
            this.textBoxPracHum.Location = new Point(320, 8);
            this.textBoxPracHum.Name = "textBoxPracHum";
            this.textBoxPracHum.ReadOnly = true;
            this.textBoxPracHum.Size = new Size(18, 20);
            this.textBoxPracHum.TabIndex = 6;
            this.textBoxPracTemp.Location = new Point(232, 8);
            this.textBoxPracTemp.Name = "textBoxPracTemp";
            this.textBoxPracTemp.ReadOnly = true;
            this.textBoxPracTemp.Size = new Size(18, 20);
            this.textBoxPracTemp.TabIndex = 5;
            this.label16.Location = new Point(272, 8);
            this.label16.Name = "label16";
            this.label16.Size = new Size(56, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Humidity:";
            this.label15.Location = new Point(160, 8);
            this.label15.Name = "label15";
            this.label15.Size = new Size(72, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Temperature:";
            this.textBoxPracWeather.Location = new Point(56, 8);
            this.textBoxPracWeather.Name = "textBoxPracWeather";
            this.textBoxPracWeather.ReadOnly = true;
            this.textBoxPracWeather.Size = new Size(100, 20);
            this.textBoxPracWeather.TabIndex = 2;
            this.label14.Location = new Point(8, 8);
            this.label14.Name = "label14";
            this.label14.Size = new Size(56, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Weather:";
            this.listViewPractice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.listViewPractice.Columns.AddRange(new ColumnHeader[11]
            {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader5,
        this.columnHeader6,
        this.columnHeader7,
        this.columnHeader8,
        this.columnHeader9,
        this.columnHeader10,
        this.columnHeader11
            });
            this.listViewPractice.FullRowSelect = true;
            this.listViewPractice.HideSelection = false;
            this.listViewPractice.Location = new Point(0, 32);
            this.listViewPractice.Name = "listViewPractice";
            this.listViewPractice.Scrollable = false;
            this.listViewPractice.Size = new Size(797, 136);
            this.listViewPractice.TabIndex = 0;
            this.listViewPractice.UseCompatibleStateImageBehavior = false;
            this.listViewPractice.View = View.Details;
            this.listViewPractice.SelectedIndexChanged += new EventHandler(this.listViewPractice_SelectedIndexChanged);
            this.columnHeader1.Text = "Lap";
            this.columnHeader1.Width = 34;
            this.columnHeader2.Text = "Lap time";
            this.columnHeader2.Width = 54;
            this.columnHeader3.Text = "Driver mistake";
            this.columnHeader3.TextAlign = HorizontalAlignment.Right;
            this.columnHeader3.Width = 81;
            this.columnHeader4.Text = "Net time";
            this.columnHeader4.TextAlign = HorizontalAlignment.Right;
            this.columnHeader4.Width = 65;
            this.columnHeader5.Text = "Fwing";
            this.columnHeader5.TextAlign = HorizontalAlignment.Right;
            this.columnHeader5.Width = 101;
            this.columnHeader6.Text = "RWing";
            this.columnHeader6.TextAlign = HorizontalAlignment.Right;
            this.columnHeader6.Width = 47;
            this.columnHeader7.Text = "Engine";
            this.columnHeader7.TextAlign = HorizontalAlignment.Right;
            this.columnHeader7.Width = 46;
            this.columnHeader8.Text = "Brakes";
            this.columnHeader8.TextAlign = HorizontalAlignment.Right;
            this.columnHeader8.Width = 46;
            this.columnHeader9.Text = "Gear";
            this.columnHeader9.TextAlign = HorizontalAlignment.Right;
            this.columnHeader9.Width = 37;
            this.columnHeader10.Text = "Susp";
            this.columnHeader10.TextAlign = HorizontalAlignment.Right;
            this.columnHeader10.Width = 40;
            this.columnHeader11.Text = "Tyres";
            this.columnHeader11.Width = 66;
            this.textBoxPracComments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxPracComments.BorderStyle = BorderStyle.None;
            this.textBoxPracComments.Location = new Point(0, 168);
            this.textBoxPracComments.Multiline = true;
            this.textBoxPracComments.Name = "textBoxPracComments";
            this.textBoxPracComments.ReadOnly = true;
            this.textBoxPracComments.ScrollBars = ScrollBars.Vertical;
            this.textBoxPracComments.Size = new Size(797, 177);
            this.textBoxPracComments.TabIndex = 0;
            this.textBoxPracComments.TabStop = false;
            this.tabPageQualify.Controls.Add((Control)this.groupQualify2);
            this.tabPageQualify.Controls.Add((Control)this.groupQualify1);
            this.tabPageQualify.Location = new Point(4, 22);
            this.tabPageQualify.Name = "tabPageQualify";
            this.tabPageQualify.Padding = new Padding(3);
            this.tabPageQualify.Size = new Size(797, 343);
            this.tabPageQualify.TabIndex = 10;
            this.tabPageQualify.Text = "Qualify";
            this.tabPageQualify.UseVisualStyleBackColor = true;
            this.groupQualify2.Controls.Add((Control)this.listViewQualify2);
            this.groupQualify2.Location = new Point(20, 146);
            this.groupQualify2.Name = "groupQualify2";
            this.groupQualify2.Size = new Size(753, 103);
            this.groupQualify2.TabIndex = 1;
            this.groupQualify2.TabStop = false;
            this.groupQualify2.Text = "Qualify 2";
            this.listViewQualify2.Columns.AddRange(new ColumnHeader[10]
            {
        this.columnHeader32,
        this.columnHeader33,
        this.columnHeader34,
        this.columnHeader35,
        this.columnHeader36,
        this.columnHeader37,
        this.columnHeader38,
        this.columnHeader39,
        this.columnHeader40,
        this.columnHeader41
            });
            this.listViewQualify2.HideSelection = false;
            this.listViewQualify2.Items.AddRange(new ListViewItem[1]
            {
        listViewItem1
            });
            this.listViewQualify2.Location = new Point(15, 19);
            this.listViewQualify2.Name = "listViewQualify2";
            this.listViewQualify2.Scrollable = false;
            this.listViewQualify2.Size = new Size(732, 78);
            this.listViewQualify2.TabIndex = 1;
            this.listViewQualify2.UseCompatibleStateImageBehavior = false;
            this.listViewQualify2.View = View.Details;
            this.columnHeader32.Text = "Time";
            this.columnHeader33.Text = "FWing";
            this.columnHeader34.Text = "RWing";
            this.columnHeader35.Text = "Engine";
            this.columnHeader36.Text = "Brakes";
            this.columnHeader37.Text = "Gear";
            this.columnHeader38.Text = "Suspension";
            this.columnHeader39.Text = "Fuel";
            this.columnHeader40.Text = "Tyres";
            this.columnHeader41.Text = "Risk";
            this.groupQualify1.Controls.Add((Control)this.listViewQualify1);
            this.groupQualify1.Location = new Point(20, 22);
            this.groupQualify1.Name = "groupQualify1";
            this.groupQualify1.Size = new Size(753, 103);
            this.groupQualify1.TabIndex = 0;
            this.groupQualify1.TabStop = false;
            this.groupQualify1.Text = "Qualify 1";
            this.listViewQualify1.Columns.AddRange(new ColumnHeader[9]
            {
        this.columnHeader22,
        this.columnHeader23,
        this.columnHeader24,
        this.columnHeader25,
        this.columnHeader26,
        this.columnHeader27,
        this.columnHeader28,
        this.columnHeader30,
        this.columnHeader31
            });
            this.listViewQualify1.HideSelection = false;
            this.listViewQualify1.Items.AddRange(new ListViewItem[1]
            {
        listViewItem2
            });
            this.listViewQualify1.Location = new Point(15, 19);
            this.listViewQualify1.Name = "listViewQualify1";
            this.listViewQualify1.Scrollable = false;
            this.listViewQualify1.Size = new Size(732, 78);
            this.listViewQualify1.TabIndex = 0;
            this.listViewQualify1.UseCompatibleStateImageBehavior = false;
            this.listViewQualify1.View = View.Details;
            this.columnHeader22.Text = "Time";
            this.columnHeader23.Text = "FWing";
            this.columnHeader24.Text = "RWing";
            this.columnHeader25.Text = "Engine";
            this.columnHeader26.Text = "Brakes";
            this.columnHeader27.Text = "Gear";
            this.columnHeader28.Text = "Suspension";
            this.columnHeader30.Text = "Tyres";
            this.columnHeader31.Text = "Risk";
            this.tabPageStrategy.Controls.Add((Control)this.groupBox32);
            this.tabPageStrategy.Controls.Add((Control)this.groupBox3);
            this.tabPageStrategy.Controls.Add((Control)this.groupBox6);
            this.tabPageStrategy.Controls.Add((Control)this.groupBox5);
            this.tabPageStrategy.Controls.Add((Control)this.groupBox4);
            this.tabPageStrategy.Controls.Add((Control)this.groupBox2);
            this.tabPageStrategy.Location = new Point(4, 22);
            this.tabPageStrategy.Name = "tabPageStrategy";
            this.tabPageStrategy.Size = new Size(797, 343);
            this.tabPageStrategy.TabIndex = 3;
            this.tabPageStrategy.Text = "Strategy";
            this.tabPageStrategy.UseVisualStyleBackColor = true;
            this.groupBox32.Controls.Add((Control)this.textBoxBoostLaps3);
            this.groupBox32.Controls.Add((Control)this.textBoxBoostLaps2);
            this.groupBox32.Controls.Add((Control)this.textBoxBoostLaps1);
            this.groupBox32.Location = new Point(8, 246);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new Size(112, 44);
            this.groupBox32.TabIndex = 44;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Boost laps";
            this.textBoxBoostLaps3.BorderStyle = BorderStyle.None;
            this.textBoxBoostLaps3.Location = new Point(74, 19);
            this.textBoxBoostLaps3.Name = "textBoxBoostLaps3";
            this.textBoxBoostLaps3.ReadOnly = true;
            this.textBoxBoostLaps3.Size = new Size(24, 13);
            this.textBoxBoostLaps3.TabIndex = 40;
            this.textBoxBoostLaps2.BorderStyle = BorderStyle.None;
            this.textBoxBoostLaps2.Location = new Point(44, 19);
            this.textBoxBoostLaps2.Name = "textBoxBoostLaps2";
            this.textBoxBoostLaps2.ReadOnly = true;
            this.textBoxBoostLaps2.Size = new Size(24, 13);
            this.textBoxBoostLaps2.TabIndex = 39;
            this.textBoxBoostLaps1.BorderStyle = BorderStyle.None;
            this.textBoxBoostLaps1.Location = new Point(12, 19);
            this.textBoxBoostLaps1.Name = "textBoxBoostLaps1";
            this.textBoxBoostLaps1.ReadOnly = true;
            this.textBoxBoostLaps1.Size = new Size(24, 13);
            this.textBoxBoostLaps1.TabIndex = 38;
            this.groupBox3.Controls.Add((Control)this.labelWaitDry);
            this.groupBox3.Controls.Add((Control)this.labelWaitRain);
            this.groupBox3.Controls.Add((Control)this.label35);
            this.groupBox3.Controls.Add((Control)this.textBoxWaitDry);
            this.groupBox3.Controls.Add((Control)this.textBoxTyresDry);
            this.groupBox3.Controls.Add((Control)this.textBoxTyresRain);
            this.groupBox3.Controls.Add((Control)this.label27);
            this.groupBox3.Controls.Add((Control)this.label28);
            this.groupBox3.Controls.Add((Control)this.label34);
            this.groupBox3.Controls.Add((Control)this.label26);
            this.groupBox3.Controls.Add((Control)this.textBoxTyresStart);
            this.groupBox3.Controls.Add((Control)this.textBoxWaitRain);
            this.groupBox3.Location = new Point(8, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(280, 96);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tyre strategy";
            this.labelWaitDry.Location = new Point(216, 72);
            this.labelWaitDry.Name = "labelWaitDry";
            this.labelWaitDry.Size = new Size(32, 16);
            this.labelWaitDry.TabIndex = 43;
            this.labelWaitDry.Text = "laps";
            this.labelWaitRain.Location = new Point(48, 72);
            this.labelWaitRain.Name = "labelWaitRain";
            this.labelWaitRain.Size = new Size(32, 16);
            this.labelWaitRain.TabIndex = 42;
            this.labelWaitRain.Text = "laps";
            this.label35.Location = new Point(138, 56);
            this.label35.Name = "label35";
            this.label35.Size = new Size(139, 16);
            this.label35.TabIndex = 15;
            this.label35.Text = "Wait to pit if it stops raining";
            this.textBoxWaitDry.BorderStyle = BorderStyle.None;
            this.textBoxWaitDry.Location = new Point(200, 72);
            this.textBoxWaitDry.Name = "textBoxWaitDry";
            this.textBoxWaitDry.ReadOnly = true;
            this.textBoxWaitDry.Size = new Size(16, 13);
            this.textBoxWaitDry.TabIndex = 41;
            this.textBoxWaitDry.TabStop = false;
            this.textBoxWaitDry.TextAlign = HorizontalAlignment.Right;
            this.textBoxTyresDry.BorderStyle = BorderStyle.None;
            this.textBoxTyresDry.Location = new Point(192, 32);
            this.textBoxTyresDry.Name = "textBoxTyresDry";
            this.textBoxTyresDry.ReadOnly = true;
            this.textBoxTyresDry.Size = new Size(48, 13);
            this.textBoxTyresDry.TabIndex = 40;
            this.textBoxTyresRain.BorderStyle = BorderStyle.None;
            this.textBoxTyresRain.Location = new Point(104, 32);
            this.textBoxTyresRain.Name = "textBoxTyresRain";
            this.textBoxTyresRain.ReadOnly = true;
            this.textBoxTyresRain.Size = new Size(40, 13);
            this.textBoxTyresRain.TabIndex = 39;
            this.label27.Location = new Point(88, 16);
            this.label27.Name = "label27";
            this.label27.Size = new Size(72, 16);
            this.label27.TabIndex = 7;
            this.label27.Text = "When it rains";
            this.label28.Location = new Point(168, 16);
            this.label28.Name = "label28";
            this.label28.Size = new Size(110, 16);
            this.label28.TabIndex = 8;
            this.label28.Text = "When the track is dry";
            this.label34.Location = new Point(2, 56);
            this.label34.Name = "label34";
            this.label34.Size = new Size(144, 16);
            this.label34.TabIndex = 14;
            this.label34.Text = "Wait to pit if it starts raining";
            this.label26.Location = new Point(8, 16);
            this.label26.Name = "label26";
            this.label26.Size = new Size(64, 16);
            this.label26.TabIndex = 6;
            this.label26.Text = "At the start";
            this.textBoxTyresStart.BorderStyle = BorderStyle.None;
            this.textBoxTyresStart.Location = new Point(16, 32);
            this.textBoxTyresStart.Name = "textBoxTyresStart";
            this.textBoxTyresStart.ReadOnly = true;
            this.textBoxTyresStart.Size = new Size(48, 13);
            this.textBoxTyresStart.TabIndex = 38;
            this.textBoxWaitRain.BorderStyle = BorderStyle.None;
            this.textBoxWaitRain.Location = new Point(32, 72);
            this.textBoxWaitRain.Name = "textBoxWaitRain";
            this.textBoxWaitRain.ReadOnly = true;
            this.textBoxWaitRain.Size = new Size(16, 13);
            this.textBoxWaitRain.TabIndex = 36;
            this.textBoxWaitRain.TabStop = false;
            this.textBoxWaitRain.TextAlign = HorizontalAlignment.Right;
            this.groupBox6.Controls.Add((Control)this.textBoxSusp);
            this.groupBox6.Controls.Add((Control)this.textBoxGear);
            this.groupBox6.Controls.Add((Control)this.textBoxBra);
            this.groupBox6.Controls.Add((Control)this.textBoxEng);
            this.groupBox6.Controls.Add((Control)this.textBoxRWing);
            this.groupBox6.Controls.Add((Control)this.label44);
            this.groupBox6.Controls.Add((Control)this.label43);
            this.groupBox6.Controls.Add((Control)this.label42);
            this.groupBox6.Controls.Add((Control)this.label41);
            this.groupBox6.Controls.Add((Control)this.label40);
            this.groupBox6.Controls.Add((Control)this.label29);
            this.groupBox6.Controls.Add((Control)this.textBoxFWing);
            this.groupBox6.Location = new Point(288, 144);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new Size(288, 96);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Setup";
            this.textBoxSusp.BorderStyle = BorderStyle.None;
            this.textBoxSusp.Location = new Point(248, 56);
            this.textBoxSusp.Name = "textBoxSusp";
            this.textBoxSusp.ReadOnly = true;
            this.textBoxSusp.Size = new Size(24, 13);
            this.textBoxSusp.TabIndex = 31;
            this.textBoxSusp.TabStop = false;
            this.textBoxSusp.TextAlign = HorizontalAlignment.Right;
            this.textBoxGear.BorderStyle = BorderStyle.None;
            this.textBoxGear.Location = new Point(200, 56);
            this.textBoxGear.Name = "textBoxGear";
            this.textBoxGear.ReadOnly = true;
            this.textBoxGear.Size = new Size(24, 13);
            this.textBoxGear.TabIndex = 30;
            this.textBoxGear.TabStop = false;
            this.textBoxGear.TextAlign = HorizontalAlignment.Right;
            this.textBoxBra.BorderStyle = BorderStyle.None;
            this.textBoxBra.Location = new Point(152, 56);
            this.textBoxBra.Name = "textBoxBra";
            this.textBoxBra.ReadOnly = true;
            this.textBoxBra.Size = new Size(24, 13);
            this.textBoxBra.TabIndex = 29;
            this.textBoxBra.TabStop = false;
            this.textBoxBra.TextAlign = HorizontalAlignment.Right;
            this.textBoxEng.BorderStyle = BorderStyle.None;
            this.textBoxEng.Location = new Point(104, 56);
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.ReadOnly = true;
            this.textBoxEng.Size = new Size(24, 13);
            this.textBoxEng.TabIndex = 28;
            this.textBoxEng.TabStop = false;
            this.textBoxEng.TextAlign = HorizontalAlignment.Right;
            this.textBoxRWing.BorderStyle = BorderStyle.None;
            this.textBoxRWing.Location = new Point(56, 56);
            this.textBoxRWing.Name = "textBoxRWing";
            this.textBoxRWing.ReadOnly = true;
            this.textBoxRWing.Size = new Size(24, 13);
            this.textBoxRWing.TabIndex = 27;
            this.textBoxRWing.TabStop = false;
            this.textBoxRWing.TextAlign = HorizontalAlignment.Right;
            this.label44.Location = new Point(248, 32);
            this.label44.Name = "label44";
            this.label44.Size = new Size(32, 16);
            this.label44.TabIndex = 5;
            this.label44.Text = "Susp";
            this.label43.Location = new Point(152, 32);
            this.label43.Name = "label43";
            this.label43.Size = new Size(40, 16);
            this.label43.TabIndex = 4;
            this.label43.Text = "Brakes";
            this.label42.Location = new Point(104, 32);
            this.label42.Name = "label42";
            this.label42.Size = new Size(40, 16);
            this.label42.TabIndex = 3;
            this.label42.Text = "Engine";
            this.label41.Location = new Point(200, 32);
            this.label41.Name = "label41";
            this.label41.Size = new Size(32, 16);
            this.label41.TabIndex = 2;
            this.label41.Text = "Gear";
            this.label40.Location = new Point(56, 32);
            this.label40.Name = "label40";
            this.label40.Size = new Size(40, 16);
            this.label40.TabIndex = 1;
            this.label40.Text = "RWing";
            this.label29.Location = new Point(8, 32);
            this.label29.Name = "label29";
            this.label29.Size = new Size(40, 16);
            this.label29.TabIndex = 0;
            this.label29.Text = "FWing";
            this.textBoxFWing.BorderStyle = BorderStyle.None;
            this.textBoxFWing.Location = new Point(8, 56);
            this.textBoxFWing.Name = "textBoxFWing";
            this.textBoxFWing.ReadOnly = true;
            this.textBoxFWing.Size = new Size(24, 13);
            this.textBoxFWing.TabIndex = 26;
            this.textBoxFWing.TabStop = false;
            this.textBoxFWing.TextAlign = HorizontalAlignment.Right;
            this.groupBox5.Controls.Add((Control)this.label45);
            this.groupBox5.Controls.Add((Control)this.textBoxStartStrategy);
            this.groupBox5.Controls.Add((Control)this.label36);
            this.groupBox5.Controls.Add((Control)this.label39);
            this.groupBox5.Controls.Add((Control)this.label38);
            this.groupBox5.Controls.Add((Control)this.textBoxPitLimit);
            this.groupBox5.Controls.Add((Control)this.textBoxPitIfSolvableProblem);
            this.groupBox5.Controls.Add((Control)this.checkBoxRefuel);
            this.groupBox5.Controls.Add((Control)this.label37);
            this.groupBox5.Location = new Point(184, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new Size(280, 144);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Orders";
            this.label45.Location = new Point(144, 56);
            this.label45.Name = "label45";
            this.label45.Size = new Size(104, 16);
            this.label45.TabIndex = 38;
            this.label45.Text = "laps are remaining";
            this.textBoxStartStrategy.Location = new Point(80, 112);
            this.textBoxStartStrategy.Name = "textBoxStartStrategy";
            this.textBoxStartStrategy.ReadOnly = true;
            this.textBoxStartStrategy.Size = new Size(128, 20);
            this.textBoxStartStrategy.TabIndex = 37;
            this.label36.Location = new Point(8, 16);
            this.label36.Name = "label36";
            this.label36.Size = new Size(240, 32);
            this.label36.TabIndex = 16;
            this.label36.Text = "If a problem occurs, should the driver pit if the problem can be solved?";
            this.label39.Location = new Point(8, 40);
            this.label39.Name = "label39";
            this.label39.Size = new Size(104, 32);
            this.label39.TabIndex = 19;
            this.label39.Text = "If \"Yes\", then enter pit only if more than ";
            this.label39.TextAlign = ContentAlignment.BottomLeft;
            this.label38.Location = new Point(8, 120);
            this.label38.Name = "label38";
            this.label38.Size = new Size(88, 16);
            this.label38.TabIndex = 18;
            this.label38.Text = "Start Strategy";
            this.textBoxPitLimit.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.textBoxPitLimit.Location = new Point(112, 56);
            this.textBoxPitLimit.Name = "textBoxPitLimit";
            this.textBoxPitLimit.ReadOnly = true;
            this.textBoxPitLimit.Size = new Size(18, 20);
            this.textBoxPitLimit.TabIndex = 36;
            this.textBoxPitLimit.TabStop = false;
            this.textBoxPitLimit.TextAlign = HorizontalAlignment.Right;
            this.textBoxPitIfSolvableProblem.Location = new Point(248, 24);
            this.textBoxPitIfSolvableProblem.Name = "textBoxPitIfSolvableProblem";
            this.textBoxPitIfSolvableProblem.ReadOnly = true;
            this.textBoxPitIfSolvableProblem.Size = new Size(24, 20);
            this.textBoxPitIfSolvableProblem.TabIndex = 36;
            this.textBoxPitIfSolvableProblem.TabStop = false;
            this.checkBoxRefuel.Enabled = false;
            this.checkBoxRefuel.Location = new Point(256, 80);
            this.checkBoxRefuel.Name = "checkBoxRefuel";
            this.checkBoxRefuel.Size = new Size(16, 24);
            this.checkBoxRefuel.TabIndex = 20;
            this.label37.Location = new Point(8, 80);
            this.label37.Name = "label37";
            this.label37.Size = new Size(248, 24);
            this.label37.TabIndex = 17;
            this.label37.Text = "Don't refuel when pitting for a technical problem";
            this.label37.TextAlign = ContentAlignment.MiddleLeft;
            this.groupBox4.Controls.Add((Control)this.textBoxWet);
            this.groupBox4.Controls.Add((Control)this.label132);
            this.groupBox4.Controls.Add((Control)this.textBoxMalfunction);
            this.groupBox4.Controls.Add((Control)this.textBoxDefend);
            this.groupBox4.Controls.Add((Control)this.textBoxClear);
            this.groupBox4.Controls.Add((Control)this.label30);
            this.groupBox4.Controls.Add((Control)this.label33);
            this.groupBox4.Controls.Add((Control)this.label32);
            this.groupBox4.Controls.Add((Control)this.label31);
            this.groupBox4.Controls.Add((Control)this.textBoxOvertake);
            this.groupBox4.Location = new Point(8, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(176, 144);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Risks";
            this.textBoxWet.BorderStyle = BorderStyle.None;
            this.textBoxWet.Location = new Point(144, 100);
            this.textBoxWet.Name = "textBoxWet";
            this.textBoxWet.ReadOnly = true;
            this.textBoxWet.Size = new Size(18, 13);
            this.textBoxWet.TabIndex = 37;
            this.textBoxWet.TabStop = false;
            this.textBoxWet.TextAlign = HorizontalAlignment.Right;
            this.label132.Location = new Point(15, 99);
            this.label132.Name = "label132";
            this.label132.Size = new Size(120, 16);
            this.label132.TabIndex = 36;
            this.label132.Text = "When the track is wet";
            this.textBoxMalfunction.BorderStyle = BorderStyle.None;
            this.textBoxMalfunction.Location = new Point(144, 120);
            this.textBoxMalfunction.Name = "textBoxMalfunction";
            this.textBoxMalfunction.ReadOnly = true;
            this.textBoxMalfunction.Size = new Size(18, 13);
            this.textBoxMalfunction.TabIndex = 35;
            this.textBoxMalfunction.TabStop = false;
            this.textBoxMalfunction.TextAlign = HorizontalAlignment.Right;
            this.textBoxDefend.BorderStyle = BorderStyle.None;
            this.textBoxDefend.Location = new Point(144, 52);
            this.textBoxDefend.Name = "textBoxDefend";
            this.textBoxDefend.ReadOnly = true;
            this.textBoxDefend.Size = new Size(18, 13);
            this.textBoxDefend.TabIndex = 34;
            this.textBoxDefend.TabStop = false;
            this.textBoxDefend.TextAlign = HorizontalAlignment.Right;
            this.textBoxClear.BorderStyle = BorderStyle.None;
            this.textBoxClear.Location = new Point(144, 80);
            this.textBoxClear.Name = "textBoxClear";
            this.textBoxClear.ReadOnly = true;
            this.textBoxClear.Size = new Size(18, 13);
            this.textBoxClear.TabIndex = 33;
            this.textBoxClear.TabStop = false;
            this.textBoxClear.TextAlign = HorizontalAlignment.Right;
            this.label30.Location = new Point(16, 16);
            this.label30.Name = "label30";
            this.label30.Size = new Size(128, 32);
            this.label30.TabIndex = 10;
            this.label30.Text = "When attempting to overtake";
            this.label33.Location = new Point(16, 120);
            this.label33.Name = "label33";
            this.label33.Size = new Size(136, 16);
            this.label33.TabIndex = 13;
            this.label33.Text = "If the car is malfunctioning";
            this.label32.Location = new Point(16, 78);
            this.label32.Name = "label32";
            this.label32.Size = new Size(120, 16);
            this.label32.TabIndex = 12;
            this.label32.Text = "When the track is clear";
            this.label31.Location = new Point(16, 47);
            this.label31.Name = "label31";
            this.label31.Size = new Size(136, 32);
            this.label31.TabIndex = 11;
            this.label31.Text = "When defending his position";
            this.textBoxOvertake.BorderStyle = BorderStyle.None;
            this.textBoxOvertake.Location = new Point(144, 24);
            this.textBoxOvertake.Name = "textBoxOvertake";
            this.textBoxOvertake.ReadOnly = true;
            this.textBoxOvertake.Size = new Size(18, 13);
            this.textBoxOvertake.TabIndex = 32;
            this.textBoxOvertake.TabStop = false;
            this.textBoxOvertake.TextAlign = HorizontalAlignment.Right;
            this.groupBox2.Controls.Add((Control)this.textBoxFuel5);
            this.groupBox2.Controls.Add((Control)this.textBoxFuel4);
            this.groupBox2.Controls.Add((Control)this.textBoxFuel3);
            this.groupBox2.Controls.Add((Control)this.textBoxFuel2);
            this.groupBox2.Controls.Add((Control)this.textBoxFuel1);
            this.groupBox2.Controls.Add((Control)this.label22);
            this.groupBox2.Controls.Add((Control)this.label21);
            this.groupBox2.Controls.Add((Control)this.label20);
            this.groupBox2.Controls.Add((Control)this.label24);
            this.groupBox2.Controls.Add((Control)this.label25);
            this.groupBox2.Controls.Add((Control)this.label23);
            this.groupBox2.Controls.Add((Control)this.textBoxFuel);
            this.groupBox2.Location = new Point(464, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(112, 144);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fuel strategy";
            this.textBoxFuel5.BorderStyle = BorderStyle.None;
            this.textBoxFuel5.Location = new Point(72, 126);
            this.textBoxFuel5.Name = "textBoxFuel5";
            this.textBoxFuel5.ReadOnly = true;
            this.textBoxFuel5.Size = new Size(24, 13);
            this.textBoxFuel5.TabIndex = 25;
            this.textBoxFuel5.TabStop = false;
            this.textBoxFuel5.TextAlign = HorizontalAlignment.Right;
            this.textBoxFuel4.BorderStyle = BorderStyle.None;
            this.textBoxFuel4.Location = new Point(72, 104);
            this.textBoxFuel4.Name = "textBoxFuel4";
            this.textBoxFuel4.ReadOnly = true;
            this.textBoxFuel4.Size = new Size(24, 13);
            this.textBoxFuel4.TabIndex = 24;
            this.textBoxFuel4.TabStop = false;
            this.textBoxFuel4.TextAlign = HorizontalAlignment.Right;
            this.textBoxFuel3.BorderStyle = BorderStyle.None;
            this.textBoxFuel3.Location = new Point(72, 82);
            this.textBoxFuel3.Name = "textBoxFuel3";
            this.textBoxFuel3.ReadOnly = true;
            this.textBoxFuel3.Size = new Size(24, 13);
            this.textBoxFuel3.TabIndex = 23;
            this.textBoxFuel3.TabStop = false;
            this.textBoxFuel3.TextAlign = HorizontalAlignment.Right;
            this.textBoxFuel2.BorderStyle = BorderStyle.None;
            this.textBoxFuel2.Location = new Point(72, 60);
            this.textBoxFuel2.Name = "textBoxFuel2";
            this.textBoxFuel2.ReadOnly = true;
            this.textBoxFuel2.Size = new Size(24, 13);
            this.textBoxFuel2.TabIndex = 22;
            this.textBoxFuel2.TabStop = false;
            this.textBoxFuel2.TextAlign = HorizontalAlignment.Right;
            this.textBoxFuel1.BorderStyle = BorderStyle.None;
            this.textBoxFuel1.Location = new Point(72, 38);
            this.textBoxFuel1.Name = "textBoxFuel1";
            this.textBoxFuel1.ReadOnly = true;
            this.textBoxFuel1.Size = new Size(24, 13);
            this.textBoxFuel1.TabIndex = 21;
            this.textBoxFuel1.TabStop = false;
            this.textBoxFuel1.TextAlign = HorizontalAlignment.Right;
            this.label22.Location = new Point(8, 60);
            this.label22.Name = "label22";
            this.label22.Size = new Size(64, 16);
            this.label22.TabIndex = 2;
            this.label22.Text = "Stop 2 fuel:";
            this.label21.Location = new Point(8, 38);
            this.label21.Name = "label21";
            this.label21.Size = new Size(64, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "Stop 1 fuel:";
            this.label20.Location = new Point(8, 16);
            this.label20.Name = "label20";
            this.label20.Size = new Size(56, 16);
            this.label20.TabIndex = 0;
            this.label20.Text = "Start fuel:";
            this.label24.Location = new Point(8, 104);
            this.label24.Name = "label24";
            this.label24.Size = new Size(64, 16);
            this.label24.TabIndex = 4;
            this.label24.Text = "Stop 4 fuel:";
            this.label25.Location = new Point(8, 126);
            this.label25.Name = "label25";
            this.label25.Size = new Size(64, 16);
            this.label25.TabIndex = 5;
            this.label25.Text = "Stop 5 fuel:";
            this.label23.Location = new Point(8, 82);
            this.label23.Name = "label23";
            this.label23.Size = new Size(64, 16);
            this.label23.TabIndex = 3;
            this.label23.Text = "Stop 3 fuel:";
            this.textBoxFuel.BorderStyle = BorderStyle.None;
            this.textBoxFuel.Location = new Point(72, 16);
            this.textBoxFuel.Name = "textBoxFuel";
            this.textBoxFuel.ReadOnly = true;
            this.textBoxFuel.Size = new Size(24, 13);
            this.textBoxFuel.TabIndex = 20;
            this.textBoxFuel.TabStop = false;
            this.textBoxFuel.TextAlign = HorizontalAlignment.Right;
            this.tabPageWeather.Controls.Add((Control)this.groupBox16);
            this.tabPageWeather.Controls.Add((Control)this.groupBox15);
            this.tabPageWeather.Controls.Add((Control)this.groupBox14);
            this.tabPageWeather.Controls.Add((Control)this.groupBox13);
            this.tabPageWeather.Controls.Add((Control)this.groupBox12);
            this.tabPageWeather.Controls.Add((Control)this.groupBox17);
            this.tabPageWeather.Controls.Add((Control)this.groupBox18);
            this.tabPageWeather.Location = new Point(4, 22);
            this.tabPageWeather.Name = "tabPageWeather";
            this.tabPageWeather.Size = new Size(797, 343);
            this.tabPageWeather.TabIndex = 5;
            this.tabPageWeather.Text = "Forecast";
            this.tabPageWeather.UseVisualStyleBackColor = true;
            this.groupBox16.Controls.Add((Control)this.textBoxPracW);
            this.groupBox16.Controls.Add((Control)this.label89);
            this.groupBox16.Controls.Add((Control)this.textBoxPracT);
            this.groupBox16.Controls.Add((Control)this.textBoxPracH);
            this.groupBox16.Controls.Add((Control)this.label90);
            this.groupBox16.Controls.Add((Control)this.label91);
            this.groupBox16.Location = new Point(8, 24);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new Size(176, 96);
            this.groupBox16.TabIndex = 4;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Practice / Qualify1";
            this.textBoxPracW.BorderStyle = BorderStyle.None;
            this.textBoxPracW.Location = new Point(96, 72);
            this.textBoxPracW.Name = "textBoxPracW";
            this.textBoxPracW.ReadOnly = true;
            this.textBoxPracW.Size = new Size(72, 13);
            this.textBoxPracW.TabIndex = 7;
            this.label89.Location = new Point(8, 72);
            this.label89.Name = "label89";
            this.label89.Size = new Size(88, 16);
            this.label89.TabIndex = 6;
            this.label89.Text = "Weather:";
            this.textBoxPracT.BorderStyle = BorderStyle.None;
            this.textBoxPracT.Location = new Point(96, 24);
            this.textBoxPracT.Name = "textBoxPracT";
            this.textBoxPracT.ReadOnly = true;
            this.textBoxPracT.Size = new Size(72, 13);
            this.textBoxPracT.TabIndex = 5;
            this.textBoxPracH.BorderStyle = BorderStyle.None;
            this.textBoxPracH.Location = new Point(96, 44);
            this.textBoxPracH.Name = "textBoxPracH";
            this.textBoxPracH.ReadOnly = true;
            this.textBoxPracH.Size = new Size(72, 13);
            this.textBoxPracH.TabIndex = 4;
            this.label90.Location = new Point(8, 48);
            this.label90.Name = "label90";
            this.label90.Size = new Size(72, 16);
            this.label90.TabIndex = 1;
            this.label90.Text = "Humidity:";
            this.label91.Location = new Point(8, 24);
            this.label91.Name = "label91";
            this.label91.Size = new Size(72, 16);
            this.label91.TabIndex = 0;
            this.label91.Text = "Temp:";
            this.groupBox15.Controls.Add((Control)this.textBoxForecast4t);
            this.groupBox15.Controls.Add((Control)this.textBoxForecast4h);
            this.groupBox15.Controls.Add((Control)this.textBoxForecast4r);
            this.groupBox15.Controls.Add((Control)this.label86);
            this.groupBox15.Controls.Add((Control)this.label87);
            this.groupBox15.Controls.Add((Control)this.label88);
            this.groupBox15.Location = new Point(384, 136);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new Size(176, 96);
            this.groupBox15.TabIndex = 3;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "1h30m - 2h00m";
            this.textBoxForecast4t.BorderStyle = BorderStyle.None;
            this.textBoxForecast4t.Location = new Point(96, 24);
            this.textBoxForecast4t.Name = "textBoxForecast4t";
            this.textBoxForecast4t.ReadOnly = true;
            this.textBoxForecast4t.Size = new Size(72, 13);
            this.textBoxForecast4t.TabIndex = 5;
            this.textBoxForecast4h.BorderStyle = BorderStyle.None;
            this.textBoxForecast4h.Location = new Point(96, 44);
            this.textBoxForecast4h.Name = "textBoxForecast4h";
            this.textBoxForecast4h.ReadOnly = true;
            this.textBoxForecast4h.Size = new Size(72, 13);
            this.textBoxForecast4h.TabIndex = 4;
            this.textBoxForecast4r.BorderStyle = BorderStyle.None;
            this.textBoxForecast4r.Location = new Point(96, 72);
            this.textBoxForecast4r.Name = "textBoxForecast4r";
            this.textBoxForecast4r.ReadOnly = true;
            this.textBoxForecast4r.Size = new Size(72, 13);
            this.textBoxForecast4r.TabIndex = 3;
            this.label86.Location = new Point(8, 72);
            this.label86.Name = "label86";
            this.label86.Size = new Size(88, 16);
            this.label86.TabIndex = 2;
            this.label86.Text = "Rain Probability:";
            this.label87.Location = new Point(8, 48);
            this.label87.Name = "label87";
            this.label87.Size = new Size(72, 16);
            this.label87.TabIndex = 1;
            this.label87.Text = "Humidity:";
            this.label88.Location = new Point(8, 24);
            this.label88.Name = "label88";
            this.label88.Size = new Size(72, 16);
            this.label88.TabIndex = 0;
            this.label88.Text = "Temp:";
            this.groupBox14.Controls.Add((Control)this.textBoxForecast3t);
            this.groupBox14.Controls.Add((Control)this.textBoxForecast3h);
            this.groupBox14.Controls.Add((Control)this.textBoxForecast3r);
            this.groupBox14.Controls.Add((Control)this.label83);
            this.groupBox14.Controls.Add((Control)this.label84);
            this.groupBox14.Controls.Add((Control)this.label85);
            this.groupBox14.Location = new Point(200, 136);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new Size(176, 96);
            this.groupBox14.TabIndex = 2;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "1h00m - 1h30m";
            this.textBoxForecast3t.BorderStyle = BorderStyle.None;
            this.textBoxForecast3t.Location = new Point(96, 24);
            this.textBoxForecast3t.Name = "textBoxForecast3t";
            this.textBoxForecast3t.ReadOnly = true;
            this.textBoxForecast3t.Size = new Size(72, 13);
            this.textBoxForecast3t.TabIndex = 5;
            this.textBoxForecast3h.BorderStyle = BorderStyle.None;
            this.textBoxForecast3h.Location = new Point(96, 44);
            this.textBoxForecast3h.Name = "textBoxForecast3h";
            this.textBoxForecast3h.ReadOnly = true;
            this.textBoxForecast3h.Size = new Size(72, 13);
            this.textBoxForecast3h.TabIndex = 4;
            this.textBoxForecast3r.BorderStyle = BorderStyle.None;
            this.textBoxForecast3r.Location = new Point(96, 72);
            this.textBoxForecast3r.Name = "textBoxForecast3r";
            this.textBoxForecast3r.ReadOnly = true;
            this.textBoxForecast3r.Size = new Size(72, 13);
            this.textBoxForecast3r.TabIndex = 3;
            this.label83.Location = new Point(8, 72);
            this.label83.Name = "label83";
            this.label83.Size = new Size(88, 16);
            this.label83.TabIndex = 2;
            this.label83.Text = "Rain Probability:";
            this.label84.Location = new Point(8, 48);
            this.label84.Name = "label84";
            this.label84.Size = new Size(72, 16);
            this.label84.TabIndex = 1;
            this.label84.Text = "Humidity:";
            this.label85.Location = new Point(8, 24);
            this.label85.Name = "label85";
            this.label85.Size = new Size(72, 16);
            this.label85.TabIndex = 0;
            this.label85.Text = "Temp:";
            this.groupBox13.Controls.Add((Control)this.textBoxForecast2t);
            this.groupBox13.Controls.Add((Control)this.textBoxForecast2h);
            this.groupBox13.Controls.Add((Control)this.textBoxForecast2r);
            this.groupBox13.Controls.Add((Control)this.label80);
            this.groupBox13.Controls.Add((Control)this.label81);
            this.groupBox13.Controls.Add((Control)this.label82);
            this.groupBox13.Location = new Point(384, 32);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new Size(176, 96);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = " 0h30m - 1h00m";
            this.textBoxForecast2t.BorderStyle = BorderStyle.None;
            this.textBoxForecast2t.Location = new Point(96, 24);
            this.textBoxForecast2t.Name = "textBoxForecast2t";
            this.textBoxForecast2t.ReadOnly = true;
            this.textBoxForecast2t.Size = new Size(72, 13);
            this.textBoxForecast2t.TabIndex = 5;
            this.textBoxForecast2h.BorderStyle = BorderStyle.None;
            this.textBoxForecast2h.Location = new Point(96, 44);
            this.textBoxForecast2h.Name = "textBoxForecast2h";
            this.textBoxForecast2h.ReadOnly = true;
            this.textBoxForecast2h.Size = new Size(72, 13);
            this.textBoxForecast2h.TabIndex = 4;
            this.textBoxForecast2r.BorderStyle = BorderStyle.None;
            this.textBoxForecast2r.Location = new Point(96, 72);
            this.textBoxForecast2r.Name = "textBoxForecast2r";
            this.textBoxForecast2r.ReadOnly = true;
            this.textBoxForecast2r.Size = new Size(72, 13);
            this.textBoxForecast2r.TabIndex = 3;
            this.label80.Location = new Point(8, 72);
            this.label80.Name = "label80";
            this.label80.Size = new Size(88, 16);
            this.label80.TabIndex = 2;
            this.label80.Text = "Rain Probability:";
            this.label81.Location = new Point(8, 48);
            this.label81.Name = "label81";
            this.label81.Size = new Size(72, 16);
            this.label81.TabIndex = 1;
            this.label81.Text = "Humidity:";
            this.label82.Location = new Point(8, 24);
            this.label82.Name = "label82";
            this.label82.Size = new Size(72, 16);
            this.label82.TabIndex = 0;
            this.label82.Text = "Temp:";
            this.groupBox12.Controls.Add((Control)this.textBoxForecast1t);
            this.groupBox12.Controls.Add((Control)this.textBoxForecast1h);
            this.groupBox12.Controls.Add((Control)this.textBoxForecast1r);
            this.groupBox12.Controls.Add((Control)this.label79);
            this.groupBox12.Controls.Add((Control)this.label78);
            this.groupBox12.Controls.Add((Control)this.label77);
            this.groupBox12.Location = new Point(200, 32);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new Size(176, 96);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Start - 0h30m";
            this.textBoxForecast1t.BorderStyle = BorderStyle.None;
            this.textBoxForecast1t.Location = new Point(96, 24);
            this.textBoxForecast1t.Name = "textBoxForecast1t";
            this.textBoxForecast1t.ReadOnly = true;
            this.textBoxForecast1t.Size = new Size(72, 13);
            this.textBoxForecast1t.TabIndex = 5;
            this.textBoxForecast1h.BorderStyle = BorderStyle.None;
            this.textBoxForecast1h.Location = new Point(96, 44);
            this.textBoxForecast1h.Name = "textBoxForecast1h";
            this.textBoxForecast1h.ReadOnly = true;
            this.textBoxForecast1h.Size = new Size(72, 13);
            this.textBoxForecast1h.TabIndex = 4;
            this.textBoxForecast1r.BorderStyle = BorderStyle.None;
            this.textBoxForecast1r.Location = new Point(96, 72);
            this.textBoxForecast1r.Name = "textBoxForecast1r";
            this.textBoxForecast1r.ReadOnly = true;
            this.textBoxForecast1r.Size = new Size(72, 13);
            this.textBoxForecast1r.TabIndex = 3;
            this.label79.Location = new Point(8, 72);
            this.label79.Name = "label79";
            this.label79.Size = new Size(88, 16);
            this.label79.TabIndex = 2;
            this.label79.Text = "Rain Probability:";
            this.label78.Location = new Point(8, 48);
            this.label78.Name = "label78";
            this.label78.Size = new Size(72, 16);
            this.label78.TabIndex = 1;
            this.label78.Text = "Humidity:";
            this.label77.Location = new Point(8, 24);
            this.label77.Name = "label77";
            this.label77.Size = new Size(72, 16);
            this.label77.TabIndex = 0;
            this.label77.Text = "Temp:";
            this.groupBox17.Controls.Add((Control)this.textBoxQualW);
            this.groupBox17.Controls.Add((Control)this.label92);
            this.groupBox17.Controls.Add((Control)this.textBoxQualT);
            this.groupBox17.Controls.Add((Control)this.textBoxQualH);
            this.groupBox17.Controls.Add((Control)this.label93);
            this.groupBox17.Controls.Add((Control)this.label94);
            this.groupBox17.Location = new Point(8, 136);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new Size(176, 96);
            this.groupBox17.TabIndex = 8;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Qualify2";
            this.textBoxQualW.BorderStyle = BorderStyle.None;
            this.textBoxQualW.Location = new Point(96, 72);
            this.textBoxQualW.Name = "textBoxQualW";
            this.textBoxQualW.ReadOnly = true;
            this.textBoxQualW.Size = new Size(72, 13);
            this.textBoxQualW.TabIndex = 7;
            this.label92.Location = new Point(8, 72);
            this.label92.Name = "label92";
            this.label92.Size = new Size(88, 16);
            this.label92.TabIndex = 6;
            this.label92.Text = "Weather:";
            this.textBoxQualT.BorderStyle = BorderStyle.None;
            this.textBoxQualT.Location = new Point(96, 24);
            this.textBoxQualT.Name = "textBoxQualT";
            this.textBoxQualT.ReadOnly = true;
            this.textBoxQualT.Size = new Size(72, 13);
            this.textBoxQualT.TabIndex = 5;
            this.textBoxQualH.BorderStyle = BorderStyle.None;
            this.textBoxQualH.Location = new Point(96, 44);
            this.textBoxQualH.Name = "textBoxQualH";
            this.textBoxQualH.ReadOnly = true;
            this.textBoxQualH.Size = new Size(72, 13);
            this.textBoxQualH.TabIndex = 4;
            this.label93.Location = new Point(8, 48);
            this.label93.Name = "label93";
            this.label93.Size = new Size(72, 16);
            this.label93.TabIndex = 1;
            this.label93.Text = "Humidity:";
            this.label94.Location = new Point(8, 24);
            this.label94.Name = "label94";
            this.label94.Size = new Size(72, 16);
            this.label94.TabIndex = 0;
            this.label94.Text = "Temp:";
            this.groupBox18.Location = new Point(192, 8);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new Size(376, 232);
            this.groupBox18.TabIndex = 9;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Race forecast";
            this.tabPageFinance.Controls.Add((Control)this.listViewFinance);
            this.tabPageFinance.Location = new Point(4, 22);
            this.tabPageFinance.Name = "tabPageFinance";
            this.tabPageFinance.Size = new Size(797, 343);
            this.tabPageFinance.TabIndex = 7;
            this.tabPageFinance.Text = "Finances";
            this.tabPageFinance.UseVisualStyleBackColor = true;
            this.listViewFinance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.listViewFinance.Columns.AddRange(new ColumnHeader[5]
            {
        this.columnHeader17,
        this.columnHeader18,
        this.columnHeader19,
        this.columnHeader20,
        this.columnHeader21
            });
            this.listViewFinance.FullRowSelect = true;
            this.listViewFinance.HideSelection = false;
            this.listViewFinance.Location = new Point(-4, 4);
            this.listViewFinance.Name = "listViewFinance";
            this.listViewFinance.Size = new Size(801, 337);
            this.listViewFinance.TabIndex = 0;
            this.listViewFinance.UseCompatibleStateImageBehavior = false;
            this.listViewFinance.View = View.Details;
            this.columnHeader17.Text = "Date and time";
            this.columnHeader17.Width = 109;
            this.columnHeader18.Text = "Transaction description";
            this.columnHeader18.Width = 209;
            this.columnHeader19.Text = "Balance before";
            this.columnHeader19.TextAlign = HorizontalAlignment.Right;
            this.columnHeader19.Width = 85;
            this.columnHeader20.Text = "Amount";
            this.columnHeader20.TextAlign = HorizontalAlignment.Right;
            this.columnHeader20.Width = 81;
            this.columnHeader21.Text = "Balance after";
            this.columnHeader21.TextAlign = HorizontalAlignment.Right;
            this.columnHeader21.Width = 81;
            this.tabPageTyreSupplier.Controls.Add((Control)this.groupBox11);
            this.tabPageTyreSupplier.Location = new Point(4, 22);
            this.tabPageTyreSupplier.Name = "tabPageTyreSupplier";
            this.tabPageTyreSupplier.Padding = new Padding(3);
            this.tabPageTyreSupplier.Size = new Size(797, 343);
            this.tabPageTyreSupplier.TabIndex = 11;
            this.tabPageTyreSupplier.Text = "Tyre Supplier";
            this.tabPageTyreSupplier.UseVisualStyleBackColor = true;
            this.groupBox11.Controls.Add((Control)this.textBoxWarmupDistance);
            this.groupBox11.Controls.Add((Control)this.textBoxDurability);
            this.groupBox11.Controls.Add((Control)this.textBoxPeakTemperature);
            this.groupBox11.Controls.Add((Control)this.textBoxWetPerformance);
            this.groupBox11.Controls.Add((Control)this.textBoxDryPerformance);
            this.groupBox11.Controls.Add((Control)this.label76);
            this.groupBox11.Controls.Add((Control)this.label75);
            this.groupBox11.Controls.Add((Control)this.label74);
            this.groupBox11.Controls.Add((Control)this.label73);
            this.groupBox11.Controls.Add((Control)this.label72);
            this.groupBox11.Location = new Point(6, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new Size(196, 148);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Tyre Supplier";
            this.textBoxWarmupDistance.Location = new Point(148, 116);
            this.textBoxWarmupDistance.Name = "textBoxWarmupDistance";
            this.textBoxWarmupDistance.ReadOnly = true;
            this.textBoxWarmupDistance.Size = new Size(25, 20);
            this.textBoxWarmupDistance.TabIndex = 10;
            this.textBoxDurability.Location = new Point(148, 92);
            this.textBoxDurability.Name = "textBoxDurability";
            this.textBoxDurability.ReadOnly = true;
            this.textBoxDurability.Size = new Size(25, 20);
            this.textBoxDurability.TabIndex = 9;
            this.textBoxPeakTemperature.Location = new Point(148, 68);
            this.textBoxPeakTemperature.Name = "textBoxPeakTemperature";
            this.textBoxPeakTemperature.ReadOnly = true;
            this.textBoxPeakTemperature.Size = new Size(25, 20);
            this.textBoxPeakTemperature.TabIndex = 8;
            this.textBoxWetPerformance.Location = new Point(148, 44);
            this.textBoxWetPerformance.Name = "textBoxWetPerformance";
            this.textBoxWetPerformance.ReadOnly = true;
            this.textBoxWetPerformance.Size = new Size(25, 20);
            this.textBoxWetPerformance.TabIndex = 7;
            this.textBoxDryPerformance.Location = new Point(148, 20);
            this.textBoxDryPerformance.Name = "textBoxDryPerformance";
            this.textBoxDryPerformance.ReadOnly = true;
            this.textBoxDryPerformance.Size = new Size(25, 20);
            this.textBoxDryPerformance.TabIndex = 6;
            this.label76.AutoSize = true;
            this.label76.Location = new Point(16, 51);
            this.label76.Name = "label76";
            this.label76.Size = new Size(93, 13);
            this.label76.TabIndex = 5;
            this.label76.Text = "Wet Performance:";
            this.label75.AutoSize = true;
            this.label75.Location = new Point(16, 75);
            this.label75.Name = "label75";
            this.label75.Size = new Size(98, 13);
            this.label75.TabIndex = 4;
            this.label75.Text = "Peak Temperature:";
            this.label74.AutoSize = true;
            this.label74.Location = new Point(16, 99);
            this.label74.Name = "label74";
            this.label74.Size = new Size(53, 13);
            this.label74.TabIndex = 3;
            this.label74.Text = "Durability:";
            this.label73.AutoSize = true;
            this.label73.Location = new Point(16, 123);
            this.label73.Name = "label73";
            this.label73.Size = new Size(95, 13);
            this.label73.TabIndex = 2;
            this.label73.Text = "Warmup Distance:";
            this.label72.AutoSize = true;
            this.label72.Location = new Point(16, 27);
            this.label72.Name = "label72";
            this.label72.Size = new Size(89, 13);
            this.label72.TabIndex = 1;
            this.label72.Text = "Dry Performance:";
            this.tabPageSponsor.Controls.Add((Control)this.groupBox30);
            this.tabPageSponsor.Controls.Add((Control)this.groupBox29);
            this.tabPageSponsor.Location = new Point(4, 22);
            this.tabPageSponsor.Name = "tabPageSponsor";
            this.tabPageSponsor.Padding = new Padding(3);
            this.tabPageSponsor.Size = new Size(797, 343);
            this.tabPageSponsor.TabIndex = 12;
            this.tabPageSponsor.Text = "Sponsor";
            this.tabPageSponsor.UseVisualStyleBackColor = true;
            this.groupBox30.Controls.Add((Control)this.listViewOngoingSponsorNegotiations);
            this.groupBox30.Location = new Point(21, 170);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new Size(768, 167);
            this.groupBox30.TabIndex = 1;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Ongoing negotiations";
            this.listViewOngoingSponsorNegotiations.Columns.AddRange(new ColumnHeader[6]
            {
        this.columnHeader45,
        this.columnHeader46,
        this.columnHeader47,
        this.columnHeader48,
        this.columnHeader49,
        this.columnHeader50
            });
            this.listViewOngoingSponsorNegotiations.HideSelection = false;
            this.listViewOngoingSponsorNegotiations.Location = new Point(6, 19);
            this.listViewOngoingSponsorNegotiations.Name = "listViewOngoingSponsorNegotiations";
            this.listViewOngoingSponsorNegotiations.Size = new Size(756, 142);
            this.listViewOngoingSponsorNegotiations.TabIndex = 1;
            this.listViewOngoingSponsorNegotiations.UseCompatibleStateImageBehavior = false;
            this.listViewOngoingSponsorNegotiations.View = View.Details;
            this.columnHeader45.Text = "Sponsor name";
            this.columnHeader45.Width = 134;
            this.columnHeader46.Text = "Car spot";
            this.columnHeader46.Width = 84;
            this.columnHeader47.Text = "Amount per race";
            this.columnHeader47.Width = 113;
            this.columnHeader48.Text = "Duration";
            this.columnHeader48.Width = 116;
            this.columnHeader49.Text = "Progress";
            this.columnHeader49.Width = 109;
            this.columnHeader50.Text = "Priority";
            this.columnHeader50.Width = 113;
            this.groupBox29.Controls.Add((Control)this.listViewOngoingSponsorContracts);
            this.groupBox29.Location = new Point(21, 18);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new Size(548, 131);
            this.groupBox29.TabIndex = 0;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Ongoing contracts";
            this.listViewOngoingSponsorContracts.Columns.AddRange(new ColumnHeader[5]
            {
        this.columnHeader12,
        this.columnHeader29,
        this.columnHeader42,
        this.columnHeader43,
        this.columnHeader44
            });
            this.listViewOngoingSponsorContracts.HideSelection = false;
            this.listViewOngoingSponsorContracts.Location = new Point(6, 19);
            this.listViewOngoingSponsorContracts.Name = "listViewOngoingSponsorContracts";
            this.listViewOngoingSponsorContracts.Size = new Size(536, 106);
            this.listViewOngoingSponsorContracts.TabIndex = 0;
            this.listViewOngoingSponsorContracts.UseCompatibleStateImageBehavior = false;
            this.listViewOngoingSponsorContracts.View = View.Details;
            this.columnHeader12.Text = "Sponsor name";
            this.columnHeader12.Width = 134;
            this.columnHeader29.Text = "Car spot";
            this.columnHeader29.Width = 84;
            this.columnHeader42.Text = "Amount per race";
            this.columnHeader42.Width = 113;
            this.columnHeader43.Text = "Contract status";
            this.columnHeader43.Width = 116;
            this.columnHeader44.Text = "Races left";
            this.columnHeader44.Width = 85;
            this.notifyIconGO.ContextMenuStrip = this.contextMenuNotification;
            this.notifyIconGO.Icon = Resources.Resources.Car;
            this.notifyIconGO.Text = "GPRO Organizer";
            this.notifyIconGO.MouseDoubleClick += new MouseEventHandler(this.notifyIconGO_MouseDoubleClick);
            this.contextMenuNotification.Items.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.menuItemNotificationOpen,
        (ToolStripItem) this.menuItemNotificationUpdateAll,
        (ToolStripItem) this.menuItemNotificationExit
            });
            this.contextMenuNotification.Name = "contextMenuNotification";
            this.contextMenuNotification.Size = new Size(157, 70);
            this.menuItemNotificationOpen.Name = "menuItemNotificationOpen";
            this.menuItemNotificationOpen.Size = new Size(156, 22);
            this.menuItemNotificationOpen.Text = "Open";
            this.menuItemNotificationOpen.Click += new EventHandler(this.menuItemNotificationOpen_Click);
            this.menuItemNotificationUpdateAll.Name = "menuItemNotificationUpdateAll";
            this.menuItemNotificationUpdateAll.Size = new Size(156, 22);
            this.menuItemNotificationUpdateAll.Text = "Update All Data";
            this.menuItemNotificationUpdateAll.Click += new EventHandler(this.MniParseAllDatas);
            this.menuItemNotificationExit.Name = "menuItemNotificationExit";
            this.menuItemNotificationExit.Size = new Size(156, 22);
            this.menuItemNotificationExit.Text = "E&xit";
            this.menuItemNotificationExit.Click += new EventHandler(this.mniExitClick);
            this.AutoScaleBaseSize = new Size(5, 13);
            this.ClientSize = new Size(813, 405);
            this.Controls.Add((Control)this.statusBar1);
            this.Controls.Add((Control)this.tabControl1);
            this.Icon = Resources.Resources.Car;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimumSize = new Size(610, 360);
            this.Name = "Form1";
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "GPRO Organizer";
            this.Closing += new CancelEventHandler(this.Form1Closing);
            this.KeyUp += new KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new EventHandler(this.Form1_Resize);
            this.statusBarPanel1.EndInit();
            this.statusBarPanel2.EndInit();
            this.statusBarPanel3.EndInit();
            this.statusBarPanelVersion.EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageDriver.ResumeLayout(false);
            this.tabPageDriver.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPageTechnicalDirector.ResumeLayout(false);
            this.tabPageTechnicalDirector.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.tabPageCar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageStaff.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.tabPageSeason.ResumeLayout(false);
            this.tabPageTesting.ResumeLayout(false);
            this.tabPageTesting.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.tabPagePractice.ResumeLayout(false);
            this.tabPagePractice.PerformLayout();
            this.tabPageQualify.ResumeLayout(false);
            this.groupQualify2.ResumeLayout(false);
            this.groupQualify1.ResumeLayout(false);
            this.tabPageStrategy.ResumeLayout(false);
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageWeather.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.tabPageFinance.ResumeLayout(false);
            this.tabPageTyreSupplier.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPageSponsor.ResumeLayout(false);
            this.groupBox30.ResumeLayout(false);
            this.groupBox29.ResumeLayout(false);
            this.contextMenuNotification.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private static void SetDefaultCulture()
        {
            var culture = CultureInfo.GetCultureInfo("en-US");
            //Culture for any thread
            CultureInfo.DefaultThreadCurrentCulture = culture;
            //Culture for UI in any thread
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }

        //protected override void OnActivated(EventArgs e)
        //{
        //    base.OnActivated(e);
        //}

        private void MniAllTracksClick(object sender, EventArgs e)
        {
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.AppStarting;
            try
            {
                this.CheckComms();
                Datas.Tracks = TrackParser.GetAllTracks();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Binder = (SerializationBinder)new TypeBinder();
                Stream serializationStream = (Stream)new FileStream("tracks.dat", FileMode.Create, FileAccess.Write, FileShare.None);
                binaryFormatter.Serialize(serializationStream, (object)Datas.Tracks);
                serializationStream.Close();
                int num = (int)MessageBox.Show((IWin32Window)this, "To enable the new tracks you must restart GO", "Restart GO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("button1_click: " + ex.Message);
            }
            Cursor.Current = current;
        }

        private void SaveData()
        {
            this.SaveData(this.GetDefaultFileName());
            Datas.FormHandler.Save();
        }

        private void SaveData(string filename)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Binder = (SerializationBinder)new TypeBinder();
            this.SaveRegistrySettings();
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GO");
            if (System.IO.File.Exists(filename))
                System.IO.File.Copy(filename, filename.Replace(".dat", ".bak"), true);
            string tempFileName = Path.GetTempFileName();
            Stream serializationStream = (Stream)new FileStream(tempFileName, FileMode.Create, FileAccess.Write, FileShare.None);
            binaryFormatter.Serialize(serializationStream, (object)13);
            binaryFormatter.Serialize(serializationStream, (object)20);
            binaryFormatter.Serialize(serializationStream, (object)Datas.Communications.managerName);
            binaryFormatter.Serialize(serializationStream, (object)Datas.Communications.teamName);
            binaryFormatter.Serialize(serializationStream, (object)Datas.Date);
            binaryFormatter.Serialize(serializationStream, (object)2);
            binaryFormatter.Serialize(serializationStream, (object)Datas.Car);
            binaryFormatter.Serialize(serializationStream, (object)5);
            binaryFormatter.Serialize(serializationStream, (object)Datas.Driver);
            binaryFormatter.Serialize(serializationStream, (object)2);
            binaryFormatter.Serialize(serializationStream, (object)Datas.CarHistory);
            binaryFormatter.Serialize(serializationStream, (object)4);
            binaryFormatter.Serialize(serializationStream, (object)Datas.OldDrivers);
            binaryFormatter.Serialize(serializationStream, (object)21);
            binaryFormatter.Serialize(serializationStream, (object)Datas.Seasons);
            binaryFormatter.Serialize(serializationStream, (object)1);
            binaryFormatter.Serialize(serializationStream, (object)Datas.TrackNotes);
            binaryFormatter.Serialize(serializationStream, (object)1);
            binaryFormatter.Serialize(serializationStream, (object)Datas.FinanceHistory);
            binaryFormatter.Serialize(serializationStream, (object)1);
            binaryFormatter.Serialize(serializationStream, (object)Datas.Staff);
            binaryFormatter.Serialize(serializationStream, (object)1);
            binaryFormatter.Serialize(serializationStream, (object)Datas.StaffHistory);
            binaryFormatter.Serialize(serializationStream, (object)1);
            binaryFormatter.Serialize(serializationStream, (object)Datas.TechnicalDirector);
            binaryFormatter.Serialize(serializationStream, (object)1);
            binaryFormatter.Serialize(serializationStream, (object)Datas.OldTechnicalDirectors);
            binaryFormatter.Serialize(serializationStream, (object)1);
            binaryFormatter.Serialize(serializationStream, (object)Datas.Manager);
            binaryFormatter.Serialize(serializationStream, (object)Datas.WarnWrongTyres);
            serializationStream.Close();
            System.IO.File.Copy(tempFileName, filename, true);
            System.IO.File.Delete(tempFileName);
            this.statusBarPanel3.Text = "data saved";
            this.DataNotChanged();
        }

        private void LoadTracks()
        {
            UpdateStatusBarText("Loading Tracks");

            try
            {
                var binaryFormatter = new BinaryFormatter
                {
                    Binder = (SerializationBinder) new TypeBinder()
                };
                Stream serializationStream =
                    (Stream) new FileStream("tracks.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
                Datas.Tracks = (Track[]) binaryFormatter.Deserialize(serializationStream);
                serializationStream.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (Datas.Tracks == null)
            {
                Datas.Tracks = TrackParser.GetAllTracks();
            }

            Datas.TrackNotes = new string[Datas.Tracks.Length];

            UpdateStatusBarText("Tracks loaded");
        }

        private void UpdateStatusBarText(string text)
        {
            this.statusBarPanel3.Text = text;
        }

        private Stream GetGoFile(string filename)
        {
            string path = Path.Combine(Application.StartupPath, filename);

            if (!File.Exists(path))
            {
                Console.WriteLine($"[OPTIONAL FILE MISSING] {path}");
                return null;
            }

            Console.WriteLine($"[FILE LOAD] {path}");

            return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        }

        private string GetDefaultFileName()
        {
            return Datas.KeepDataWithApp ? "go.dat" : Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GO\\go.dat";
        }

        private void LoadData() => this.LoadData(this.GetDefaultFileName());

        private void LoadData(string filename)
        {
            UpdateStatusBarText("Loading Data");

            Datas.InitialiseInternalvariables();
            IFormatter formatter = (IFormatter)new BinaryFormatter()
            {
                Binder = (SerializationBinder)new TypeBinder()
            };
            Stream goFile = this.GetGoFile(filename);
            if (goFile == null)
            {
                Datas.Seasons = new List<Season20>();
            }
            else
            {
                try
                {
                    int num1 = (int)formatter.Deserialize(goFile);
                    string managerName = "";
                    string teamName = "";
                    Loader loader = new Loader();
                    WireCommunication();
                    int num2;
                    switch (num1)
                    {
                        case 7:
                            num2 = (int)formatter.Deserialize(goFile);
                            Datas.Date = (Date)formatter.Deserialize(goFile);
                            int version1 = (int)formatter.Deserialize(goFile);
                            Datas.Car = loader.LoadCar(ref goFile, ref formatter, version1);
                            int version2 = (int)formatter.Deserialize(goFile);
                            Datas.Driver = loader.LoadDriver(ref goFile, ref formatter, version2);
                            int version3 = (int)formatter.Deserialize(goFile);
                            Datas.CarHistory = loader.LoadCarHistory(ref goFile, ref formatter, version3);
                            int version4 = (int)formatter.Deserialize(goFile);
                            Datas.OldDrivers = loader.LoadOldDrivers(ref goFile, ref formatter, version4);
                            int version5 = (int)formatter.Deserialize(goFile);
                            Datas.Seasons = loader.LoadSeasons(ref goFile, ref formatter, version5);
                            int version6 = (int)formatter.Deserialize(goFile);
                            Datas.TrackNotes = loader.LoadTrackNotes(ref goFile, ref formatter, version6, Datas.Tracks.Length);
                            break;
                        case 8:
                            num2 = (int)formatter.Deserialize(goFile);
                            Datas.Date = (Date)formatter.Deserialize(goFile);
                            int version7 = (int)formatter.Deserialize(goFile);
                            Datas.Car = loader.LoadCar(ref goFile, ref formatter, version7);
                            int version8 = (int)formatter.Deserialize(goFile);
                            Datas.Driver = loader.LoadDriver(ref goFile, ref formatter, version8);
                            int version9 = (int)formatter.Deserialize(goFile);
                            Datas.CarHistory = loader.LoadCarHistory(ref goFile, ref formatter, version9);
                            int version10 = (int)formatter.Deserialize(goFile);
                            Datas.OldDrivers = loader.LoadOldDrivers(ref goFile, ref formatter, version10);
                            int version11 = (int)formatter.Deserialize(goFile);
                            Datas.Seasons = loader.LoadSeasons(ref goFile, ref formatter, version11);
                            int version12 = (int)formatter.Deserialize(goFile);
                            Datas.TrackNotes = loader.LoadTrackNotes(ref goFile, ref formatter, version12, Datas.Tracks.Length);
                            int version13 = (int)formatter.Deserialize(goFile);
                            Datas.FinanceHistory = loader.LoadFinacialHistory(ref goFile, ref formatter, version13);
                            break;
                        case 9:
                            num2 = (int)formatter.Deserialize(goFile);
                            managerName = (string)formatter.Deserialize(goFile);
                            teamName = (string)formatter.Deserialize(goFile);
                            Datas.Date = (Date)formatter.Deserialize(goFile);
                            int version14 = (int)formatter.Deserialize(goFile);
                            Datas.Car = loader.LoadCar(ref goFile, ref formatter, version14);
                            int version15 = (int)formatter.Deserialize(goFile);
                            Datas.Driver = loader.LoadDriver(ref goFile, ref formatter, version15);
                            int version16 = (int)formatter.Deserialize(goFile);
                            Datas.CarHistory = loader.LoadCarHistory(ref goFile, ref formatter, version16);
                            int version17 = (int)formatter.Deserialize(goFile);
                            Datas.OldDrivers = loader.LoadOldDrivers(ref goFile, ref formatter, version17);
                            int version18 = (int)formatter.Deserialize(goFile);
                            Datas.Seasons = loader.LoadSeasons(ref goFile, ref formatter, version18);
                            int version19 = (int)formatter.Deserialize(goFile);
                            Datas.TrackNotes = loader.LoadTrackNotes(ref goFile, ref formatter, version19, Datas.Tracks.Length);
                            int version20 = (int)formatter.Deserialize(goFile);
                            Datas.FinanceHistory = loader.LoadFinacialHistory(ref goFile, ref formatter, version20);
                            break;
                        case 10:
                            num2 = (int)formatter.Deserialize(goFile);
                            managerName = (string)formatter.Deserialize(goFile);
                            teamName = (string)formatter.Deserialize(goFile);
                            Datas.Date = (Date)formatter.Deserialize(goFile);
                            int version21 = (int)formatter.Deserialize(goFile);
                            Datas.Car = loader.LoadCar(ref goFile, ref formatter, version21);
                            int version22 = (int)formatter.Deserialize(goFile);
                            Datas.Driver = loader.LoadDriver(ref goFile, ref formatter, version22);
                            int version23 = (int)formatter.Deserialize(goFile);
                            Datas.CarHistory = loader.LoadCarHistory(ref goFile, ref formatter, version23);
                            int version24 = (int)formatter.Deserialize(goFile);
                            Datas.OldDrivers = loader.LoadOldDrivers(ref goFile, ref formatter, version24);
                            int version25 = (int)formatter.Deserialize(goFile);
                            Datas.Seasons = loader.LoadSeasons(ref goFile, ref formatter, version25);
                            int version26 = (int)formatter.Deserialize(goFile);
                            Datas.TrackNotes = loader.LoadTrackNotes(ref goFile, ref formatter, version26, Datas.Tracks.Length);
                            int version27 = (int)formatter.Deserialize(goFile);
                            Datas.FinanceHistory = loader.LoadFinacialHistory(ref goFile, ref formatter, version27);
                            int version28 = (int)formatter.Deserialize(goFile);
                            Datas.Staff = loader.LoadStaff(ref goFile, ref formatter, version28);
                            int version29 = (int)formatter.Deserialize(goFile);
                            Datas.StaffHistory = loader.LoadStaffHistory(ref goFile, ref formatter, version29);
                            break;
                        case 11:
                            num2 = (int)formatter.Deserialize(goFile);
                            managerName = (string)formatter.Deserialize(goFile);
                            teamName = (string)formatter.Deserialize(goFile);
                            Datas.Date = (Date)formatter.Deserialize(goFile);
                            int version30 = (int)formatter.Deserialize(goFile);
                            Datas.Car = loader.LoadCar(ref goFile, ref formatter, version30);
                            int version31 = (int)formatter.Deserialize(goFile);
                            Datas.Driver = loader.LoadDriver(ref goFile, ref formatter, version31);
                            int version32 = (int)formatter.Deserialize(goFile);
                            Datas.CarHistory = loader.LoadCarHistory(ref goFile, ref formatter, version32);
                            int version33 = (int)formatter.Deserialize(goFile);
                            Datas.OldDrivers = loader.LoadOldDrivers(ref goFile, ref formatter, version33);
                            int version34 = (int)formatter.Deserialize(goFile);
                            Datas.Seasons = loader.LoadSeasons(ref goFile, ref formatter, version34);
                            int version35 = (int)formatter.Deserialize(goFile);
                            Datas.TrackNotes = loader.LoadTrackNotes(ref goFile, ref formatter, version35, Datas.Tracks.Length);
                            int version36 = (int)formatter.Deserialize(goFile);
                            Datas.FinanceHistory = loader.LoadFinacialHistory(ref goFile, ref formatter, version36);
                            int version37 = (int)formatter.Deserialize(goFile);
                            Datas.Staff = loader.LoadStaff(ref goFile, ref formatter, version37);
                            int version38 = (int)formatter.Deserialize(goFile);
                            Datas.StaffHistory = loader.LoadStaffHistory(ref goFile, ref formatter, version38);
                            int version39 = (int)formatter.Deserialize(goFile);
                            Datas.TechnicalDirector = loader.LoadTechnicalDirector(ref goFile, ref formatter, version39);
                            int version40 = (int)formatter.Deserialize(goFile);
                            Datas.OldTechnicalDirectors = loader.LoadOldTechnicalDirectors(ref goFile, ref formatter, version40);
                            break;
                        case 12:
                            num2 = (int)formatter.Deserialize(goFile);
                            managerName = (string)formatter.Deserialize(goFile);
                            teamName = (string)formatter.Deserialize(goFile);
                            Datas.Date = (Date)formatter.Deserialize(goFile);
                            int version41 = (int)formatter.Deserialize(goFile);
                            Datas.Car = loader.LoadCar(ref goFile, ref formatter, version41);
                            int version42 = (int)formatter.Deserialize(goFile);
                            Datas.Driver = loader.LoadDriver(ref goFile, ref formatter, version42);
                            int version43 = (int)formatter.Deserialize(goFile);
                            Datas.CarHistory = loader.LoadCarHistory(ref goFile, ref formatter, version43);
                            int version44 = (int)formatter.Deserialize(goFile);
                            Datas.OldDrivers = loader.LoadOldDrivers(ref goFile, ref formatter, version44);
                            int version45 = (int)formatter.Deserialize(goFile);
                            Datas.Seasons = loader.LoadSeasons(ref goFile, ref formatter, version45);
                            int version46 = (int)formatter.Deserialize(goFile);
                            Datas.TrackNotes = loader.LoadTrackNotes(ref goFile, ref formatter, version46, Datas.Tracks.Length);
                            int version47 = (int)formatter.Deserialize(goFile);
                            Datas.FinanceHistory = loader.LoadFinacialHistory(ref goFile, ref formatter, version47);
                            int version48 = (int)formatter.Deserialize(goFile);
                            Datas.Staff = loader.LoadStaff(ref goFile, ref formatter, version48);
                            int version49 = (int)formatter.Deserialize(goFile);
                            Datas.StaffHistory = loader.LoadStaffHistory(ref goFile, ref formatter, version49);
                            int version50 = (int)formatter.Deserialize(goFile);
                            Datas.TechnicalDirector = loader.LoadTechnicalDirector(ref goFile, ref formatter, version50);
                            int version51 = (int)formatter.Deserialize(goFile);
                            Datas.OldTechnicalDirectors = loader.LoadOldTechnicalDirectors(ref goFile, ref formatter, version51);
                            int version52 = (int)formatter.Deserialize(goFile);
                            Datas.Manager = loader.LoadManager(ref goFile, ref formatter, version52);
                            break;
                        default:
                            num2 = (int)formatter.Deserialize(goFile);
                            managerName = (string)formatter.Deserialize(goFile);
                            teamName = (string)formatter.Deserialize(goFile);
                            Datas.Date = (Date)formatter.Deserialize(goFile);
                            int version53 = (int)formatter.Deserialize(goFile);
                            Datas.Car = loader.LoadCar(ref goFile, ref formatter, version53);
                            int version54 = (int)formatter.Deserialize(goFile);
                            Datas.Driver = loader.LoadDriver(ref goFile, ref formatter, version54);
                            int version55 = (int)formatter.Deserialize(goFile);
                            Datas.CarHistory = loader.LoadCarHistory(ref goFile, ref formatter, version55);
                            int version56 = (int)formatter.Deserialize(goFile);
                            Datas.OldDrivers = loader.LoadOldDrivers(ref goFile, ref formatter, version56);
                            int version57 = (int)formatter.Deserialize(goFile);
                            Datas.Seasons = loader.LoadSeasons(ref goFile, ref formatter, version57);
                            int version58 = (int)formatter.Deserialize(goFile);
                            Datas.TrackNotes = loader.LoadTrackNotes(ref goFile, ref formatter, version58, Datas.Tracks.Length);
                            int version59 = (int)formatter.Deserialize(goFile);
                            Datas.FinanceHistory = loader.LoadFinacialHistory(ref goFile, ref formatter, version59);
                            int version60 = (int)formatter.Deserialize(goFile);
                            Datas.Staff = loader.LoadStaff(ref goFile, ref formatter, version60);
                            int version61 = (int)formatter.Deserialize(goFile);
                            Datas.StaffHistory = loader.LoadStaffHistory(ref goFile, ref formatter, version61);
                            int version62 = (int)formatter.Deserialize(goFile);
                            Datas.TechnicalDirector = loader.LoadTechnicalDirector(ref goFile, ref formatter, version62);
                            int version63 = (int)formatter.Deserialize(goFile);
                            Datas.OldTechnicalDirectors = loader.LoadOldTechnicalDirectors(ref goFile, ref formatter, version63);
                            int version64 = (int)formatter.Deserialize(goFile);
                            Datas.Manager = loader.LoadManager(ref goFile, ref formatter, version64);
                            Datas.WarnWrongTyres = (bool)formatter.Deserialize(goFile);
                            break;
                    }
                    Datas.INDEX_CURRENTSEASON = Datas.Seasons.Count - 1;
                    goFile.Close();
                    if (num2 < 2)
                    {
                        Season20 season20 = Datas.Seasons.FirstOrDefault<Season20>((Func<Season20, bool>)(season => season.Season == 3));
                        if (season20 != null)
                        {
                            foreach (RaceEvent20 raceEvent20 in ((IEnumerable<RaceEvent20>)season20.Events).Where<RaceEvent20>((Func<RaceEvent20, bool>)(race => race.isRaceUpdated)))
                                raceEvent20.Race.CalculateWear(Datas.Tracks[raceEvent20.Trackid - 1]);
                        }
                    }
                    if (num2 < 4)
                    {
                        int index1 = -1;
                        for (int index2 = 0; index2 < Datas.Seasons.Count; ++index2)
                        {
                            if (Datas.Seasons[index2].Season == 3)
                            {
                                index1 = index2;
                                break;
                            }
                        }
                        if (index1 >= 0)
                        {
                            if (Datas.Seasons[index1].Events[0].isRaceUpdated)
                                Datas.Seasons[index1].Events[0].Race.Laps[0].weather.skies = Skies.Sunny;
                            if (Datas.Seasons[index1].Events[1].isRaceUpdated)
                            {
                                Datas.Seasons[index1].Events[1].Race.Laps[0].weather.skies = Skies.VeryCloudy;
                                for (int index3 = 4; index3 < 63; ++index3)
                                    Datas.Seasons[index1].Events[1].Race.Laps[index3].weather.skies = Skies.Rain;
                            }
                            if (Datas.Seasons[index1].Events[3].isRaceUpdated)
                                Datas.Seasons[index1].Events[3].Race.Laps[0].weather.skies = Skies.PartiallyCloudy;
                            if (Datas.Seasons[index1].Events[4].isRaceUpdated)
                                Datas.Seasons[index1].Events[4].Race.Laps[0].weather.skies = Skies.Cloudy;
                            if (Datas.Seasons[index1].Events[5].isRaceUpdated)
                                Datas.Seasons[index1].Events[5].Race.Laps[0].weather.skies = Skies.Cloudy;
                            if (Datas.Seasons[index1].Events[8].isRaceUpdated)
                                Datas.Seasons[index1].Events[8].Race.Laps[0].weather.skies = Skies.Cloudy;
                            if (Datas.Seasons[index1].Events[9].isRaceUpdated)
                                Datas.Seasons[index1].Events[9].Race.Laps[0].weather.skies = Skies.Sunny;
                            if (Datas.Seasons[index1].Events[10].isRaceUpdated)
                                Datas.Seasons[index1].Events[10].Race.Laps[0].weather.skies = Skies.PartiallyCloudy;
                            if (Datas.Seasons[index1].Events[11].isRaceUpdated)
                                Datas.Seasons[index1].Events[11].Race.Laps[0].weather.skies = Skies.VeryCloudy;
                            int index4 = 0;
                            for (int index5 = 0; index5 < Datas.Seasons[index1].Events.Length; ++index5)
                            {
                                for (; index4 < Datas.CarHistory.historyList.Count && ((CarHistoryItem2)Datas.CarHistory.historyList[index4]).date.race <= index5 + 1; ++index4)
                                {
                                    if (Datas.Seasons[index1].Events[index5].isTestingUpdated && ((CarHistoryItem2)Datas.CarHistory.historyList[index4]).date.race == index5 + 1)
                                        ((CarHistoryItem2)Datas.CarHistory.historyList[index4]).car.UpdateTestPoints(Datas.Seasons[index1].Events[index5].Test);
                                }
                                --index4;
                                if (index4 < 0)
                                    index4 = 0;
                            }
                            if (Datas.Seasons[index1].Events[Datas.Date.race - 1].isTestingUpdated)
                                Datas.Car.UpdateTestPoints(Datas.Seasons[index1].Events[Datas.Date.race - 1].Test);
                        }
                    }
                    if (num1 < 5)
                    {
                        int index6 = -1;
                        for (int index7 = 0; index7 < Datas.Seasons.Count; ++index7)
                        {
                            if (Datas.Seasons[index7].Season == 3)
                            {
                                index6 = index7;
                                break;
                            }
                        }
                        if (index6 >= 0)
                        {
                            for (int index8 = 0; index8 < Datas.Date.race - 1; ++index8)
                            {
                                if (Datas.Seasons[index6].Events[index8].isRaceUpdated && Datas.Seasons[index6].Events[index8].isCarUpdated && Datas.Seasons[index6].Events[index8].isPractiseUpdated)
                                    Datas.Seasons[index6].Events[index8].Practise.car = Datas.Seasons[index6].Events[index8].Race.Car;
                            }
                        }
                    }
                    if (num2 < 5)
                    {
                        foreach (Season20 season in Datas.Seasons)
                        {
                            foreach (RaceEvent20 raceEvent20 in season.Events)
                            {
                                if (raceEvent20.isRaceUpdated)
                                {
                                    for (int index = 0; index < raceEvent20.Race.PitStops.Length; ++index)
                                    {
                                        if (raceEvent20.Race.Laps[raceEvent20.Race.PitStops[index].lap].events.IndexOf("Pit") < 0)
                                            raceEvent20.Race.Laps[raceEvent20.Race.PitStops[index].lap].events += ", Pit";
                                    }
                                }
                            }
                        }
                    }
                    if (num2 < 7 && Datas.Seasons != null && Datas.Seasons[Datas.INDEX_CURRENTSEASON] != null && Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events != null)
                    {
                        if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[10] != null && Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[10].Practise != null && Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[10].Practise.weather.temperature == 1)
                        {
                            Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[10].Practise.weather.temperature = 16;
                            Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[10].Weather.pracWeather.temperature = 16;
                            Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[10].Weather.qualWeather.temperature = 16;
                            Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[10].Weather.forecast.minTemp[0] = 17;
                            Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[10].Weather.forecast.minTemp[1] = 19;
                            Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[10].Weather.forecast.minTemp[2] = 16;
                            Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[10].Weather.forecast.minTemp[3] = 14;
                        }
                        if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[9] != null && Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[9].isRaceUpdated)
                            Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[9].Race.Laps[0].weather.skies = Skies.Rain;
                    }
                    if (num2 < 8)
                    {
                        for (int index9 = 0; index9 < Datas.Seasons.Count; ++index9)
                        {
                            if (Datas.Seasons[index9] != null)
                            {
                                for (int index10 = 0; index10 < Datas.Seasons[index9].Events.Length; ++index10)
                                {
                                    if (Datas.Seasons[index9].Events[index10] != null && Datas.Seasons[index9].Events[index10].Driver != null)
                                        Datas.Seasons[index9].Events[index10].Driver.history = new DriverHistory2();
                                }
                            }
                        }
                    }
                    if (num2 < 9)
                    {
                        int index = Datas.INDEX_CURRENTSEASON + Datas.Date.season - Datas.Seasons[Datas.INDEX_CURRENTSEASON].Season;
                        if (index <= Datas.INDEX_CURRENTSEASON && Datas.Seasons[index] != null && Datas.Seasons[index].Events != null && Datas.Seasons[index].Events[4] != null && Datas.Seasons[index].Events[4].isRaceUpdated)
                        {
                            Datas.Seasons[index].Events[4].Race.Laps[0].weather.temperature = 26;
                            Datas.Seasons[index].Events[4].Race.Laps[1].weather.temperature = 26;
                            Datas.Seasons[index].Events[4].Race.Laps[2].weather.temperature = 26;
                            Datas.Seasons[index].Events[4].Race.Laps[3].weather.temperature = 26;
                            Datas.Seasons[index].Events[4].Race.Laps[4].weather.temperature = 26;
                            Datas.Seasons[index].Events[4].Race.Laps[5].weather.temperature = 26;
                            Datas.Seasons[index].Events[4].Race.Laps[6].weather.temperature = 26;
                            Datas.Seasons[index].Events[4].Race.Laps[7].weather.temperature = 27;
                            Datas.Seasons[index].Events[4].Race.Laps[8].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[9].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[10].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[11].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[12].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[13].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[14].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[15].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[16].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[17].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[18].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[19].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[20].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[21].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[22].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[23].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[24].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[25].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[26].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[27].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[28].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[29].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[30].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[31].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[32].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[33].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[34].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[35].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[36].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[37].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[38].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[39].weather.temperature = 28;
                            Datas.Seasons[index].Events[4].Race.Laps[40].weather.temperature = 27;
                            Datas.Seasons[index].Events[4].Race.Laps[41].weather.temperature = 26;
                            Datas.Seasons[index].Events[4].Race.Laps[42].weather.temperature = 26;
                            Datas.Seasons[index].Events[4].Race.Laps[43].weather.temperature = 25;
                            Datas.Seasons[index].Events[4].Race.Laps[44].weather.temperature = 25;
                            Datas.Seasons[index].Events[4].Race.Laps[45].weather.temperature = 25;
                            Datas.Seasons[index].Events[4].Race.Laps[46].weather.temperature = 25;
                            Datas.Seasons[index].Events[4].Race.Laps[47].weather.temperature = 25;
                            Datas.Seasons[index].Events[4].Race.Laps[48].weather.temperature = 25;
                            Datas.Seasons[index].Events[4].Race.Laps[49].weather.temperature = 24;
                            Datas.Seasons[index].Events[4].Race.Laps[50].weather.temperature = 23;
                            Datas.Seasons[index].Events[4].Race.Laps[51].weather.temperature = 22;
                            Datas.Seasons[index].Events[4].Race.Laps[52].weather.temperature = 22;
                            Datas.Seasons[index].Events[4].Race.Laps[53].weather.temperature = 22;
                            Datas.Seasons[index].Events[4].Race.Laps[54].weather.temperature = 21;
                            Datas.Seasons[index].Events[4].Race.Laps[55].weather.temperature = 20;
                            Datas.Seasons[index].Events[4].Race.Laps[0].weather.humidity = 48;
                            Datas.Seasons[index].Events[4].Race.Laps[1].weather.humidity = 48;
                            Datas.Seasons[index].Events[4].Race.Laps[2].weather.humidity = 48;
                            Datas.Seasons[index].Events[4].Race.Laps[3].weather.humidity = 48;
                            Datas.Seasons[index].Events[4].Race.Laps[4].weather.humidity = 48;
                            Datas.Seasons[index].Events[4].Race.Laps[5].weather.humidity = 48;
                            Datas.Seasons[index].Events[4].Race.Laps[6].weather.humidity = 48;
                            Datas.Seasons[index].Events[4].Race.Laps[7].weather.humidity = 48;
                            Datas.Seasons[index].Events[4].Race.Laps[8].weather.humidity = 48;
                            Datas.Seasons[index].Events[4].Race.Laps[9].weather.humidity = 48;
                            Datas.Seasons[index].Events[4].Race.Laps[10].weather.humidity = 48;
                            Datas.Seasons[index].Events[4].Race.Laps[11].weather.humidity = 48;
                            Datas.Seasons[index].Events[4].Race.Laps[12].weather.humidity = 47;
                            Datas.Seasons[index].Events[4].Race.Laps[13].weather.humidity = 46;
                            Datas.Seasons[index].Events[4].Race.Laps[14].weather.humidity = 46;
                            Datas.Seasons[index].Events[4].Race.Laps[15].weather.humidity = 46;
                            Datas.Seasons[index].Events[4].Race.Laps[16].weather.humidity = 46;
                            Datas.Seasons[index].Events[4].Race.Laps[17].weather.humidity = 46;
                            Datas.Seasons[index].Events[4].Race.Laps[18].weather.humidity = 46;
                            Datas.Seasons[index].Events[4].Race.Laps[19].weather.humidity = 46;
                            Datas.Seasons[index].Events[4].Race.Laps[20].weather.humidity = 46;
                            Datas.Seasons[index].Events[4].Race.Laps[21].weather.humidity = 46;
                            Datas.Seasons[index].Events[4].Race.Laps[22].weather.humidity = 46;
                            Datas.Seasons[index].Events[4].Race.Laps[23].weather.humidity = 46;
                            Datas.Seasons[index].Events[4].Race.Laps[24].weather.humidity = 45;
                            Datas.Seasons[index].Events[4].Race.Laps[25].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[26].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[27].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[28].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[29].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[30].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[31].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[32].weather.humidity = 43;
                            Datas.Seasons[index].Events[4].Race.Laps[33].weather.humidity = 43;
                            Datas.Seasons[index].Events[4].Race.Laps[34].weather.humidity = 43;
                            Datas.Seasons[index].Events[4].Race.Laps[35].weather.humidity = 43;
                            Datas.Seasons[index].Events[4].Race.Laps[36].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[37].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[38].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[39].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[40].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[41].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[42].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[43].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[44].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[45].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[46].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[47].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[48].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[49].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[50].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[51].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[52].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[53].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[54].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.Laps[55].weather.humidity = 44;
                            Datas.Seasons[index].Events[4].Race.CalculateWear(Datas.Tracks[14]);
                        }
                        if (index <= Datas.INDEX_CURRENTSEASON && Datas.Seasons[index] != null && Datas.Seasons[index].Events != null && Datas.Seasons[index].Events[5] != null && Datas.Seasons[index].Events[5].isRaceUpdated)
                        {
                            Datas.Seasons[index].Events[5].Race.Laps[0].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[1].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[2].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[3].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[4].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[5].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[6].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[7].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[8].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[9].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[10].weather.temperature = 32;
                            Datas.Seasons[index].Events[5].Race.Laps[11].weather.temperature = 32;
                            Datas.Seasons[index].Events[5].Race.Laps[12].weather.temperature = 33;
                            Datas.Seasons[index].Events[5].Race.Laps[12].weather.temperature = 33;
                            Datas.Seasons[index].Events[5].Race.Laps[13].weather.temperature = 34;
                            Datas.Seasons[index].Events[5].Race.Laps[14].weather.temperature = 34;
                            Datas.Seasons[index].Events[5].Race.Laps[15].weather.temperature = 33;
                            Datas.Seasons[index].Events[5].Race.Laps[16].weather.temperature = 32;
                            Datas.Seasons[index].Events[5].Race.Laps[17].weather.temperature = 32;
                            Datas.Seasons[index].Events[5].Race.Laps[18].weather.temperature = 32;
                            Datas.Seasons[index].Events[5].Race.Laps[19].weather.temperature = 32;
                            Datas.Seasons[index].Events[5].Race.Laps[20].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[21].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[22].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[23].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[24].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[25].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[26].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[27].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[28].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[29].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[30].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[31].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[32].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[33].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[34].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[35].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[36].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[37].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[38].weather.temperature = 30;
                            Datas.Seasons[index].Events[5].Race.Laps[39].weather.temperature = 29;
                            Datas.Seasons[index].Events[5].Race.Laps[40].weather.temperature = 29;
                            Datas.Seasons[index].Events[5].Race.Laps[41].weather.temperature = 29;
                            Datas.Seasons[index].Events[5].Race.Laps[42].weather.temperature = 29;
                            Datas.Seasons[index].Events[5].Race.Laps[43].weather.temperature = 29;
                            Datas.Seasons[index].Events[5].Race.Laps[44].weather.temperature = 29;
                            Datas.Seasons[index].Events[5].Race.Laps[45].weather.temperature = 29;
                            Datas.Seasons[index].Events[5].Race.Laps[46].weather.temperature = 29;
                            Datas.Seasons[index].Events[5].Race.Laps[47].weather.temperature = 29;
                            Datas.Seasons[index].Events[5].Race.Laps[48].weather.temperature = 29;
                            Datas.Seasons[index].Events[5].Race.Laps[49].weather.temperature = 30;
                            Datas.Seasons[index].Events[5].Race.Laps[50].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[51].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[52].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[53].weather.temperature = 31;
                            Datas.Seasons[index].Events[5].Race.Laps[0].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[1].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[2].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[3].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[4].weather.humidity = 26;
                            Datas.Seasons[index].Events[5].Race.Laps[5].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[6].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[7].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[8].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[9].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[10].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[11].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[12].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[13].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[14].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[15].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[16].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[17].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[18].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[19].weather.humidity = 27;
                            Datas.Seasons[index].Events[5].Race.Laps[20].weather.humidity = 26;
                            Datas.Seasons[index].Events[5].Race.Laps[21].weather.humidity = 26;
                            Datas.Seasons[index].Events[5].Race.Laps[22].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[23].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[24].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[25].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[26].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[27].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[28].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[29].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[30].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[31].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[32].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[33].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[34].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[35].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[36].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[37].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[38].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[39].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[40].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[41].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[42].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[43].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[44].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[45].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[46].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[47].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[48].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[49].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[50].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[51].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[52].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.Laps[53].weather.humidity = 25;
                            Datas.Seasons[index].Events[5].Race.CalculateWear(Datas.Tracks[12]);
                        }
                    }
                    if (num2 < 15)
                    {
                        foreach (Season20 season in Datas.Seasons)
                        {
                            foreach (RaceEvent20 raceEvent20 in season.Events)
                            {
                                if (raceEvent20.Qualify2.time > TimeSpan.Zero)
                                    raceEvent20.isQualifing2Updated = true;
                            }
                        }
                    }
                    if (num2 < 16)
                    {
                        foreach (FinanceItem2 financeItem2 in Datas.FinanceHistory)
                        {
                            if (financeItem2.ItemType == FinanceItemType.Unknown)
                            {
                                string description = financeItem2.Description;
                                if (description.StartsWith("You extended the contract of your driver"))
                                    financeItem2.ItemType = FinanceItemType.DriverSigningFee;
                                if (description.StartsWith("Testing session costs"))
                                    financeItem2.ItemType = FinanceItemType.TestingSession;
                                if (description.StartsWith("Signing fee for your new technical director"))
                                    financeItem2.ItemType = FinanceItemType.TDSigningFee;
                                if (description.StartsWith("You offered a contract to the tech director"))
                                    financeItem2.ItemType = FinanceItemType.TDOffer;
                                if (description.Contains("compensation to your old technical director"))
                                    financeItem2.ItemType = FinanceItemType.TDCompensation;
                                if (description.EndsWith("GPRO Cup"))
                                    financeItem2.ItemType = FinanceItemType.CupEarnings;
                            }
                        }
                    }
                    if (num2 < 18)
                    {
                        foreach (Season20 season in Datas.Seasons)
                        {
                            foreach (RaceEvent20 raceEvent20 in season.Events)
                            {
                                if (raceEvent20.isRaceUpdated)
                                    raceEvent20.Race.CalculateWear(Datas.Tracks[raceEvent20.Trackid - 1]);
                            }
                        }
                    }
                    if (num2 < 19)
                    {
                        foreach (Season20 season20 in Datas.Seasons.Where<Season20>((Func<Season20, bool>)(season => season.Season == 29)))
                            season20.Events[8].Trackid = 36;
                    }
                    this.statusBarPanel3.Text = "Data loaded";
                    Datas.Communications = new Communication(Datas.Communications.rememberPassword, managerName, teamName);
                    WireCommunication();
                    if (Datas.Date.season <= 0)
                        return;
                    int index11 = Datas.Date.race == 18 ? 16 : Datas.Date.race - 1;
                    if (Datas.Date.race == 18)
                    {
                        Datas.NextRace = -1;
                        this.statusBarPanel2.Text = "End of season ";
                    }
                    else if (Datas.Seasons.Count > Datas.INDEX_CURRENTSEASON && Datas.Seasons[Datas.INDEX_CURRENTSEASON] != null)
                    {
                        Datas.NextRace = Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Trackid - 1;
                        this.statusBarPanel2.Text = "Next race: " + Datas.Tracks[Datas.NextRace].name;
                        this.FillPracticedata(Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].Practise, Datas.Date.race - 1);
                        this.FillQualifyTab(Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].Qualify1, Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].Qualify2);
                        if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].isStrategyUpdated)
                            this.FillStrategyTab(Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].Strat);
                        if (Datas.Date.race > 0 && Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].Weather.forecast.isReady)
                            this.FillWeatherTab(Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].Weather);
                        if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].isTyreSupplierUpdated)
                            this.FillTyreSupplierTab(Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].Tyresupplier);
                        if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].isTestingUpdated)
                            this.FillTestingTab(Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].Test, Datas.Date.race - 1);
                        if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].isSponsorStateUpdated)
                            this.FillSponsorTab(Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index11].SponsorState);
                    }
                    this.FillCarData();
                    this.UpdateSeasonStats();
                    this.FillDriverTab();
                    this.FillFinancesTab();
                    this.FillTitleBar();
                    this.FillStaffTab();
                    this.FillTechnicalDirectorTab();
                    this.menuItemCurrentSeason.Enabled = true;
                    this.menuItemPitStrategy.Enabled = true;
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("There has been an unidentified error while reading your go.dat file.\nIt can be found at " + (Datas.KeepDataWithApp ? "the program location" : this.GetDefaultFileName()) + " If you save any data, your old data will be lost. Please make a backup of your data file before proceeding \nand contact gpro.organizer@gmail.com for help", "Critical error during startup", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Errlog.AddToLog("LoadData: " + ex.Message);
                }
            }

            UpdateStatusBarText("Data loaded");
        }

        private void FillTyreSupplierTab(TyreSupplier supplier)
        {
            this.textBoxDryPerformance.Text = supplier.dryPerf.ToString();
            this.textBoxWetPerformance.Text = supplier.wetPerf.ToString();
            this.textBoxPeakTemperature.Text = supplier.peakTemp.ToString();
            this.textBoxDurability.Text = supplier.durability.ToString();
            this.textBoxWarmupDistance.Text = supplier.warmUpDistance.ToString();
        }

        private void GetRegistrySettings()
        {
            //Datas.Communications.rememberPassword = false;
            RegistryKey subKey1 = Registry.CurrentUser.CreateSubKey("Software\\go");
            Datas.Username = (string)subKey1.GetValue("Username");
            string cipherText = (string)subKey1.GetValue("Password");
            if (cipherText != null)
            {
                if (cipherText != "none")
                {
                    try
                    {
                        Datas.Password = EncDec.Decrypt(cipherText, "phdsp98q4tæqæræosalæx-lkdsvjipo.LKLDUSFÆIREp98 w3rp98y<ÆH æFp9843æiohfp9y<ftg");
                        if (Datas.Password != "")
                            Datas.Communications.rememberPassword = true;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show("Unable to retrieve password from registry.", "Error loading password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Errlog.AddToLog("GetRegistrySettings: " + ex.Message);
                    }
                }
            }
            if ((string)subKey1.GetValue("AutoCheck") == "Yes")
            {
                Datas.AutoCheck = true;
                this.CheckVersion();
            }
            else
                this.statusBarPanelVersion.Text = "Version check disabled";
            if ((string)subKey1.GetValue("KeepDataWithProgram") == "Yes")
                Datas.KeepDataWithApp = true;
            subKey1.Close();
            RegistryKey subKey2 = Registry.CurrentUser.CreateSubKey("Software\\go\\GUI");
            Datas.LastTabViewed = go.Utils.Util.GetRegistryInt(ref subKey2, "StartingTabPage") - 1;
            if (Datas.LastTabViewed < 0)
                Datas.LastTabViewed = go.Utils.Util.GetRegistryInt(ref subKey2, "TabPage");
            this.tabControl1.SelectedIndex = Datas.LastTabViewed;
        }

        private void SaveRegistrySettings()
        {
            RegistryKey subKey1 = Registry.CurrentUser.CreateSubKey("Software\\go");
            subKey1.SetValue("Username", (object)Datas.Communications.username);
            if (Datas.Communications.rememberPassword)
                subKey1.SetValue("Password", (object)EncDec.Encrypt(Datas.Communications.password, "phdsp98q4tæqæræosalæx-lkdsvjipo.LKLDUSFÆIREp98 w3rp98y<ÆH æFp9843æiohfp9y<ftg"));
            else
                subKey1.SetValue("Password", (object)"none");
            subKey1.SetValue("AutoCheck", Datas.AutoCheck ? (object)"Yes" : (object)"No");
            subKey1.SetValue("KeepDataWithProgram", Datas.KeepDataWithApp ? (object)"Yes" : (object)"No");
            subKey1.Close();
            RegistryKey subKey2 = Registry.CurrentUser.CreateSubKey("Software\\go\\GUI");
            subKey2.SetValue("TabPage", (object)this.tabControl1.SelectedIndex);
            subKey2.Close();
        }

        private void CheckComms()
        {
            if (Datas.Communications != null)
                return;
            Datas.Communications = new Communication();
        }

        private void GetCommonData()
        {
            try
            {      
                if (
                    Datas.Seasons.Count == 0 ||
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON] == null ||
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON].Season == 0
                )
                {
                    if (Datas.Seasons.Count == 0)
                    {
                        Datas.Seasons.Add(new Season20());
                        Datas.INDEX_CURRENTSEASON = 0;
                    }

                    this.UpdateSeason();
                }
                else if (
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON].Season
                    < Datas.Date.season
                )
                {      
                    Datas.Seasons.Add(new Season20());
        
                    ++Datas.INDEX_CURRENTSEASON;
        
        
                    this.UpdateSeason();
                }
        
                if (
                    Datas.Seasons.Count > Datas.INDEX_CURRENTSEASON &&
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON] != null
                )
                {        
                    var currentEvent =
                        Datas.Seasons[Datas.INDEX_CURRENTSEASON]
                            .Events[Datas.Date.race - 1];
                }
        
                this.menuItemCurrentSeason.Enabled = true;
                this.menuItemPitStrategy.Enabled = true;
        
                if (Datas.Date.race == 18)
                {
                    Datas.NextRace = -1;
                    this.statusBarPanel2.Text = "End of season ";
                }
                else
                {
                    var currentEvent =
                        Datas.Seasons[Datas.INDEX_CURRENTSEASON]
                            .Events[Datas.Date.race - 1];
               
                    Datas.NextRace = currentEvent.Trackid - 1;
        
                    this.statusBarPanel2.Text =
                        "Next race: " + Datas.Tracks[Datas.NextRace].name;
                }
        
                this.UpdateSeasonStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "GetCommonData Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
        
                Errlog.AddToLog(ex.ToString());
            }
        }
        private void UpdateAll()
        {
            if (!Datas.IsOkToUpdate)
                return;
            this.ToggleFunctionality(false);
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            this.CheckComms();
            try
            {
                this.Updatecar();
                this.UpdateDriver();
                this.UpdateTesting();
                if (this.UpdatePractice())
                {
                    this.UpdateQualify();
                    this.UpdateStrategy();
                }
                this.UpdateLastrace();
                this.UpdateStaff();
                this.UpdateTechnicalDirector();
                this.UpdateTyreSupplier();
                this.UpdateLastRaceSummary();
                this.UpdateSponsors();
                this.UpdateFinances();
                this.FillCarWearData();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("Form1: " + ex.Message);
                return;
            }
            this.UpdateSeasonStats();
            Cursor.Current = current;
            this.statusBarPanel3.Text = "Ready";
            this.FillTitleBar();
            this.ToggleFunctionality(true);
            if (Datas.TechnicalDirector.id > 0)
                Datas.OldTechnicalDirectors.Add((object)Datas.TechnicalDirector);
            else
                Datas.TechnicalDirector = new TechnicalDirector();
            this.FillTechnicalDirectorTab();
        }

        public bool UpdateFinances()
        {
            try
            {
                this.statusBarPanel3.Text = "Finances";
                int count = Datas.FinanceHistory.Count;
                Datas.FinanceHistory = FinanceParser.UpdateFinancialHistory();
                if (Datas.FinanceHistory.Count != count)
                {
                    this.DataChanged();
                    this.FillFinancesTab();
                }
                this.statusBarPanel3.Text = "Finances downloaded";
                return true;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("UpdateFinances: " + ex.Message);
                return false;
            }
        }

        public bool UpdateTyreSupplier()
        {
            try
            {
                this.statusBarPanel3.Text = "Tyre supplier";
                TyreSupplier tyreSupplier = TyreSupplierParser.GetTyreSupplier();
//
                if (Datas.Date.race != 18 && (!Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].isTyreSupplierUpdated || !Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Tyresupplier.isEqual(tyreSupplier)))
                {
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Tyresupplier = tyreSupplier;
                    this.DataChanged();
                    this.FillTyreSupplierTab(tyreSupplier);
                }
                this.statusBarPanel3.Text = "Tyre supplier downloaded";
                return true;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("UpdateTyreSupplier: " + ex.Message);
                return false;
            }
        }

        public bool Updatecar()
        {
            try
            {
                this.statusBarPanel3.Text = "Car";
                Car2 car;
                try
                {
                    car = CarParser.GetCar();
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show((IWin32Window)this, "Error during car parsing0: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Errlog.AddToLog("UpdateCar0: " + ex.Message);
                    return false;
                }
                this.GetCommonData();
                if (Datas.Date.race != 18)
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].isCarUpdated = true;
                CarHistoryItem2 carHistoryItem2_1 = new CarHistoryItem2()
                {
                    car = car,
                    date = Datas.Date
                };
                CarHistoryItem2 carHistoryItem2_2 = new CarHistoryItem2();
                try
                {
                    for (int index = Datas.CarHistory.historyList.Count - 1; index >= 0; --index)
                    {
                        CarHistoryItem2 history = (CarHistoryItem2)Datas.CarHistory.historyList[index];
                        if (history.date.race == carHistoryItem2_1.date.race)
                            carHistoryItem2_1 = history;
                        if (history.date.race == carHistoryItem2_1.date.race - 1)
                        {
                            carHistoryItem2_2 = history;
                            break;
                        }
                        if (history.date.race < carHistoryItem2_1.date.race)
                            break;
                    }
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show((IWin32Window)this, "Error during car parsing1: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Errlog.AddToLog("UpdateCar1: " + ex.Message);
                    return false;
                }
                try
                {
                    if (Datas.Date.race > 1)
                    {
                        if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 2].isRaceUpdated)
                        {
                            Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 2].Startcar = carHistoryItem2_2.car;
                            Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 2].Endcar = carHistoryItem2_1.car;
                        }
                    }
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show((IWin32Window)this, "Error during car parsing2: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Errlog.AddToLog("UpdateCar2: " + ex.Message);
                    return false;
                }
                try
                {
                    CarHistoryItem2 lastItem = Datas.CarHistory.GetLastItem();
                    bool flag = true;
                    if (lastItem == null)
                        flag = true;
                    else if (Datas.Date.IsEqual(lastItem.date) && car.IsEqual(Datas.Car))
                        flag = false;
                    if (flag)
                    {
                        this.DataChanged();
                        Datas.Car = car;
                        CarHistoryItem2 carHistoryItem2_3 = new CarHistoryItem2()
                        {
                            date = Datas.Date,
                            car = Datas.Car
                        };
                        Datas.CarHistory.historyList.Add((object)carHistoryItem2_3);
                    }
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show((IWin32Window)this, "Error during car parsing3: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Errlog.AddToLog("UpdateCar3: " + ex.Message);
                    return false;
                }
                this.FillCarData();
                this.statusBarPanel3.Text = "CarInfo downloaded";
                return true;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Error during car parsing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("UpdateCar: " + ex.Message);
                return false;
            }
        }

        public bool UpdateDriver()
        {
            try
            {
                this.statusBarPanel3.Text = "Driver";
                Driver5 driver = DriverParser.GetDriver(Datas.Communications.GetDriverID());
//                this.GetCommonData();
                if (Datas.Date.race != 18)
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Driver = Datas.Driver.CopyNoHistory();
                if (driver != null && Datas.Driver.isSameDriver(driver.id) && !Datas.Driver.isEqual(driver))
                {
                    Datas.Driver.UpdateDriver(Datas.Date, driver, false);
                    this.DataChanged();
                }
                if (driver == null || !Datas.Driver.isSameDriver(driver.id))
                {
                    if (Datas.Driver.id > 0)
                        Datas.OldDrivers.Add((object)Datas.Driver);
                    Datas.Driver = driver;
                    Datas.Driver.InitDriver(Datas.Date);
                    this.DataChanged();
                }
                this.FillDriverTab();
                this.statusBarPanel3.Text = "Driver updated";
                return true;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Error during driver parsing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("UpdateDriver: " + ex.Message);
                Errlog.AddToLog(ex.StackTrace);
                return false;
            }
        }

        private bool UpdateTechnicalDirector()
        {
            if (Datas.Communications.GetTechDID() != 0)
            {
                try
                {
                    this.statusBarPanel3.Text = "Technical Director";
                    TechnicalDirector director = TechnicalDirectorParser.ParseDirector(Datas.Communications.GetTechDID());
                    if (Datas.Date.race != 18)
                        Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].TechnicalDirector = Datas.TechnicalDirector.CopyNoHistory();
                    if (director != null)
                    {
                        if (Datas.TechnicalDirector.IsSameTechnicalDirector(director.id))
                        {
                            if (!Datas.TechnicalDirector.IsEqual(director))
                            {
                                Datas.TechnicalDirector.UpdateTechnicalDirector(Datas.Date, director, false);
                                this.DataChanged();
                            }
                        }
                        else
                        {
                            Datas.OldTechnicalDirectors.Add((object)Datas.TechnicalDirector);
                            Datas.TechnicalDirector = director;
                            Datas.TechnicalDirector.Init(Datas.Date);
                            this.DataChanged();
                        }
                    }
                    else
                    {
                        Datas.OldTechnicalDirectors.Add((object)Datas.TechnicalDirector);
                        Datas.TechnicalDirector = new TechnicalDirector();
                        this.DataChanged();
                    }
                    this.FillTechnicalDirectorTab();
                    this.statusBarPanel3.Text = "Technical Director Updated";
                    return true;
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show((IWin32Window)this, "Error during technical director parsing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Errlog.AddToLog("UpdateTechnicalDirector: " + ex.Message);
                    return false;
                }
            }
            else
            {
                if (Datas.TechnicalDirector != null && Datas.TechnicalDirector.id != 0)
                {
                    Datas.OldTechnicalDirectors.Add((object)Datas.TechnicalDirector);
                    Datas.TechnicalDirector = new TechnicalDirector();
                    this.DataChanged();
                }
                return true;
            }
        }

        public bool UpdateTesting()
        {
            if (Datas.Date.race == 18)
                return true;
            try
            {
                this.statusBarPanel3.Text = "Testing";
                Testing test = TestingParser.ParseTest();
                this.statusBarPanel3.Text = "Testing downloaded";
                Datas.Car.testAcceleration = test.points[3].acceleration;
                Datas.Car.testHandling = test.points[3].handling;
                Datas.Car.testPower = test.points[3].power;
                this.FillCarData();
                if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].isTestingUpdated && Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Test.runs.Length >= test.runs.Length)
                {
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Test.runs[0] == null)
                    {
                        if (test.runs[0] == null)
                            goto label_7;
                    }
                    else
                        goto label_7;
                }
                Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Test = test;
                this.FillTestingTab(test, Datas.Date.race - 1);
                this.DataChanged();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Error during test parsing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("UpdateTesting: " + ex.Message);
                return false;
            }
label_7:
            return true;
        }

        private bool UpdateLastrace()
        {
            this.statusBarPanel3.Text = "Last Race";
            RaceEvent20 raceEvent = (RaceEvent20)null;
            if (Datas.INDEX_CURRENTSEASON > 0)
                raceEvent = Datas.Date.race == 1 ? Datas.Seasons[Datas.INDEX_CURRENTSEASON - 1].Events[16] : Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 2];
            if (raceEvent == null || raceEvent.isRaceUpdated)
                return true;
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Race9 race = RaceAnalysisParser.ParseRace(raceEvent);
//                this.GetCommonData();
                if (race == null)
                {
                    this.statusBarPanel3.Text = "Did not race";
                    return true;
                }
                raceEvent.Race = race;
                this.DataChanged();
                this.statusBarPanel3.Text = "Last race downloaded";
                Cursor.Current = current;
                return true;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Error during race parsing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("UpdateLastRace: " + ex.Message);
                Cursor.Current = current;
                return false;
            }
        }

        private bool UpdatePractice()
        {
            if (Datas.Date.race == 18)
                return true;
            int num1 = 0;
            for (int index = 7; index >= 0; --index)
            {
                if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Practise.runs[index] != null && Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Practise.runs[index].netTime > TimeSpan.Zero)
                {
                    num1 = index + 1;
                    break;
                }
            }
            try
            {
                this.statusBarPanel3.Text = "Practice";
                RaceWeather wf = new RaceWeather();
                Practice3 practice = PracticeParser.ParsePractice(ref wf);
                if (wf.forecast.isReady)
                {
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Weather = wf;
                    this.FillWeatherTab(wf);
                }
//                this.GetCommonData();
                this.statusBarPanel3.Text = "Practice downloaded";
                int num2 = 0;
                for (int index = 7; index >= 0; --index)
                {
                    if (practice.runs[index] != null && practice.runs[index].netTime > TimeSpan.Zero)
                    {
                        num2 = index + 1;
                        break;
                    }
                }
                for (int index = 0; index < 8; ++index)
                {
                    if (practice.runs[index] != null && practice.runs[index].netTime > TimeSpan.Zero && practice.runs[index].comments[0].Equals("") && !Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Practise.runs[index].comments[0].Equals(""))
                        practice.runs[index].comments = Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Practise.runs[index].comments;
                }
                if (num2 > num1 && practice.runs[0].netTime > TimeSpan.Zero)
                {
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Practise = practice;
                    this.DataChanged();
                }
                this.FillPracticedata(practice, Datas.Date.race - 1);
                return true;
            }
            catch (Exception ex)
            {
                int num3 = (int)MessageBox.Show((IWin32Window)this, "Error during practice parsing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("UpdatePractice: " + ex.Message);
                return false;
            }
        }

        private bool UpdateQualify()
        {
            if (Datas.Date.race == 18 || Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].isQualifingUpdated && Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Qualify2.time > TimeSpan.Zero)
                return true;
            try
            {
                this.statusBarPanel3.Text = "Qualify";
                Qualify qualify1 = QualifyParser.ParseQualify1();
                Qualify qualify2 = QualifyParser.ParseQualify2();
//                this.GetCommonData();
                if (qualify1.time > TimeSpan.Zero)
                {
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Qualify1 == null)
                        this.DataChanged();
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Qualify1 = qualify1;
                    this.statusBarPanel3.Text = "Qualify1 downloaded";
                }
                if (qualify2.time > TimeSpan.Zero)
                {
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Qualify2 == null)
                        this.DataChanged();
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Qualify2 = qualify2;
                    this.statusBarPanel3.Text = "Qualify2 downloaded";
                }
                else
                    this.statusBarPanel3.Text = "Qualify2 not yet completed";
                this.FillQualifyTab(qualify1, qualify2);
                return true;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Error during qualify parsing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("UpdateQualify: " + ex.Message);
                return false;
            }
        }

        private bool UpdateStrategy()
        {
            if (Datas.Date.race == 18)
                return true;
            try
            {
                this.statusBarPanel3.Text = "Strategy";
                Strategy4 strategy = StrategyParser.ParseStrategy();
//                this.GetCommonData();
                bool flag = Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Strat.IsEqual(strategy);
                if (strategy.isStrategyUpdated && Datas.WarnWrongTyres)
                {
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Weather.qualWeather.skies == Skies.Rain)
                    {
                        if (strategy.startTyres != TyreType.Rain)
                        {
                            int num1 = (int)MessageBox.Show("You have selected to start on dry tyres even though the start of the race will be rain.", "GO warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (strategy.startTyres == TyreType.Rain)
                    {
                        int num2 = (int)MessageBox.Show("You have selected to start on rain tyres even though the start of the race will be dry.", "GO warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                if (!strategy.isStrategyUpdated | flag)
                {
                    this.FillStrategyTab(strategy);
                    return true;
                }
                Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Strat = strategy;
                this.statusBarPanel3.Text = "Strategy downloaded";
                this.FillStrategyTab(strategy);
                this.DataChanged();
                return true;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Error during strategy parsing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("UpdateStrategy: " + ex.Message);
                return false;
            }
        }

        private bool UpdateStaff()
        {
            this.statusBarPanel3.Text = "Staff";
            try
            {
                Staff staff = StaffParser.ParseStaff();
                if (Datas.Staff.IsDifferent(staff))
                {
                    this.DataChanged();
                    Datas.Staff.UpdateHistory(Datas.Date, ref Datas.StaffHistory, staff);
                }
                if (Datas.Date.race != 18)
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].Staff = Datas.Staff;
                this.FillStaffTab();
                return true;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Error during staff parsing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("UpdateStaff: " + ex.Message);
                return false;
            }
        }

        private bool UpdateLastRaceSummary()
        {
            this.statusBarPanel3.Text = "Last race";
            try
            {
                if (Datas.Date.race == 1 || Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 2].isSummaryUpdated)
                    return true;
                RaceSummary raceSummary = RaceSummaryParser.GetRaceSummary(Datas.Communications.groupName);
                Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 2].Summary = raceSummary;
                this.DataChanged();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Error during Last Race parsing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("LastRaceParsing: " + ex.Message);
                return false;
            }
            return true;
        }

        private bool UpdateSponsors()
        {
            this.statusBarPanel3.Text = "Sponsors";
            try
            {
                if (Datas.Date.race == 18)
                    return true;
                SponsorState oldSponsor = (SponsorState)null;
                if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].isSponsorStateUpdated)
                    oldSponsor = Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].SponsorState;
                SponsorState sponsor = SponsorParser.GetSponsor();
                if (sponsor != null)
                {
                    Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.Date.race - 1].SponsorState = sponsor;
                    this.FillSponsorTab(sponsor);
                    if (oldSponsor != null)
                    {
                        if (!sponsor.isDifferent(oldSponsor))
                            goto label_10;
                    }
                    this.DataChanged();
                }
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Error during Sponsor parsing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("SponsorParsing: " + ex.Message);
                return false;
            }
label_10:
            return true;
        }

        private bool UpdateManager()
        {
            Datas.Communications.GetDate();
            Datas.Manager = ManagerParser.GetManager(Datas.Communications.managerID);
            return true;
        }

        private void UpdateSeason()
        {
            try
            {
                Datas.Seasons[Datas.INDEX_CURRENTSEASON] = SeasonParser.ParseSeason();
                Datas.Seasons[Datas.INDEX_CURRENTSEASON].Season = Datas.Date.season;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Error during parsing of new season, please contact gpro.organizer@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("UpdateSeason: " + ex.Message);
                throw new Exception("Error during season parsing", ex);
            }
        }

        private void UpdateSeasonStats()
        {
            try
            {
                if (Datas.Seasons.Count <= Datas.INDEX_CURRENTSEASON || Datas.Seasons[Datas.INDEX_CURRENTSEASON] == null || Datas.Seasons[Datas.INDEX_CURRENTSEASON].Season == 0)
                    return;
                this.comboBoxPrac.Items.Clear();
                this.listViewSeason.Items.Clear();
                for (int index = 0; index < Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events.Length; ++index)
                {
                    ListViewItem listViewItem = new ListViewItem((index + 1).ToString());
                    try
                    {
                        listViewItem.SubItems.Add(Datas.Tracks[Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].Trackid - 1].name);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        int num = (int)MessageBox.Show((IWin32Window)this, "One of the tracks for this season is unknown to GO \n You must update the tracks using the Tools -> Update tracks menu \n If you are running Vista it may be necessary to run GO as administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    }
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].isCarUpdated)
                        listViewItem.SubItems.Add("updated");
                    else
                        listViewItem.SubItems.Add("-");
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].isDriverUpdated)
                        listViewItem.SubItems.Add("updated");
                    else
                        listViewItem.SubItems.Add("-");
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].isTyreSupplierUpdated)
                        listViewItem.SubItems.Add("updated");
                    else
                        listViewItem.SubItems.Add("-");
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].Practise.runs[0].netTime > TimeSpan.Zero)
                    {
                        this.comboBoxPrac.Items.Add((object)Datas.Tracks[Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].Trackid - 1].name);
                        listViewItem.SubItems.Add("updated");
                    }
                    else
                        listViewItem.SubItems.Add("-");
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].isQualifingUpdated)
                        listViewItem.SubItems.Add("updated");
                    else
                        listViewItem.SubItems.Add("-");
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].isQualifing2Updated)
                        listViewItem.SubItems.Add("updated");
                    else
                        listViewItem.SubItems.Add("-");
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].isStrategyUpdated)
                        listViewItem.SubItems.Add("updated");
                    else
                        listViewItem.SubItems.Add("-");
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].isRaceUpdated)
                        listViewItem.SubItems.Add("updated");
                    else
                        listViewItem.SubItems.Add("-");
                    if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].isSponsorStateUpdated)
                        listViewItem.SubItems.Add("updated");
                    else
                        listViewItem.SubItems.Add("-");
                    this.listViewSeason.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Error during update of season tab, please contact gpro.organizer@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("Season tab update: " + ex.Message + "\n" + ex.StackTrace);
                throw new Exception("Error during season tab update", ex);
            }
        }

        private void FillTitleBar()
        {
            string str = "GPRO Organizer";
            if (Datas.Communications.managerName != "")
                str = str + ": " + Datas.Communications.managerName;
            if (Datas.Communications.teamName != "")
                str = str + ", " + Datas.Communications.teamName;
            this.Text = str;
        }

        private void FillFinancesTab()
        {
            this.listViewFinance.Items.Clear();
            for (int index = 0; index < Datas.FinanceHistory.Count; ++index)
            {
                FinanceItem financeItem = (FinanceItem)Datas.FinanceHistory[index];
                this.listViewFinance.Items.Add(new ListViewItem(new string[5]
                {
          financeItem.Date.ToString(),
          financeItem.Description,
          EnumToString.Wage2String(financeItem.BalanceBefore),
          EnumToString.Wage2String(financeItem.Amount),
          EnumToString.Wage2String(financeItem.BalanceAfter)
                }));
            }
        }

        private void FillCarData()
        {
            try
            {
                this.textBoxen1.Text = Datas.Car.engine.level.ToString();
                this.textBoxen2.Text = Datas.Car.engine.wear.ToString();
                this.textBoxfw1.Text = Datas.Car.frontWing.level.ToString();
                this.textBoxfw2.Text = Datas.Car.frontWing.wear.ToString();
                this.textBoxrw1.Text = Datas.Car.rearWing.level.ToString();
                this.textBoxrw2.Text = Datas.Car.rearWing.wear.ToString();
                this.textBoxel1.Text = Datas.Car.electronics.level.ToString();
                this.textBoxel2.Text = Datas.Car.electronics.wear.ToString();
                this.textBoxch1.Text = Datas.Car.chassis.level.ToString();
                this.textBoxch2.Text = Datas.Car.chassis.wear.ToString();
                this.textBoxun1.Text = Datas.Car.underbody.level.ToString();
                this.textBoxun2.Text = Datas.Car.underbody.wear.ToString();
                this.textBoxsi1.Text = Datas.Car.sidepods.level.ToString();
                this.textBoxsi2.Text = Datas.Car.sidepods.wear.ToString();
                this.textBoxco1.Text = Datas.Car.cooling.level.ToString();
                this.textBoxco2.Text = Datas.Car.cooling.wear.ToString();
                this.textBoxgb1.Text = Datas.Car.gearBox.level.ToString();
                this.textBoxgb2.Text = Datas.Car.gearBox.wear.ToString();
                this.textBoxbr1.Text = Datas.Car.brakes.level.ToString();
                this.textBoxbr2.Text = Datas.Car.brakes.wear.ToString();
                this.textBoxsu1.Text = Datas.Car.suspension.level.ToString();
                this.textBoxsu2.Text = Datas.Car.suspension.wear.ToString();
                this.textBoxPower.Text = Datas.Car.power.ToString();
                this.textBoxAcceleration.Text = Datas.Car.acceleration.ToString();
                this.textBoxHandling.Text = Datas.Car.handling.ToString();
                this.textBoxTestPower.Text = Datas.Car.testPower.ToString();
                this.textBoxTestHandling.Text = Datas.Car.testHandling.ToString();
                this.textBoxTestAcceleration.Text = Datas.Car.testAcceleration.ToString();
                if (Datas.CarHistory.historyList.Count > 1)
                {
                    CarHistoryItem2 history = (CarHistoryItem2)Datas.CarHistory.historyList[Datas.CarHistory.historyList.Count - 2];
                    this.ColorTextBox(history.car.power, Datas.Car.power, ref this.textBoxPower, ref this.toolTipCarPower);
                    this.ColorTextBox(history.car.handling, Datas.Car.handling, ref this.textBoxHandling, ref this.toolTipCarHandling);
                    this.ColorTextBox(history.car.acceleration, Datas.Car.acceleration, ref this.textBoxAcceleration, ref this.toolTipCarAcceleration);
                    this.ColorTextBox(history.car.testPower, Datas.Car.testPower, ref this.textBoxTestPower, ref this.toolTipCarTestPower);
                    this.ColorTextBox(history.car.testHandling, Datas.Car.testHandling, ref this.textBoxTestHandling, ref this.toolTipCarTestHandling);
                    this.ColorTextBox(history.car.testAcceleration, Datas.Car.testAcceleration, ref this.textBoxTestAcceleration, ref this.toolTipCarTestAcceleration);
                    this.ColorTextBox(history.car.frontWing.level, Datas.Car.frontWing.level, ref this.textBoxfw1, ref this.toolTipCarFW);
                    this.ColorTextBox(history.car.rearWing.level, Datas.Car.rearWing.level, ref this.textBoxrw1, ref this.toolTipCarRW);
                    this.ColorTextBox(history.car.engine.level, Datas.Car.engine.level, ref this.textBoxen1, ref this.toolTipCarEng);
                    this.ColorTextBox(history.car.gearBox.level, Datas.Car.gearBox.level, ref this.textBoxgb1, ref this.toolTipCarGea);
                    this.ColorTextBox(history.car.chassis.level, Datas.Car.chassis.level, ref this.textBoxch1, ref this.toolTipCarCha);
                    this.ColorTextBox(history.car.suspension.level, Datas.Car.suspension.level, ref this.textBoxsu1, ref this.toolTipCarSus);
                    this.ColorTextBox(history.car.underbody.level, Datas.Car.underbody.level, ref this.textBoxun1, ref this.toolTipCarUnd);
                    this.ColorTextBox(history.car.electronics.level, Datas.Car.electronics.level, ref this.textBoxel1, ref this.toolTipCarEle);
                    this.ColorTextBox(history.car.sidepods.level, Datas.Car.sidepods.level, ref this.textBoxsi1, ref this.toolTipCarSid);
                    this.ColorTextBox(history.car.cooling.level, Datas.Car.cooling.level, ref this.textBoxco1, ref this.toolTipCarCoo);
                    this.ColorTextBox(history.car.brakes.level, Datas.Car.brakes.level, ref this.textBoxbr1, ref this.toolTipCarBra);
                }
                this.ColorTextBoxIfAbovelevel(Datas.Car.frontWing.wear, 70, ref this.textBoxfw2);
                this.ColorTextBoxIfAbovelevel(Datas.Car.rearWing.wear, 70, ref this.textBoxrw2);
                this.ColorTextBoxIfAbovelevel(Datas.Car.brakes.wear, 70, ref this.textBoxbr2);
                this.ColorTextBoxIfAbovelevel(Datas.Car.chassis.wear, 70, ref this.textBoxch2);
                this.ColorTextBoxIfAbovelevel(Datas.Car.cooling.wear, 70, ref this.textBoxco2);
                this.ColorTextBoxIfAbovelevel(Datas.Car.electronics.wear, 70, ref this.textBoxel2);
                this.ColorTextBoxIfAbovelevel(Datas.Car.engine.wear, 70, ref this.textBoxen2);
                this.ColorTextBoxIfAbovelevel(Datas.Car.gearBox.wear, 70, ref this.textBoxgb2);
                this.ColorTextBoxIfAbovelevel(Datas.Car.sidepods.wear, 70, ref this.textBoxsi2);
                this.ColorTextBoxIfAbovelevel(Datas.Car.suspension.wear, 70, ref this.textBoxsu2);
                this.ColorTextBoxIfAbovelevel(Datas.Car.underbody.wear, 70, ref this.textBoxun2);
                this.FillCarWearData();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Error during car display: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Errlog.AddToLog("FillCarData: " + ex.Message);
            }
        }

        private void FillCarWearData()
        {
            Car2 car2 = new Car2();
            for (int index1 = 0; index1 <= Datas.INDEX_CURRENTSEASON; ++index1)
            {
                if (Datas.Seasons.Count > index1 && Datas.Seasons[index1] != null)
                {
                    for (int index2 = 0; index2 < Datas.Seasons[index1].Events.Length; ++index2)
                    {
                        if (Datas.Seasons[index1].Events[index2].isRaceUpdated && Datas.Seasons[index1].Events[index2].isCarUpdated && Datas.Seasons[index1].Events[index2].Race.DidFinishRace)
                        {
                            Car2 startcar = Datas.Seasons[index1].Events[index2].Startcar;
                            Car2 endcar = Datas.Seasons[index1].Events[index2].Endcar;
                            if (startcar != null && endcar != null)
                            {
                                if (startcar.frontWing.level == Datas.Car.frontWing.level && endcar.frontWing.wear - startcar.frontWing.wear > 0)
                                {
                                    ++car2.frontWing.level;
                                    car2.frontWing.wear += endcar.frontWing.wear - startcar.frontWing.wear;
                                }
                                if (startcar.rearWing.level == Datas.Car.rearWing.level && endcar.rearWing.wear - startcar.rearWing.wear > 0)
                                {
                                    ++car2.rearWing.level;
                                    car2.rearWing.wear += endcar.rearWing.wear - startcar.rearWing.wear;
                                }
                                if (startcar.engine.level == Datas.Car.engine.level && endcar.engine.wear - startcar.engine.wear > 0)
                                {
                                    ++car2.engine.level;
                                    car2.engine.wear += endcar.engine.wear - startcar.engine.wear;
                                }
                                if (startcar.gearBox.level == Datas.Car.gearBox.level && endcar.gearBox.wear - startcar.gearBox.wear > 0)
                                {
                                    ++car2.gearBox.level;
                                    car2.gearBox.wear += endcar.gearBox.wear - startcar.gearBox.wear;
                                }
                                if (startcar.brakes.level == Datas.Car.brakes.level && endcar.brakes.wear - startcar.brakes.wear > 0)
                                {
                                    ++car2.brakes.level;
                                    car2.brakes.wear += endcar.brakes.wear - startcar.brakes.wear;
                                }
                                if (startcar.suspension.level == Datas.Car.suspension.level && endcar.suspension.wear - startcar.suspension.wear > 0)
                                {
                                    ++car2.suspension.level;
                                    car2.suspension.wear += endcar.suspension.wear - startcar.suspension.wear;
                                }
                                if (startcar.chassis.level == Datas.Car.chassis.level && endcar.chassis.wear - startcar.chassis.wear > 0)
                                {
                                    ++car2.chassis.level;
                                    car2.chassis.wear += endcar.chassis.wear - startcar.chassis.wear;
                                }
                                if (startcar.underbody.level == Datas.Car.underbody.level && endcar.underbody.wear - startcar.underbody.wear > 0)
                                {
                                    ++car2.underbody.level;
                                    car2.underbody.wear += endcar.underbody.wear - startcar.underbody.wear;
                                }
                                if (startcar.sidepods.level == Datas.Car.sidepods.level && endcar.sidepods.wear - startcar.sidepods.wear > 0)
                                {
                                    ++car2.sidepods.level;
                                    car2.sidepods.wear += endcar.sidepods.wear - startcar.sidepods.wear;
                                }
                                if (startcar.cooling.level == Datas.Car.cooling.level && endcar.cooling.wear - startcar.cooling.wear > 0)
                                {
                                    ++car2.cooling.level;
                                    car2.cooling.wear += endcar.cooling.wear - startcar.cooling.wear;
                                }
                                if (startcar.electronics.level == Datas.Car.electronics.level && endcar.electronics.wear - startcar.electronics.wear > 0)
                                {
                                    ++car2.electronics.level;
                                    car2.electronics.wear += endcar.electronics.wear - startcar.electronics.wear;
                                }
                            }
                        }
                    }
                }
            }
            this.FillWearBox(ref this.textBoxFwWear, car2.frontWing.level, car2.frontWing.wear, Datas.Car.frontWing.wear);
            this.FillWearBox(ref this.textBoxRwWear, car2.rearWing.level, car2.rearWing.wear, Datas.Car.rearWing.wear);
            this.FillWearBox(ref this.textBoxEnWear, car2.engine.level, car2.engine.wear, Datas.Car.engine.wear);
            this.FillWearBox(ref this.textBoxGeWear, car2.gearBox.level, car2.gearBox.wear, Datas.Car.gearBox.wear);
            this.FillWearBox(ref this.textBoxBrWear, car2.brakes.level, car2.brakes.wear, Datas.Car.brakes.wear);
            this.FillWearBox(ref this.textBoxSuWear, car2.suspension.level, car2.suspension.wear, Datas.Car.suspension.wear);
            this.FillWearBox(ref this.textBoxChWear, car2.chassis.level, car2.chassis.wear, Datas.Car.chassis.wear);
            this.FillWearBox(ref this.textBoxUnWear, car2.underbody.level, car2.underbody.wear, Datas.Car.underbody.wear);
            this.FillWearBox(ref this.textBoxSiWear, car2.sidepods.level, car2.sidepods.wear, Datas.Car.sidepods.wear);
            this.FillWearBox(ref this.textBoxCoWear, car2.cooling.level, car2.cooling.wear, Datas.Car.cooling.wear);
            this.FillWearBox(ref this.textBoxElWear, car2.electronics.level, car2.electronics.wear, Datas.Car.electronics.wear);
        }

        private void FillDriverTab()
        {
            this.ClearColorOnDriverBoxes();
            this.textBoxname.Text = Datas.Driver.name;
            this.textBoxnationality.Text = Datas.Driver.nationality;
            this.textBoxtrophies.Text = Datas.Driver.trophies.ToString();
            this.textBoxnumGPs.Text = Datas.Driver.numberOfGps.ToString();
            this.textBoxWins.Text = Datas.Driver.wins.ToString();
            this.textBoxPodiums.Text = Datas.Driver.podiums.ToString();
            this.textBoxPoints.Text = Datas.Driver.pointsScored.ToString();
            this.textBoxPoles.Text = Datas.Driver.polePositions.ToString();
            this.textBoxFastestLaps.Text = Datas.Driver.fastestLaps.ToString();
            this.textBoxAverage.Text = Datas.Driver.avPointsPerrace.ToString();
            this.textBoxOverall.Text = Datas.Driver.overall.ToString();
            this.textBoxConcentration.Text = Datas.Driver.concentration.ToString();
            this.textBoxTalent.Text = Datas.Driver.talent.ToString();
            this.textBoxAggresiveness.Text = Datas.Driver.aggresiveness.ToString();
            this.textBoxExperience.Text = Datas.Driver.experience.ToString();
            this.textBoxTechnicalInsight.Text = Datas.Driver.technicalInsight.ToString();
            this.textBoxStamina.Text = Datas.Driver.stamina.ToString();
            this.textBoxCharisma.Text = Datas.Driver.charisma.ToString();
            this.textBoxMotivation.Text = Datas.Driver.motivation.ToString();
            this.textBoxReputation.Text = Datas.Driver.reputation.ToString();
            this.textBoxEnergy.Text = Datas.Driver.energy.ToString();
            this.textBoxWeight.Text = Datas.Driver.weight.ToString();
            this.textBoxAge.Text = Datas.Driver.age.ToString();
            this.textBoxSalary.Text = EnumToString.Wage2String(Datas.Driver.salary);
            this.textBoxContract.Text = Datas.Driver.racesLeftOfContract.ToString();
            this.FavoriteTracksView.Items.Clear();
            foreach (int favoriteTrack in Datas.Driver.favoriteTracks)
                this.FavoriteTracksView.Items.Add((object)Datas.Tracks[favoriteTrack - 1].name);
            if (Datas.Driver.history.historyList.Count < 2)
                return;
            Date date = Datas.Driver.history.GetLastItem().date;
            for (int index = 0; index < Datas.Driver.history.historyList.Count; ++index)
            {
                DriverHistoryItem2 history = (DriverHistoryItem2)Datas.Driver.history.historyList[Datas.Driver.history.historyList.Count - 1 - index];
                if (history.date.race != date.race)
                    break;
                ToolTip tip = new ToolTip();
                switch (history.driverinfo)
                {
                    case DriverInfo.Overall:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxOverall, ref this.toolTipOA);
                        break;
                    case DriverInfo.Concentration:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxConcentration, ref this.toolTipConc);
                        break;
                    case DriverInfo.Talent:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTalent, ref this.toolTipTal);
                        break;
                    case DriverInfo.Aggresiveness:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxAggresiveness, ref this.toolTipAgg);
                        break;
                    case DriverInfo.Experience:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxExperience, ref this.toolTipExp);
                        break;
                    case DriverInfo.TechnicalInsight:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTechnicalInsight, ref this.toolTipTI);
                        break;
                    case DriverInfo.Stamina:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxStamina, ref this.toolTipSta);
                        break;
                    case DriverInfo.Charisma:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxCharisma, ref this.toolTipCha);
                        break;
                    case DriverInfo.Motivation:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxMotivation, ref this.toolTipMot);
                        break;
                    case DriverInfo.Weight:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxWeight, ref this.ToolTipWei);
                        break;
                    case DriverInfo.Trophies:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxtrophies, ref tip);
                        break;
                    case DriverInfo.Wins:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxWins, ref tip);
                        break;
                    case DriverInfo.Podiums:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxPodiums, ref tip);
                        break;
                    case DriverInfo.PointsScored:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxPoints, ref tip);
                        break;
                    case DriverInfo.PolePositions:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxPoles, ref tip);
                        break;
                    case DriverInfo.FastestLaps:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxFastestLaps, ref tip);
                        break;
                    case DriverInfo.AvPointsPerRace:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxAverage, ref tip);
                        break;
                    case DriverInfo.Salary:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxSalary, ref tip);
                        break;
                    case DriverInfo.RacesLeft:
                        if (history.newValue < 4.0)
                        {
                            this.ColorTextBox((HistoryItem)history, ref this.textBoxContract, ref tip);
                            break;
                        }
                        break;
                    case DriverInfo.Reputation:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxReputation, ref this.toolTipRep);
                        break;
                }
            }
        }

        private void FillTechnicalDirectorTab()
        {
            this.ClearColorOnTechnicalDirectorBoxes();
            this.textBoxTDAerodynamics.Text = Datas.TechnicalDirector.aerodynamics.ToString();
            this.textBoxTDAge.Text = Datas.TechnicalDirector.age.ToString();
            this.textBoxTDContract.Text = Datas.TechnicalDirector.racesLeftOfContract.ToString();
            this.textBoxTDElectronics.Text = Datas.TechnicalDirector.electronics.ToString();
            this.textBoxTDExperience.Text = Datas.TechnicalDirector.experience.ToString();
            this.textBoxTDLeadership.Text = Datas.TechnicalDirector.leadership.ToString();
            this.textBoxTDMechanics.Text = Datas.TechnicalDirector.mechanics.ToString();
            this.textBoxTDMotivation.Text = Datas.TechnicalDirector.motivation.ToString();
            this.textBoxTDName.Text = Datas.TechnicalDirector.name.ToString();
            this.textBoxTDNationality.Text = Datas.TechnicalDirector.nationality.ToString();
            this.textBoxTDNumGps.Text = Datas.TechnicalDirector.numberOfGps.ToString();
            this.textBoxTDOverall.Text = Datas.TechnicalDirector.overall.ToString();
            this.textBoxTDPitCoordination.Text = Datas.TechnicalDirector.pitCoordination.ToString();
            this.textBoxTDSalary.Text = EnumToString.Wage2String(Datas.TechnicalDirector.salary);
            this.textBoxTDTrophies.Text = Datas.TechnicalDirector.trophies.ToString();
            this.textBoxTDWins.Text = Datas.TechnicalDirector.wins.ToString();
            if (Datas.TechnicalDirector.history.historyList.Count < 2)
                return;
            Date date = Datas.TechnicalDirector.history.GetLastItem().date;
            for (int index = 0; index < Datas.TechnicalDirector.history.historyList.Count; ++index)
            {
                TechnicalDirectorHistoryItem history = (TechnicalDirectorHistoryItem)Datas.TechnicalDirector.history.historyList[Datas.TechnicalDirector.history.historyList.Count - 1 - index];
                if (history.date.race != date.race)
                    break;
                ToolTip tip = new ToolTip();
                switch (history.info)
                {
                    case TechnicalDirectorInfo.Trophies:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDTrophies, ref tip);
                        break;
                    case TechnicalDirectorInfo.NumberOfGps:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDNumGps, ref tip);
                        break;
                    case TechnicalDirectorInfo.Wins:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDWins, ref tip);
                        break;
                    case TechnicalDirectorInfo.Overall:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDOverall, ref tip);
                        break;
                    case TechnicalDirectorInfo.Leadership:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDLeadership, ref tip);
                        break;
                    case TechnicalDirectorInfo.Mechanics:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDMechanics, ref tip);
                        break;
                    case TechnicalDirectorInfo.Electronics:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDElectronics, ref tip);
                        break;
                    case TechnicalDirectorInfo.Aerodynamics:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDAerodynamics, ref tip);
                        break;
                    case TechnicalDirectorInfo.Experience:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDExperience, ref tip);
                        break;
                    case TechnicalDirectorInfo.PitCoordination:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDPitCoordination, ref tip);
                        break;
                    case TechnicalDirectorInfo.Motivation:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDMotivation, ref tip);
                        break;
                    case TechnicalDirectorInfo.Age:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDAge, ref tip);
                        break;
                    case TechnicalDirectorInfo.Salary:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDSalary, ref tip);
                        break;
                    case TechnicalDirectorInfo.ContractLength:
                        this.ColorTextBox((HistoryItem)history, ref this.textBoxTDContract, ref tip);
                        break;
                }
            }
        }

        private void FillTestingTab(Testing test, int raceid)
        {
            Datas.CurrentTestingViewed = raceid;
            this.listViewTest.Items.Clear();
            this.listViewTest.Items.Add(new ListViewItem(new string[4]
            {
        "Test points",
        test.points[0].power.ToString("N1"),
        test.points[0].handling.ToString("N1"),
        test.points[0].acceleration.ToString("N1")
            }));
            this.listViewTest.Items.Add(new ListViewItem(new string[4]
            {
        "R&D points",
        test.points[1].power.ToString("N1"),
        test.points[1].handling.ToString("N1"),
        test.points[1].acceleration.ToString("N1")
            }));
            this.listViewTest.Items.Add(new ListViewItem(new string[4]
            {
        "Engineering points",
        test.points[2].power.ToString("N1"),
        test.points[2].handling.ToString("N1"),
        test.points[2].acceleration.ToString("N1")
            }));
            this.listViewTest.Items.Add(new ListViewItem(new string[4]
            {
        "Car character points",
        test.points[3].power.ToString("N0"),
        test.points[3].handling.ToString("N0"),
        test.points[3].acceleration.ToString("N0")
            }));
            this.listViewTesting.Items.Clear();
            for (int index = 0; index < test.runs.Length && test.runs[index] != null; ++index)
                this.listViewTesting.Items.Add(new ListViewItem((index + 1).ToString())
                {
                    SubItems = {
            EnumToString.Time2String(test.runs[index].meanTime, true),
            EnumToString.Time2String(test.runs[index].bestTime, true),
            test.runs[index].lapLimit.ToString(),
            test.runs[index].lapsDone.ToString(),
            test.runs[index].fuelStart.ToString(),
            test.runs[index].tyresCondition.ToString() + "%",
            test.runs[index].fuelLeft.ToString(),
            EnumToString.Enum2String(test.runs[index].priority),
            test.runs[index].setup.fWing.ToString(),
            test.runs[index].setup.rWing.ToString(),
            test.runs[index].setup.engine.ToString(),
            test.runs[index].setup.brakes.ToString(),
            test.runs[index].setup.gear.ToString(),
            test.runs[index].setup.susp.ToString(),
            EnumToString.Enum2String(test.runs[index].setup.tyres)
          }
                });
            this.testTemp.Text = test.weather.temperature.ToString();
            this.testHumidity.Text = test.weather.humidity.ToString();
            this.testWeather.Text = EnumToString.Enum2String(test.weather.skies);
        }

        private void FillSponsorTab(SponsorState sponsor)
        {
            this.listViewOngoingSponsorContracts.Items.Clear();
            for (int index = 0; index < sponsor.ongoing.Length && sponsor.ongoing[index] != null; ++index)
                this.listViewOngoingSponsorContracts.Items.Add(new ListViewItem(sponsor.ongoing[index].name.ToString())
                {
                    SubItems = {
            sponsor.ongoing[index].spot.ToString(),
            sponsor.ongoing[index].amountPerRace.ToString(),
            sponsor.ongoing[index].contractStatus.ToString(),
            sponsor.ongoing[index].racesLeft.ToString()
          }
                });
            this.listViewOngoingSponsorNegotiations.Items.Clear();
            for (int index = 0; index < sponsor.negotiations.Length && sponsor.negotiations[index] != null; ++index)
                this.listViewOngoingSponsorNegotiations.Items.Add(new ListViewItem(sponsor.negotiations[index].name.ToString())
                {
                    SubItems = {
            sponsor.negotiations[index].spot.ToString(),
            sponsor.negotiations[index].amountPerRace.ToString(),
            sponsor.negotiations[index].duration.ToString(),
            sponsor.negotiations[index].progress.ToString() + "%",
            EnumToString.Enum2String(sponsor.negotiations[index].priority)
          }
                });
        }

        private void FillStrategyTab(Strategy4 strat)
        {
            this.textBoxFuel.Text = strat.startFuel.ToString();
            this.textBoxFuel1.Text = strat.stop1Fuel.ToString();
            this.textBoxFuel2.Text = strat.stop2Fuel.ToString();
            this.textBoxFuel3.Text = strat.stop3Fuel.ToString();
            this.textBoxFuel4.Text = strat.stop4Fuel.ToString();
            this.textBoxFuel5.Text = strat.stop5Fuel.ToString();
            this.textBoxFWing.Text = strat.setup.fWing.ToString();
            this.textBoxRWing.Text = strat.setup.rWing.ToString();
            this.textBoxEng.Text = strat.setup.engine.ToString();
            this.textBoxBra.Text = strat.setup.brakes.ToString();
            this.textBoxGear.Text = strat.setup.gear.ToString();
            this.textBoxSusp.Text = strat.setup.susp.ToString();
            this.textBoxTyresStart.Text = EnumToString.Enum2String(strat.startTyres);
            this.textBoxTyresRain.Text = EnumToString.Enum2String(strat.rainTyres);
            this.textBoxTyresDry.Text = EnumToString.Enum2String(strat.dryTyres);
            this.textBoxWaitRain.Text = strat.pitAfterRain.ToString();
            if (strat.pitAfterRain == 1)
                this.labelWaitRain.Text = "lap";
            this.textBoxWaitDry.Text = strat.pitAfterDry.ToString();
            if (strat.pitAfterDry == 1)
                this.labelWaitDry.Text = "lap";
            this.textBoxBoostLaps1.Text = strat.boostLap1.ToString();
            this.textBoxBoostLaps2.Text = strat.boostLap2.ToString();
            this.textBoxBoostLaps3.Text = strat.boostLap3.ToString();
            this.textBoxOvertake.Text = strat.riskOvertake.ToString();
            this.textBoxDefend.Text = strat.riskDefend.ToString();
            this.textBoxClear.Text = strat.riskClear.ToString();
            this.textBoxWet.Text = strat.riskWet.ToString();
            this.textBoxMalfunction.Text = strat.riskMalfunction.ToString();
            this.textBoxPitIfSolvableProblem.Text = strat.pitIfSolvableProblem ? "Yes" : "No";
            this.textBoxPitLimit.Text = strat.pitLapLimit.ToString();
            this.checkBoxRefuel.Checked = strat.dontrefuelOnTechnicalProblems;
            this.textBoxStartStrategy.Text = EnumToString.Enum2String(strat.startStrategy);
        }

        private void FillWeatherTab(RaceWeather wf)
        {
            if (wf == null || !wf.forecast.isReady)
                return;
            this.textBoxPracT.Text = wf.pracWeather.temperature.ToString();
            this.textBoxPracH.Text = wf.pracWeather.humidity.ToString();
            this.textBoxPracW.Text = EnumToString.Enum2String(wf.pracWeather.skies);
            this.textBoxQualT.Text = wf.qualWeather.temperature.ToString();
            this.textBoxQualH.Text = wf.qualWeather.humidity.ToString();
            this.textBoxQualW.Text = EnumToString.Enum2String(wf.qualWeather.skies);
            this.textBoxForecast1t.Text = wf.forecast.minTemp[0].ToString() + "° - " + wf.forecast.maxTemp[0].ToString() + "°";
            this.textBoxForecast1h.Text = wf.forecast.minHum[0].ToString() + " - " + wf.forecast.maxHum[0].ToString();
            this.textBoxForecast1r.Text = wf.forecast.minRain[0].ToString() + "%";
            if (wf.forecast.maxRain[0] > 0)
            {
                TextBox textBoxForecast1r = this.textBoxForecast1r;
                textBoxForecast1r.Text = textBoxForecast1r.Text + " - " + wf.forecast.maxRain[0].ToString() + "%";
            }
            this.textBoxForecast2t.Text = wf.forecast.minTemp[1].ToString() + "° - " + wf.forecast.maxTemp[1].ToString() + "°";
            this.textBoxForecast2h.Text = wf.forecast.minHum[1].ToString() + " - " + wf.forecast.maxHum[1].ToString();
            this.textBoxForecast2r.Text = wf.forecast.minRain[1].ToString() + "%";
            if (wf.forecast.maxRain[1] > 0)
            {
                TextBox textBoxForecast2r = this.textBoxForecast2r;
                textBoxForecast2r.Text = textBoxForecast2r.Text + " - " + wf.forecast.maxRain[1].ToString() + "%";
            }
            this.textBoxForecast3t.Text = wf.forecast.minTemp[2].ToString() + "° - " + wf.forecast.maxTemp[2].ToString() + "°";
            this.textBoxForecast3h.Text = wf.forecast.minHum[2].ToString() + " - " + wf.forecast.maxHum[2].ToString();
            this.textBoxForecast3r.Text = wf.forecast.minRain[2].ToString() + "%";
            if (wf.forecast.maxRain[2] > 0)
            {
                TextBox textBoxForecast3r = this.textBoxForecast3r;
                textBoxForecast3r.Text = textBoxForecast3r.Text + " - " + wf.forecast.maxRain[2].ToString() + "%";
            }
            this.textBoxForecast4t.Text = wf.forecast.minTemp[3].ToString() + "° - " + wf.forecast.maxTemp[3].ToString() + "°";
            this.textBoxForecast4h.Text = wf.forecast.minHum[3].ToString() + " - " + wf.forecast.maxHum[3].ToString();
            this.textBoxForecast4r.Text = wf.forecast.minRain[3].ToString() + "%";
            if (wf.forecast.maxRain[3] <= 0)
                return;
            TextBox textBoxForecast4r = this.textBoxForecast4r;
            textBoxForecast4r.Text = textBoxForecast4r.Text + " - " + wf.forecast.maxRain[3].ToString() + "%";
        }

        private void FillQualifyTab(Qualify q1, Qualify q2)
        {
            this.listViewQualify1.Items.Clear();
            this.listViewQualify2.Items.Clear();
            if (q1.time > TimeSpan.Zero)
                this.listViewQualify1.Items.Add(new ListViewItem(EnumToString.Time2String(q1.time, true))
                {
                    SubItems = {
            q1.setup.fWing.ToString(),
            q1.setup.rWing.ToString(),
            q1.setup.engine.ToString(),
            q1.setup.brakes.ToString(),
            q1.setup.gear.ToString(),
            q1.setup.susp.ToString(),
            EnumToString.Enum2String(q1.setup.tyres),
            EnumToString.Enum2String(q1.risk)
          }
                });
            if (!(q2.time > TimeSpan.Zero))
                return;
            ListViewItem listViewItem = new ListViewItem(EnumToString.Time2String(q2.time, true));
            listViewItem.SubItems.Add(q2.setup.fWing.ToString());
            listViewItem.SubItems.Add(q2.setup.rWing.ToString());
            listViewItem.SubItems.Add(q2.setup.engine.ToString());
            listViewItem.SubItems.Add(q2.setup.brakes.ToString());
            listViewItem.SubItems.Add(q2.setup.gear.ToString());
            listViewItem.SubItems.Add(q2.setup.susp.ToString());
            if (q2.fuel == -1)
                listViewItem.SubItems.Add("Unknown");
            else
                listViewItem.SubItems.Add(q2.fuel.ToString());
            listViewItem.SubItems.Add(EnumToString.Enum2String(q2.setup.tyres));
            listViewItem.SubItems.Add(EnumToString.Enum2String(q2.risk));
            this.listViewQualify2.Items.Add(listViewItem);
        }

        private void FillStaffTab()
        {
            Staff oldStaff = Datas.Staff.Clone();
            for (int index = 0; index < Datas.StaffHistory.Count && ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).date.race == Datas.Date.race; ++index)
            {
                switch (((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).type)
                {
                    case StaffType.Overall:
                        oldStaff.overall = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.Experience:
                        oldStaff.experience = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.Motivation:
                        oldStaff.motivation = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.TechnicalSkill:
                        oldStaff.technicalSkill = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.StressHandling:
                        oldStaff.stressHandling = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.Concentration:
                        oldStaff.concentration = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.Efficiency:
                        oldStaff.efficiency = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.Windtunnel:
                        oldStaff.windtunnel = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.PitstopTrainingCenter:
                        oldStaff.pitstopTrainingCenter = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.RDWorkshop:
                        oldStaff.rDWorkshop = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.RDDesignCenter:
                        oldStaff.rDDesignCenter = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.EngineeringWorkshop:
                        oldStaff.engineeringWorkshop = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.AlloyAndChemicalLab:
                        oldStaff.alloyAndChemicalLab = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.Commercial:
                        oldStaff.commercial = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.Salary:
                        oldStaff.salary = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                    case StaffType.Maintenance:
                        oldStaff.maintenance = ((StaffHistory)Datas.StaffHistory[Datas.StaffHistory.Count - index - 1]).oldValue;
                        break;
                }
            }
            if (oldStaff.salary > 0)
                this.FillStaffTab(ref oldStaff, ref Datas.Staff);
            else
                this.FillStaffTab(ref Datas.Staff, ref Datas.Staff);
        }

        private void FillPracticedata(Practice3 prac, int seasonid)
        {
            if (!Datas.OkToFillPractice)
                return;
            Datas.OkToFillPractice = false;
            Datas.CurrentPracticeViewed = seasonid;
            this.listViewPractice.Items.Clear();
            this.textBoxPracTemp.Text = "";
            this.textBoxPracHum.Text = "";
            this.textBoxPracWeather.Text = "";
            if (prac.runs[0].netTime == TimeSpan.Zero)
            {
                this.comboBoxPrac.Text = "Select Practice";
                Datas.OkToFillPractice = true;
            }
            else
            {
                this.comboBoxPrac.Text = Datas.Tracks[prac.track - 1].name;
                this.buttonExport.Enabled = true;
                for (int index = 0; index < 8; ++index)
                    this.listViewPractice.Items.Add(new ListViewItem((index + 1).ToString())
                    {
                        SubItems = {
              EnumToString.Time2String(prac.runs[index].lapTime, true),
              EnumToString.Time2String(prac.runs[index].driverMistake, true),
              EnumToString.Time2String(prac.runs[index].netTime, true),
              prac.runs[index].setup.fWing.ToString(),
              prac.runs[index].setup.rWing.ToString(),
              prac.runs[index].setup.engine.ToString(),
              prac.runs[index].setup.brakes.ToString(),
              prac.runs[index].setup.gear.ToString(),
              prac.runs[index].setup.susp.ToString(),
              EnumToString.Enum2String(prac.runs[index].setup.tyres)
            }
                    });
                this.textBoxPracWeather.Text = EnumToString.Enum2String(prac.weather.skies);
                this.textBoxPracTemp.Text = prac.weather.temperature.ToString();
                this.textBoxPracHum.Text = prac.weather.humidity.ToString();
                Datas.OkToFillPractice = true;
            }
        }

        private void FillStaffTab(ref Staff oldStaff, ref Staff newStaff)
        {
            this.textBoxStaffOverall.Text = newStaff.overall.ToString();
            this.textBoxStaffExperience.Text = newStaff.experience.ToString();
            this.textBoxStaffMotivation.Text = newStaff.motivation.ToString();
            this.textBoxStaffTechnicalSkill.Text = newStaff.technicalSkill.ToString();
            this.textBoxStaffStressHandling.Text = newStaff.stressHandling.ToString();
            this.textBoxStaffConcentration.Text = newStaff.concentration.ToString();
            this.textBoxStaffEfficiency.Text = newStaff.efficiency.ToString();
            this.textBoxStaffWindtunnel.Text = newStaff.windtunnel.ToString();
            this.textBoxStaffPitstop.Text = newStaff.pitstopTrainingCenter.ToString();
            this.textBoxStaffRDWorkshop.Text = newStaff.rDWorkshop.ToString();
            this.textBoxStaffRDDesign.Text = newStaff.rDDesignCenter.ToString();
            this.textBoxStaffEngineering.Text = newStaff.engineeringWorkshop.ToString();
            this.textBoxStaffAlloy.Text = newStaff.alloyAndChemicalLab.ToString();
            this.textBoxStaffCommercial.Text = newStaff.commercial.ToString();
            this.textBoxStaffSalary.Text = EnumToString.Wage2String(newStaff.salary);
            this.textBoxStaffFacilities.Text = EnumToString.Wage2String(newStaff.maintenance);
            this.ColorTextBox(oldStaff.overall, newStaff.overall, ref this.textBoxStaffOverall, ref this.toolTipStaffOverall);
            this.ColorTextBox(oldStaff.experience, newStaff.experience, ref this.textBoxStaffExperience, ref this.toolTipStaffExperience);
            this.ColorTextBox(oldStaff.motivation, newStaff.motivation, ref this.textBoxStaffMotivation, ref this.toolTipStaffMotivation);
            this.ColorTextBox(oldStaff.technicalSkill, newStaff.technicalSkill, ref this.textBoxStaffTechnicalSkill, ref this.toolTipStaffTechnicalSkill);
            this.ColorTextBox(oldStaff.stressHandling, newStaff.stressHandling, ref this.textBoxStaffStressHandling, ref this.toolTipStaffStress);
            this.ColorTextBox(oldStaff.concentration, newStaff.concentration, ref this.textBoxStaffConcentration, ref this.toolTipStaffConcentration);
            this.ColorTextBox(oldStaff.efficiency, newStaff.efficiency, ref this.textBoxStaffEfficiency, ref this.toolTipStaffEfficiency);
            this.ColorTextBox(oldStaff.windtunnel, newStaff.windtunnel, ref this.textBoxStaffWindtunnel, ref this.toolTipStaffWindtunnel);
            this.ColorTextBox(oldStaff.pitstopTrainingCenter, newStaff.pitstopTrainingCenter, ref this.textBoxStaffPitstop, ref this.toolTipStaffPitstop);
            this.ColorTextBox(oldStaff.rDWorkshop, newStaff.rDWorkshop, ref this.textBoxStaffRDWorkshop, ref this.toolTipStaffRDWorkshop);
            this.ColorTextBox(oldStaff.rDDesignCenter, newStaff.rDDesignCenter, ref this.textBoxStaffRDDesign, ref this.toolTipStaffRDDesign);
            this.ColorTextBox(oldStaff.engineeringWorkshop, newStaff.engineeringWorkshop, ref this.textBoxStaffEngineering, ref this.toolTipStaffEngineering);
            this.ColorTextBox(oldStaff.alloyAndChemicalLab, newStaff.alloyAndChemicalLab, ref this.textBoxStaffAlloy, ref this.toolTipStaffAlloy);
            this.ColorTextBox(oldStaff.commercial, newStaff.commercial, ref this.textBoxStaffCommercial, ref this.toolTipStaffCommercial);
            this.ColorTextBox(oldStaff.salary, newStaff.salary, ref this.textBoxStaffSalary, ref this.toolTipStaffSalary);
            this.ColorTextBox(oldStaff.maintenance, newStaff.maintenance, ref this.textBoxStaffFacilities, ref this.toolTipStaffFacilities);
        }

        private void ColorTextBoxIfAbovelevel(int testValue, int level, ref TextBox box)
        {
            if (testValue > level)
            {
                box.BackColor = System.Drawing.Color.Red;
                box.ForeColor = System.Drawing.Color.White;
                box.Text += " ";
            }
            else
            {
                box.BackColor = System.Drawing.Color.Empty;
                box.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void ColorTextBox(double oldValue, double newValue, ref TextBox box, ref ToolTip tip)
        {
            this.ColorTextBox((int)oldValue, (int)newValue, ref box, ref tip);
        }

        private void ColorTextBox(int oldValue, int newValue, ref TextBox box, ref ToolTip tip)
        {
            if (oldValue < newValue)
            {
                box.BackColor = System.Drawing.Color.Green;
                box.ForeColor = System.Drawing.Color.White;
                box.Text += " ";
                box.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
                tip.SetToolTip((Control)box, "+" + (newValue - oldValue).ToString());
            }
            else if (oldValue > newValue)
            {
                box.BackColor = System.Drawing.Color.Red;
                box.ForeColor = System.Drawing.Color.White;
                box.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
                box.Text += " ";
                tip.SetToolTip((Control)box, (newValue - oldValue).ToString());
            }
            else
            {
                box.BackColor = System.Drawing.Color.Empty;
                box.ForeColor = System.Drawing.Color.Black;
                box.Font = new Font("Microsoft Sans Serif", 8.25f);
            }
        }

        private void ColorTextBox(HistoryItem item, ref TextBox box, ref ToolTip tip)
        {
            if (box.BackColor == System.Drawing.Color.Green || box.BackColor == System.Drawing.Color.Red)
                return;
            if (item.oldValue < item.newValue)
            {
                box.BackColor = System.Drawing.Color.Green;
                box.ForeColor = System.Drawing.Color.White;
                box.Text += " ";
                box.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
                tip.SetToolTip((Control)box, "+" + ((double)(int)item.newValue - item.oldValue).ToString());
            }
            else
            {
                if (item.oldValue <= item.newValue)
                    return;
                box.BackColor = System.Drawing.Color.Red;
                box.ForeColor = System.Drawing.Color.White;
                box.Text += " ";
                box.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
                tip.SetToolTip((Control)box, ((double)(int)item.newValue - item.oldValue).ToString());
            }
        }

        private void FillWearBox(ref TextBox box, int races, int totalWear, int currentWear)
        {
            double num = 0.0;
            box.BackColor = System.Drawing.Color.Empty;
            box.ForeColor = System.Drawing.Color.Black;
            box.Font = new Font("Microsoft Sans Serif", 8.25f);
            if (races > 0)
                num = (double)totalWear / (double)races;
            box.Text = num.ToString("N1");
            if (num <= (double)(100 - currentWear))
                return;
            box.BackColor = System.Drawing.Color.Red;
            box.ForeColor = System.Drawing.Color.White;
            box.Text += " ";
            box.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
        }

        private void DataNotChanged()
        {
            Datas.DataChanged = false;
            this.statusBarPanel1.Text = "";
        }

        private void DataChanged()
        {
            Datas.DataChanged = true;
            this.statusBarPanel1.Text = "Changed";
        }

        private void Form1Closing(object sender, CancelEventArgs e)
        {
            if (Datas.DataChanged)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Data has changed. Do you wish to save before exiting?", "Data changed", MessageBoxButtons.YesNoCancel);
                if (num == 6)
                    this.SaveData();
                if (num == 2)
                    e.Cancel = true;
            }
            Datas.FormHandler.Save();
            this.SaveRegistrySettings();
            this.notifyIconGO.Dispose();
        }

        private void ClearColorOnDriverBoxes()
        {
            this.ClearBox(ref this.textBoxtrophies);
            this.ClearBox(ref this.textBoxnumGPs);
            this.ClearBox(ref this.textBoxWins);
            this.ClearBox(ref this.textBoxPodiums);
            this.ClearBox(ref this.textBoxPoints);
            this.ClearBox(ref this.textBoxPoles);
            this.ClearBox(ref this.textBoxFastestLaps);
            this.ClearBox(ref this.textBoxAverage);
            this.ClearBox(ref this.textBoxOverall);
            this.ClearBox(ref this.textBoxAggresiveness);
            this.ClearBox(ref this.textBoxConcentration);
            this.ClearBox(ref this.textBoxTalent);
            this.ClearBox(ref this.textBoxExperience);
            this.ClearBox(ref this.textBoxTechnicalInsight);
            this.ClearBox(ref this.textBoxStamina);
            this.ClearBox(ref this.textBoxCharisma);
            this.ClearBox(ref this.textBoxMotivation);
            this.ClearBox(ref this.textBoxWeight);
            this.ClearBox(ref this.textBoxSalary);
            this.ClearBox(ref this.textBoxContract);
        }

        private void ClearColorOnTechnicalDirectorBoxes()
        {
            this.ClearBox(ref this.textBoxTDAerodynamics);
            this.ClearBox(ref this.textBoxTDAge);
            this.ClearBox(ref this.textBoxTDContract);
            this.ClearBox(ref this.textBoxTDElectronics);
            this.ClearBox(ref this.textBoxTDExperience);
            this.ClearBox(ref this.textBoxTDLeadership);
            this.ClearBox(ref this.textBoxTDMechanics);
            this.ClearBox(ref this.textBoxTDMotivation);
            this.ClearBox(ref this.textBoxTDNumGps);
            this.ClearBox(ref this.textBoxTDWins);
            this.ClearBox(ref this.textBoxTDOverall);
            this.ClearBox(ref this.textBoxTDPitCoordination);
            this.ClearBox(ref this.textBoxTDSalary);
            this.ClearBox(ref this.textBoxTDTrophies);
        }

        private void ClearBox(ref TextBox box)
        {
            box.BackColor = System.Drawing.Color.Empty;
            box.ForeColor = System.Drawing.Color.Black;
            box.Font = new Font("Microsoft Sans Serif", 8.25f);
        }

        private void button2_Click(object sender, EventArgs e) => this.UpdateDriver();

        private void SaveButton_Click(object sender, EventArgs e) => this.SaveData();

        private void LoadButton_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.UpdateSeasonStats();
        }

        private void menuItemAllTracks_Click(object sender, EventArgs e) => new AllTracks().Show();

        private void menuItem13_Click(object sender, EventArgs e)
        {
            new DriverForm(Datas.Driver).Show();
        }

        private void menuItem8_Click(object sender, EventArgs e) => this.UpdatePractice();

        private void menuItem11_Click(object sender, EventArgs e)
        {
            this.CheckComms();
            Season20 season = SeasonParser.ParseSeason();
            this.GetCommonData();
            season.Season = Datas.Date.season;
            if (Datas.Seasons[Datas.INDEX_CURRENTSEASON].Season != 0)
                return;
            Datas.Seasons[Datas.INDEX_CURRENTSEASON] = season;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Errlog.Close();
            this.Close();
        }

        private void menuItem5_Click(object sender, EventArgs e) => this.Updatecar();

        private void menuItem14_Click(object sender, EventArgs e) => this.SaveData();

        private void menuItem7_Click(object sender, EventArgs e) => this.UpdateDriver();

        private void menuItem6_Click(object sender, EventArgs e) => this.UpdateLastrace();

        private void menuItem10_Click(object sender, EventArgs e) => this.UpdateQualify();

        private void menuItem15_Click(object sender, EventArgs e) => this.UpdateStrategy();

        private void menuItem16_Click(object sender, EventArgs e) => new AboutForm().Show();

        private void listViewPractice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewPractice.SelectedIndices.Count == 0)
            {
                this.textBoxPracComments.Text = "";
            }
            else
            {
                int selectedIndex = this.listViewPractice.SelectedIndices[0];
                string[] comments = Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.CurrentPracticeViewed].Practise.runs[selectedIndex].comments;
                string str = "Comments for lap " + (selectedIndex + 1).ToString() + "\r\n";
                for (int index = 0; index < comments.Length; ++index)
                {
                    str += comments[index];
                    if (index % 2 == 1 && index < comments.Length - 1)
                        str += "\r\n";
                    if (index % 2 == 0 && index < comments.Length - 1)
                        str += ": ";
                }
                this.textBoxPracComments.Text = str;
            }
        }

        private void menuItem17_Click(object sender, EventArgs e) => this.buttonExit_Click(sender, e);

        private void listViewSeason_DoubleClick(object sender, EventArgs e)
        {
            if (this.listViewSeason.SelectedIndices.Count == 0)
                return;
            int selectedIndex = this.listViewSeason.SelectedIndices[0];
            if (Datas.Seasons[Datas.INDEX_CURRENTSEASON] == null || !Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[selectedIndex].isRaceUpdated)
                return;
            new RaceForm(Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[selectedIndex], Datas.Tracks[Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[selectedIndex].Trackid - 1]).Show();
        }

        private void comboBoxPrac_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxPrac.SelectedIndex;
            this.buttonExport.Enabled = true;
            for (int seasonid = selectedIndex; seasonid < Datas.Date.race; ++seasonid)
            {
                string name = Datas.Tracks[Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[seasonid].Trackid - 1].name;
                string str = (string)this.comboBoxPrac.Items[selectedIndex];
                if (Datas.Tracks[Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[seasonid].Trackid - 1].name == (string)this.comboBoxPrac.Items[selectedIndex])
                {
                    this.FillPracticedata(Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[seasonid].Practise, seasonid);
                    break;
                }
            }
        }

        private void listViewSeason_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r')
                return;
            this.listViewSeason_DoubleClick(sender, (EventArgs)null);
        }

        private void menuItem11_Click_1(object sender, EventArgs e) => new SeasonForm().Show();

        private void menuItem18_Click(object sender, EventArgs e)
        {
            new HistoricalTyreWearForm().Show();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.listViewSeason.SelectedIndices[0];
            int index = Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[selectedIndex].Trackid - 1;
            new TrackNote(index, Datas.Tracks[index].name).Show();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            int num = this.comboBoxPrac.SelectedIndex;
            if (num < 0)
                num = 0;
            for (int index = num; index < Datas.Date.race; ++index)
            {
                string name = Datas.Tracks[Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].Trackid - 1].name;
                string text = this.comboBoxPrac.Text;
                if (Datas.Tracks[Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].Trackid - 1].name == text)
                {
                    new PracticeDataExport(Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index], Datas.Tracks[Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].Trackid - 1]).Show();
                    break;
                }
            }
        }

        private void menuItem13_Click_1(object sender, EventArgs e)
        {
            new CarHistoryForm(ref Datas.FormHandler, ref Datas.CarHistory).Show();
        }

        private void menuItem20_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(Datas.Communications.rememberPassword, Datas.AutoCheck, Datas.WarnWrongTyres, Datas.KeepDataWithApp);
            int num = (int)settings.ShowDialog();
            if (!settings.saveSettings)
                return;
            Datas.Communications.rememberPassword = settings.rememberPassword;
            Datas.AutoCheck = settings.autoCheck;
            Datas.WarnWrongTyres = settings.warn_for_wrong_tyres;
            Datas.KeepDataWithApp = settings.keep_data_with_program;
            this.SaveRegistrySettings();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void menuItem21_Click(object sender, EventArgs e) => this.UpdateAll();

        private void AddLine(ref string noget, string add)
        {
            switch (add.Length)
            {
                case 1:
                    noget += "  ";
                    break;
                case 2:
                    noget += " ";
                    break;
            }
            noget = noget + add + "\r\n";
        }

        private void AddLine(ref string noget, string add, string add2)
        {
            switch (add2.Length)
            {
                case 1:
                    add += "  ";
                    break;
                case 2:
                    add += " ";
                    break;
            }
            this.AddLine(ref noget, add + add2);
        }

        private void menuItem5_Click_1(object sender, EventArgs e)
        {
            string noget = "";
            this.AddLine(ref noget, Datas.Driver.name);
            this.AddLine(ref noget, "Overall: \t", Datas.Driver.overall.ToString());
            this.AddLine(ref noget, "Concentration:\t", Datas.Driver.concentration.ToString());
            this.AddLine(ref noget, "Talent:\t\t", Datas.Driver.talent.ToString());
            this.AddLine(ref noget, "Aggresiveness:\t", Datas.Driver.aggresiveness.ToString());
            this.AddLine(ref noget, "Experience:\t", Datas.Driver.experience.ToString());
            this.AddLine(ref noget, "Tech. Insight:\t", Datas.Driver.technicalInsight.ToString());
            this.AddLine(ref noget, "Stamina:\t", Datas.Driver.stamina.ToString());
            this.AddLine(ref noget, "Charisma:\t", Datas.Driver.charisma.ToString());
            this.AddLine(ref noget, "Motivation:\t", Datas.Driver.motivation.ToString());
            this.AddLine(ref noget, "Reputation:\t", Datas.Driver.reputation.ToString());
            this.AddLine(ref noget, "Weight:\t\t", Datas.Driver.weight.ToString());
            this.AddLine(ref noget, "Age: \t\t", Datas.Driver.age.ToString());
            Clipboard.SetDataObject((object)noget);
        }

        private void menuItemHistoricalFuel_Click(object sender, EventArgs e)
        {
            new HistoricalFuelConsumptionForm().Show();
        }

        private void menuItemPitStrategy_Click(object sender, EventArgs e)
        {
            if (Datas.Date.race == 18)
            {
                int num = (int)MessageBox.Show("Cannot show pit strategy, as there is no next race at the moment");
            }
            else
                new StrategyToolForm(ref Datas.Tracks[Datas.NextRace]).Show();
        }

        private void menuItemRaces_Click(object sender, EventArgs e) => new OldRacesForm().Show();

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "go.dat";
            saveFileDialog1.DefaultExt = "dat";
            saveFileDialog1.Filter = "GO data files | *.dat";
            SaveFileDialog saveFileDialog2 = saveFileDialog1;
            if (DialogResult.OK != saveFileDialog2.ShowDialog((IWin32Window)this))
                return;
            this.SaveData(saveFileDialog2.FileName);
        }

        private void menuItemFiscalReport_Click(object sender, EventArgs e)
        {
            new FinancesForm().Show();
        }

        private void menuItemAvgCarWear_Click(object sender, EventArgs e) => new CarWearForm().Show();

        private void ParseShortDate(string date, ref int year, ref int month, ref int day)
        {
            int length = date.IndexOf("/");
            day = int.Parse(date.Substring(0, length));
            string s = date.Substring(length + 1, date.IndexOf("-") - length - 1);
            month = int.Parse(s);
            year = int.Parse(date.Substring(date.IndexOf("-") + 1));
        }

        private void menuItemDriverTraining_Click(object sender, EventArgs e)
        {
            new DriverTrainingHistory().Show();
        }

        private void menuItemPitstops_Click(object sender, EventArgs e) => new PitstopsForm().Show();

        private void menuItemImport_Click(object sender, EventArgs e)
        {
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "\u00BD";
            openFileDialog1.DefaultExt = "dat";
            openFileDialog1.Filter = "GO data files | *.dat";
            OpenFileDialog openFileDialog2 = openFileDialog1;
            if (DialogResult.OK != openFileDialog2.ShowDialog((IWin32Window)this))
                return;
            this.LoadData(openFileDialog2.FileName);
        }

        private void buttonGetSummary_Click(object sender, EventArgs e) => this.UpdateLastRaceSummary();

        private void ToggleFunctionality(bool enable) => Datas.IsOkToUpdate = enable;

        private void listViewTesting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewTesting.SelectedIndices.Count == 0)
            {
                this.textBoxTestingComments.Text = "";
            }
            else
            {
                int selectedIndex = this.listViewTesting.SelectedIndices[0];
                string[] comments = Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[Datas.CurrentTestingViewed].Test.runs[selectedIndex].comments;
                string str = "Comments for lap " + (selectedIndex + 1).ToString() + "\r\n";
                for (int index = 0; index < comments.Length; ++index)
                {
                    str += comments[index];
                    if (index % 2 == 1 && index < comments.Length - 1)
                        str += "\r\n";
                    if (index % 2 == 0 && index < comments.Length - 1)
                        str += ": ";
                }
                this.textBoxTestingComments.Text = str;
            }
        }

        private void menuItemHistoricalPractice_Click(object sender, EventArgs e)
        {
            new HistoricalPracticeForm().Show();
        }

        private void practiceHelperMenuItem_Click(object sender, EventArgs e)
        {
            new PracticeHelperForm(Datas.Communications, ref Datas.Driver).Show();
        }

        private void MniParseAllDatas(object sender, EventArgs e) => this.UpdateAll();

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized != this.WindowState)
                return;
            try
            {
                this.notifyIconGO.Visible = true;
                this.Hide();
            }
            catch (NullReferenceException ex)
            {
            }
        }

        private void notifyIconGO_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIconGO.Visible = false;
        }

        private void menuItemNotificationOpen_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIconGO.Visible = false;
        }

        private void menuItemHistoricalRaceSetup_Click(object sender, EventArgs e)
        {
            new HistoricalRaceSetupForm().Show();
        }

        private void menuItemHistoricalWear_Click(object sender, EventArgs e)
        {
            new HistoricalWearForm().Show();
        }

        private void menuItemHistoricalQ1Setup_Click(object sender, EventArgs e)
        {
            new HistoricalQ1SetupForm().Show();
        }

        private void CheckVersion()
        {
            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(Datas.Communications.GetVersion());
            MatchCollection valuesMatch = MainForm.reg.Matches(rootObject.platform_releases.windows.filename);

            int major = valuesMatch.Count > 0 && int.TryParse(valuesMatch[0].Value.TrimEnd('.'), out int ma) ? ma : 0;
            int minor = valuesMatch.Count > 1 && int.TryParse(valuesMatch[1].Value.TrimEnd('.'), out int mi) ? mi : 0;
            int build = valuesMatch.Count > 2 && int.TryParse(valuesMatch[2].Value.TrimEnd('.'), out int b) ? b : 0;
            int rev = valuesMatch.Count > 3 && int.TryParse(valuesMatch[3].Value.TrimEnd('.'), out int r) ? r : 0;

            Version detectedVersion = new Version(major, minor, build, rev);
            Version currentVersion = Datas.Version;

            var isLatestVersion = currentVersion >= detectedVersion;

            if (isLatestVersion)
            {
                this.statusBarPanelVersion.Text = "Latest version";
            }
            else
            {
                this.statusBarPanelVersion.Text = "New version available";
                new NewVersion(Datas.Communications.GetReadme()).Show();
            }
        }

        private void MniSaveClick(object sender, EventArgs e) => this.SaveData();

        private void MniOpenClick(object sender, EventArgs e) => this.OpenFile();

        private void MniMergeClick(object sender, EventArgs e)
        {
        }

        private void mniExitClick(object sender, EventArgs e) => this.Close();

        private void MniCheckUpdateClick(object sender, EventArgs e) => this.CheckVersion();
    }
}
