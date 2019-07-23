using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Data;

using System.Windows.Forms;

namespace Project
{
    class DataHandler
    {
        //Data Source=LAPTOP-7U58G0UA\SQLEXPRESS;Initial Catalog=DBProject252_MilitarySimilation;Integrated Security=True
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();

        public DataHandler()
        {
            connection.DataSource = @"LAPTOP-7U58G0UA\SQLEXPRESS";
            connection.InitialCatalog = "DBProject252_MilitarySimilation";
            connection.IntegratedSecurity = true;
        }

        public DataSet ReadData(string tblName)
        {
            DataSet rawData = new DataSet();
            SqlConnection connect = new SqlConnection(connection.ToString());
            string qry = string.Format("SELECT * FROM {0}", tblName);

            try
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, connect);
                adapter.FillSchema(rawData, SchemaType.Source, tblName);
                adapter.Fill(rawData, tblName);
                connect.Close();
            }
            catch (SqlException se)
            {

                MessageBox.Show(se.Message);
            }
            finally
            {
                if (connect.State==ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return rawData;
        }
        //UPDATE The WEAPON INVENTORY
        public int UpdateWeapons(double Weight,int CargoID)
        {
            SqlConnection connect = new SqlConnection(connection.ToString());
            string qry = string.Format("UPDATE tblCargo SET Weight=@Weight WHERE CargoID=@ID");
            int changingRow=0;
            try
            {
                SqlCommand command = new SqlCommand(qry, connect);
                command.Parameters.AddWithValue("@Weight", Weight);
                command.Parameters.AddWithValue("@ID", CargoID);
                connect.Open();
                changingRow = command.ExecuteNonQuery();


               
            }
            catch (SqlException se)
            {

                MessageBox.Show(se.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
               
            }
            return changingRow;
        }
        // Update Aircraft Fuel
        public int UpdateFuel(int AircraftID,int Fuel)
        {
            SqlConnection connect = new SqlConnection(connection.ToString());
            string qry = string.Format("UPDATE tblCargo SET FuelLevel=@Fuel WHERE AircraftID=@ID");
            int changingRow = 0;
            try
            {
                SqlCommand command = new SqlCommand(qry, connect);
                command.Parameters.AddWithValue("@Fuel", Fuel);
                command.Parameters.AddWithValue("@ID", AircraftID);
                connect.Open();
                changingRow = command.ExecuteNonQuery();



            }
            catch (SqlException se)
            {

                MessageBox.Show(se.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }

            }
            return changingRow;
        }
        //Add Reports
       
        public int SafelyAddAndSaveReport(int damage, int successRate, string timeOfStrike, string locationTargeted, string locationHit, string targetChosen, int inventoryStatus, int fuelStatus)
        {
            SqlConnection connect = new SqlConnection(connection.ToString());
            string qry = string.Format("INSERT INTO tblReport(Damage, SuccessRate, TargetChosen, TimeOfStrike, LocationTargeted, LocationHit, InventoryStatus, FuelStatus) VALUES(@DamageDone, @SuccessRate, @TargetChosen, @TimeofStrike, @LocationTargeted, @LocationHit, @InventoryStatus, @FuelStatus");
            int InsertRow = 0;
            try
            {
                SqlCommand command = new SqlCommand(qry, connect);
                command.Parameters.AddWithValue("@DamageDone", damage);
                command.Parameters.AddWithValue("@SuccessRate", successRate);
                command.Parameters.AddWithValue("@TimeofStrike", timeOfStrike);
                command.Parameters.AddWithValue("@LocationTargeted", locationTargeted);
                command.Parameters.AddWithValue("@LocationHit", locationHit);
                command.Parameters.AddWithValue("@TargetChosen", targetChosen);
                command.Parameters.AddWithValue("@InventoryStatus", inventoryStatus);
                command.Parameters.AddWithValue("@FuelStatus", fuelStatus);

                connect.Open();
                InsertRow = command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                MessageBox.Show(se.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }

            }
            return InsertRow;
        }

    }
}
