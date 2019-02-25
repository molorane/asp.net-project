using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for SqlProvider
/// </summary>
public class CSqlProvider: CProviderBase
{

    #region Payment
    //Payment
    public override int AddPayment(int TTID, decimal Pay_Amount)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("AddPayment", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters
            cmd.Parameters.Add("TTID", SqlDbType.Int).Value = TTID;
            cmd.Parameters.Add("Pay_Amount", SqlDbType.Decimal).Value = Pay_Amount;

            // Step 5 - no data returned from database 

            // Step 6 - Execute the command/query 
            return cmd.ExecuteNonQuery();

        }
    }
    #endregion

    #region TollTransaction

    public override int AddTollTransaction(string TTVehicleRegistration, int GantryID)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("AddTollTransaction", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters
            cmd.Parameters.Add("TTVehicleRegistration", SqlDbType.VarChar, 50).Value = TTVehicleRegistration;
            cmd.Parameters.Add("GantryID", SqlDbType.Int).Value = GantryID;

            // Step 5 - no data returned from database 

            // Step 6 - Execute the command/query 
            return cmd.ExecuteNonQuery();

        }
    }
    public override List<CTollTransactionDetails> GetTollTransactions()
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("GetTollTransactions", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters - there is none

            // Step 5 - Execute the command/query and store in reader object
            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // Step 6 - convert objects in reader to detail object list
            return GetTollTransactionDetailsCollectionFromReader(reader);
        }
    }
    public override List<CTollTransactionDetails> NinetyDayUnpaidReport()
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("NinetyDayUnpaidReport", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters - there is none

            // Step 5 - Execute the command/query and store in reader object
            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // Step 6 - convert objects in reader to detail object list
            return GetTollTransactionDetails_Unpaid_CollectionFromReader(reader);
        }
    }

    #endregion

    #region TollRates
    public override List<CTollRateDetails> GetTollRates()
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("GetTollRates", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters - there is none

            // Step 5 - Execute the command/query and store in reader object
            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // Step 6 - convert objects in reader to detail object list
            return GetTollRateDetailsCollectionFromReader(reader);
        }
    }
    #endregion

    #region Gantry
    public override CGantryDetails GetGantry(int GantryID)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].
          ConnectionString))
        {
            conn.Open();
            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("GetGantry", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters 
            cmd.Parameters.Add("GantryID", SqlDbType.Int).Value = GantryID;

            // Step 5 - Execute the command/query and store in reader object
            IDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

            // Step 6 - convert object in reader to detail object 
            if (reader.Read())
                return GetGantryDetails_Complete_FromReader(reader);
            else
                return null;
        }
    }
    public override List<CGantryDetails> GetGantries()
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("GetGantries", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters - there is none

            // Step 5 - Execute the command/query and store in reader object
            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // Step 6 - convert objects in reader to detail object list
            return GetGantryDetailsCollectionFromReader(reader);
        }
    }

    public override int MaintainGantry(int GantryID, string Gantry_Name, 
        string Gantry_Desc, string Gantry_GPSLocation, int TRateID, int ROfficeID)
    {

        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("MaintainGantry", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters
            cmd.Parameters.Add("GantryID", SqlDbType.Int).Value = GantryID;
            cmd.Parameters.Add("Gantry_Name", SqlDbType.VarChar, 50).Value = Gantry_Name;
            cmd.Parameters.Add("Gantry_Desc", SqlDbType.VarChar, 200).Value = Gantry_Desc;
            cmd.Parameters.Add("Gantry_GPSLocation", SqlDbType.VarChar, 50).Value = Gantry_GPSLocation;
            cmd.Parameters.Add("TRateID", SqlDbType.Int).Value = TRateID;
            cmd.Parameters.Add("ROfficeID", SqlDbType.Int).Value = ROfficeID;

            // Step 5 - no data returned from database 

            // Step 6 - Execute the command/query 
            return cmd.ExecuteNonQuery();
        }

    }
    #endregion

    #region Vehicle
    public override List<CVehicleDetails> GetCustomerVehicles(int CustomerID)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("GetCustomerVehicles", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters
            cmd.Parameters.Add("CustomerID", SqlDbType.Int).Value = CustomerID;

            // Step 5 - Execute the command/query and store in reader object
            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // Step 6 - convert objects in reader to detail object list
            return GetVehicleDetailsCollectionFromReader(reader);
        }
    }
    public override int MaintainVehicle(int VehicleID, string Vehicle_Make, 
        string Vehicle_Model, string Vehicle_Registration, int CustomerID)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("MaintainVehicle", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters
            cmd.Parameters.Add("VehicleID", SqlDbType.Int).Value = VehicleID;
            cmd.Parameters.Add("VehicleMake", SqlDbType.VarChar, 30).Value = Vehicle_Make;
            cmd.Parameters.Add("VehicleModel", SqlDbType.VarChar, 100).Value = Vehicle_Model;
            cmd.Parameters.Add("VehicleRegistration", SqlDbType.VarChar, 10).Value = Vehicle_Registration;
            cmd.Parameters.Add("CustomerID", SqlDbType.Int).Value = CustomerID;

            // Step 5 - no data returned from database 

            // Step 6 - Execute the command/query 
            return cmd.ExecuteNonQuery();
        }
    }

    public override int DeleteVehicle(int VehicleID)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("DeleteVehicle", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters
            cmd.Parameters.Add("VehicleID", SqlDbType.Int).Value = VehicleID;

            // Step 5 - no data returned from database 

            // Step 6 - Execute the command/query 
            return cmd.ExecuteNonQuery();
        }
    }
    #endregion

    #region Region
    public override List<CRegionDetails> GetRegions()
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("GetRegions", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters - there is none

            // Step 5 - Execute the command/query and store in reader object
            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // Step 6 - convert objects in reader to detail object list
            return GetRegionDetailsCollectionFromReader(reader);
        }
    }
    public override List<CRegionDetails> OutstandingTollsReport()
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("OutstandingTollsReport", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters - there is none

            // Step 5 - Execute the command/query and store in reader object
            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // Step 6 - convert objects in reader to detail object list
            return GetRegionDetailsCollection_OutstandingTolls_FromReader(reader);
        }
    }
    public override List<CRegionDetails> PopularRegionReport(DateTime StartDate, 
        DateTime EndDate)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("PopularRegionReport", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters 
            cmd.Parameters.Add("StartDate", SqlDbType.DateTime).Value = StartDate;
            cmd.Parameters.Add("EndDate", SqlDbType.DateTime).Value = EndDate;

            // Step 5 - Execute the command/query and store in reader object
            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // Step 6 - convert objects in reader to detail object list
            return GetRegionDetailsCollection_Popular_FromReader(reader);
        }
    }

    #endregion

    #region Customer
    public override int AddCustomer(string Cus_FName, string Cus_LName, 
        string Cus_ContactNumber, string Cus_IDNumber, string Cus_ProfilePic)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("AddCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters
            cmd.Parameters.Add("@Cus_FName", SqlDbType.VarChar, 50).Value = Cus_FName;
            cmd.Parameters.Add("@Cus_LName", SqlDbType.VarChar, 50).Value = Cus_LName;
            cmd.Parameters.Add("@Cus_ContactNumber", SqlDbType.VarChar, 50).Value = Cus_ContactNumber;
            cmd.Parameters.Add("@Cus_IDNumber", SqlDbType.VarChar, 13).Value = Cus_IDNumber;
            cmd.Parameters.Add("@Cus_ProfilePic", SqlDbType.VarChar, 300).Value = Cus_ProfilePic;
            cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Direction = ParameterDirection.Output;

            // Step 5 - no data returned from database 

            // Step 6 - Execute the command/query 
            cmd.ExecuteNonQuery();

            return (int)cmd.Parameters["@CustomerID"].Value;
        }
    }
    public override int UpdateCustomer(int CustomerID, string Cus_FName, 
        string Cus_LName, string Cus_ContactNumber, string Cus_IDNumber, string Cus_ProfilePic)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("UpdateCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters
            cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = CustomerID;
            cmd.Parameters.Add("@Cus_FName", SqlDbType.VarChar, 50).Value = Cus_FName;
            cmd.Parameters.Add("@Cus_LName", SqlDbType.VarChar, 50).Value = Cus_LName;
            cmd.Parameters.Add("@Cus_ContactNumber", SqlDbType.VarChar, 50).Value = Cus_ContactNumber;
            cmd.Parameters.Add("@Cus_IDNumber", SqlDbType.VarChar, 13).Value = Cus_IDNumber;
            cmd.Parameters.Add("@Cus_ProfilePic", SqlDbType.VarChar, 300).Value = Cus_ProfilePic;
            // Step 5 - no data returned from database 

            // Step 6 - Execute the command/query 
            return cmd.ExecuteNonQuery();

        }
    }

    public override bool ValidateCustomerIDNumber(string IDNumber)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("ValidateCustomerIDNumber", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters
            cmd.Parameters.Add("@IDNumber", SqlDbType.VarChar, 13).Value = IDNumber;
            cmd.Parameters.Add("@IsValid", SqlDbType.Bit).Direction = ParameterDirection.Output;

            // Step 5 - no data returned from database 

            // Step 6 - Execute the command/query 
            cmd.ExecuteNonQuery();

            return (bool)cmd.Parameters["@IsValid"].Value;
        }
    }
    public override string DailyReminder(int CustomerID)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].
          ConnectionString))
        {
            conn.Open();
            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("DailyReminder", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters 
            cmd.Parameters.Add("CustomerID", SqlDbType.Int).Value = CustomerID;
            cmd.Parameters.Add("Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            return (cmd.Parameters["Message"].Value == DBNull.Value? "" : (string)cmd.Parameters["Message"].Value);

            //return (string)cmd.Parameters["Message"].Value;

            //// Step 5 - Execute the command/query and store in reader object
            //IDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

            //// Step 6 - convert object in reader to detail object 
            //if (reader.Read())
            //    return (string)reader["Message"];
            //else
            //    return null;
        }

    }
    public override List<CCustomerDetails> SearchSurname(string LName)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].ConnectionString))
        {
            conn.Open();

            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("SearchSurname", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters 
            cmd.Parameters.Add("LName", SqlDbType.NVarChar, 50).Value = LName;

            // Step 5 - Execute the command/query and store in reader object
            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // Step 6 - convert objects in reader to detail object list
            return GetCustomerDetailsCollection_BySurname_FromReader(reader);
        }
    }

    public override CCustomerDetails GetCustomer(int CustomerID)
    {
        // Step 2 - Defining the connection object and open it
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["UBT_Data_ConnectionString"].
          ConnectionString))
        {
            conn.Open();
            // Step 3 - Defining the command
            SqlCommand cmd = new SqlCommand("GetCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Step 4 - Initialize parameters 
            cmd.Parameters.Add("CustomerID", SqlDbType.Int).Value = CustomerID;

            // Step 5 - Execute the command/query and store in reader object
            IDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

            // Step 6 - convert object in reader to detail object 
            if (reader.Read())
                return GetCustomerDetailsFromReader(reader);
            else
                return null;
        }
    }
    #endregion

}