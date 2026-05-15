using go.Comms;
using go.Forms;
using go.History;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace go.Utils
{
    internal static class Datas
    {
        public static string Username = "";
        public static string Password = "";
        public static Communication Communications = new Communication();
        internal static Version Version = Assembly.GetExecutingAssembly().GetName().Version;
        public static bool AutoCheck;
        public static bool KeepDataWithApp;
        public static bool IsOkToUpdate = true;
        public static bool WarnWrongTyres = true;
        public static bool DataChanged;
        public static Track[] Tracks;
        public static Car2 Car = new Car2();
        public static Date Date = new Date();
        public static CarHistory2 CarHistory = new CarHistory2();
        public static Driver5 Driver = new Driver5();
        public static ArrayList OldDrivers = new ArrayList();
        public static ArrayList FinanceHistory = new ArrayList();
        public static Staff Staff = new Staff();
        public static ArrayList StaffHistory = new ArrayList();
        public static TechnicalDirector TechnicalDirector = new TechnicalDirector();
        public static ArrayList OldTechnicalDirectors = new ArrayList();
        public static Manager Manager = new Manager();
        public static int INDEX_CURRENTSEASON;
        public static string[] TrackNotes;
        public static bool OkToFillPractice = true;
        public static int NextRace = -1;
        public static int CurrentPracticeViewed;
        public static int CurrentTestingViewed;
        public static int LastTabViewed;
        public static FormHandler FormHandler = new FormHandler();

        public static List<Season20> Seasons { get; set; }

        public static Track GetTrack(int id)
        {
            if (Tracks == null || id <= 0 || id > Tracks.Length)
                return null;
        
            return Tracks[id - 1];
        }

        internal static void InitialiseInternalvariables()
        {
            Datas.DataChanged = false;
            Datas.Car = new Car2();
            Datas.Date = new Date();
            Datas.CarHistory = new CarHistory2();
            Datas.Driver = new Driver5();
            Datas.OldDrivers = new ArrayList();
            Datas.FinanceHistory = new ArrayList();
            Datas.Staff = new Staff();
            Datas.StaffHistory = new ArrayList();
            Datas.TechnicalDirector = new TechnicalDirector();
            Datas.OldTechnicalDirectors = new ArrayList();
            Datas.INDEX_CURRENTSEASON = 0;
            Datas.OkToFillPractice = true;
            Datas.NextRace = -1;
            Datas.CurrentPracticeViewed = 0;
            Datas.CurrentTestingViewed = 0;
            Datas.LastTabViewed = 0;
            Datas.FormHandler = new FormHandler();
        }
    }
}
