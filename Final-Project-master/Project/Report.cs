using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Report
    {
        private int reportID;
        private int damage;
        private int successRate;
        private string timeOfStrike;
        private string locationTargeted;
        private string LocationHit;
        private string targetChosen;
        private int inventoryStatus;
        private int fuelStatus;



        public int ReportID { get => reportID; set => reportID = value; }
        public int Damage { get => damage; set => damage = value; }
        public int SuccessRate { get => successRate; set => successRate = value; }
        public string TimeOfStrike { get => timeOfStrike; set => timeOfStrike = value; }
        public string LocationTargeted { get => locationTargeted; set => locationTargeted = value; }
        public string LocationHit1 { get => LocationHit; set => LocationHit = value; }
        public string TargetChosen { get => targetChosen; set => targetChosen = value; }
        public int InventoryStatus { get => inventoryStatus; set => inventoryStatus = value; }
        public int FuelStatus { get => fuelStatus; set => fuelStatus = value; }

        public Report()
        {

        }
        public Report(int reportID, int damage, int successRate, string timeOfStrike, string locationTargeted, string locationHit, string targetChosen, int inventoryStatus, int fuelStatus)
        {
            this.reportID = reportID;
            this.damage = damage;
            this.successRate = successRate;
            this.timeOfStrike = timeOfStrike;
            this.locationTargeted = locationTargeted;
            LocationHit = locationHit;
            this.targetChosen = targetChosen;
            this.inventoryStatus = inventoryStatus;
            this.fuelStatus = fuelStatus;
        }
        public List<Report> GetAllReports()
        {
            List<Report> reports = new List<Report>();
            DataHandler dh = new DataHandler();
            DataSet data = dh.ReadData("tblReport");

            foreach (DataRow item in data.Tables["tblReport"].Rows)
            {
                reports.Add(
                    new Report(
                        int.Parse(item["ReportID"].ToString()),
                        int.Parse(item["Damage"].ToString()),
                          int.Parse(item["SuccessRate"].ToString()),
                          item["TimeOfStrike"].ToString(),
                          item["LocationTarget"].ToString(),
                          item["LocationHit"].ToString(),
                          item["TargetChosen"].ToString(),
                           int.Parse(item["InventoryStatus"].ToString()),
                            int.Parse(item["Fuelstatus"].ToString())));
            }
            return reports;
        }
        public int SafelyinsertAndSaveReport(int damage, int successRate, string timeOfStrike, string locationTargeted, string locationHit, string targetChosen, int inventoryStatus, int fuelStatus)
        {
            DataHandler dh = new DataHandler();
            int inserting = dh.SafelyAddAndSaveReport(damage,successRate,timeOfStrike,locationTargeted,locationHit,targetChosen,inventoryStatus,fuelStatus);
            return inserting;
        }
    }
}
