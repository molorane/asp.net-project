using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;

/// <summary>
/// Summary description for CProviderBase
/// </summary>
public abstract class CProviderBase
{
    static private CProviderBase tpbInstance = null;

    static public CProviderBase Instance
    {
        get
        {
            if (tpbInstance == null)
            {
                tpbInstance = new CSqlProvider();
            }
            return tpbInstance;
        }
    }

    // -------------------------------------------------------
    // Abstract methods to provide an interface for functionalities
    //   that can be done on tools
    // -------------------------------------------------------

    //Payment
    public abstract int AddPayment(int TTID, decimal Pay_Amount);
    
    //TollTransaction
    public abstract int AddTollTransaction(string TTVehicleRegistration, int GantryID);
    public abstract List<CTollTransactionDetails> GetTollTransactions();
    public abstract List<CTollTransactionDetails> NinetyDayUnpaidReport();

    //TollRate
    public abstract List<CTollRateDetails> GetTollRates();

    //Gantry
    public abstract CGantryDetails GetGantry(int GantryID);
    public abstract List<CGantryDetails> GetGantries();
    public abstract int MaintainGantry(int GantryID, string Gantry_Name, string Gantry_Desc, 
        string Gantry_GPSLocation, int TRateID, int ROfficeID);

    //Vehicle
    public abstract List<CVehicleDetails> GetCustomerVehicles(int CustomerID);
    public abstract int MaintainVehicle(int VehicleID, string Vehicle_Make, string Vehicle_Model, string Vehicle_Registration, int CustomerID);
    public abstract int DeleteVehicle(int VehicleID);

    //Region
    public abstract List<CRegionDetails> GetRegions();
    public abstract List<CRegionDetails> OutstandingTollsReport();
    public abstract List<CRegionDetails> PopularRegionReport(DateTime StartDate, DateTime EndDate);

    //Customer
    public abstract CCustomerDetails GetCustomer(int CustomerID);
    public abstract int AddCustomer(string Cus_FName, string Cus_LName, 
        string Cus_ContactNumber, string Cus_IDNumber, string Cus_ProfilePic);
    public abstract int UpdateCustomer(int CustomerID, string Cus_FName, string Cus_LName, string Cus_ContactNumber, string Cus_IDNumber, string Cus_ProfilePic);
    public abstract bool ValidateCustomerIDNumber(string IDNumber);
    public abstract string DailyReminder(int CustomerID);
    public abstract List<CCustomerDetails> SearchSurname(string LName);

    // -------------------------------------------------------
    // Conversion methods for using DataReaders
    // -------------------------------------------------------

    #region TollTransaction
    protected CTollTransactionDetails GetTollTransactionDetailsFromReader(IDataReader reader)
    {
        return new CTollTransactionDetails(
            (int)reader["TTID"],
            (DateTime)reader["TT_DateTime"],
            (decimal)reader["TT_Amount"],
            (bool)reader["TT_IsPaid"],
            (string)reader["TT_VehicleRegistration"],
            (string)reader["FullName"]);

    }

    // Converting a list of objects
    protected List<CTollTransactionDetails> GetTollTransactionDetailsCollectionFromReader(IDataReader reader)
    {
        List<CTollTransactionDetails> ttransactions = new List<CTollTransactionDetails>();
        while (reader.Read())
            ttransactions.Add(GetTollTransactionDetailsFromReader(reader));
        return ttransactions;
    }
    protected CTollTransactionDetails GetTollTransactionDetails_Unpaid_FromReader(IDataReader reader)
    {
        return new CTollTransactionDetails(
            (DateTime)reader["TT_DateTime"],
            (decimal)reader["TT_Amount"],
            (string)reader["TT_VehicleRegistration"],
            (string)reader["FullName"]);

    }

    // Converting a list of objects
    protected List<CTollTransactionDetails> GetTollTransactionDetails_Unpaid_CollectionFromReader(IDataReader reader)
    {
        List<CTollTransactionDetails> ttransactions = new List<CTollTransactionDetails>();
        while (reader.Read())
            ttransactions.Add(GetTollTransactionDetails_Unpaid_FromReader(reader));
        return ttransactions;
    }
    #endregion

    #region TollRate
    protected CTollRateDetails GetTollRateDetailsFromReader(IDataReader reader)
    {
        return new CTollRateDetails(
            (int)reader["TRateID"],
            (decimal)reader["TRate_Amount"]);

    }

    // Converting a list of objects
    protected List<CTollRateDetails> GetTollRateDetailsCollectionFromReader(IDataReader reader)
    {
        List<CTollRateDetails> tollrates = new List<CTollRateDetails>();
        while (reader.Read())
            tollrates.Add(GetTollRateDetailsFromReader(reader));
        return tollrates;
    }
    #endregion

    #region Gantry
    protected CGantryDetails GetGantryDetails_Complete_FromReader(IDataReader reader)
    {
        return new CGantryDetails(
            (int)reader["GantryID"],
            (string)reader["Gantry_Name"],
            reader["Gantry_Desc"] == DBNull.Value ? "" : (string)reader["Gantry_Desc"],
            reader["Gantry_GPSLocation"] == DBNull.Value ? "" : (string)reader["Gantry_GPSLocation"],
            (int)reader["TRateID"],
            (int)reader["ROfficeID"]);

    }

    protected CGantryDetails GetGantryDetailsFromReader(IDataReader reader)
    {
        return new CGantryDetails(
            (int)reader["GantryID"],
            (string)reader["Gantry_Name"]);

    }

    // Converting a list of objects
    protected List<CGantryDetails> GetGantryDetailsCollectionFromReader(IDataReader reader)
    {
        List<CGantryDetails> gantries = new List<CGantryDetails>();
        while (reader.Read())
            gantries.Add(GetGantryDetailsFromReader(reader));
        return gantries;
    }
    #endregion

    #region Region
    protected CRegionDetails GetRegionDetailsFromReader(IDataReader reader)
    {
        return new CRegionDetails(
            (int)reader["ROfficeID"],
            (string)reader["ROffice_Name"]);

    }

    // Converting a list of objects
    protected List<CRegionDetails> GetRegionDetailsCollectionFromReader(IDataReader reader)
    {
        List<CRegionDetails> regions = new List<CRegionDetails>();
        while (reader.Read())
            regions.Add(GetRegionDetailsFromReader(reader));
        return regions;
    }

    
    protected CRegionDetails GetRegionDetails_OutstandingTolls_FromReader(IDataReader reader)
    {
        return new CRegionDetails(
            (int)reader["ROfficeID"],
            (string)reader["ROffice_Name"],
            (decimal)reader["TotalOutstanding"]);
    }

    // Converting a list of objects
    protected List<CRegionDetails> GetRegionDetailsCollection_OutstandingTolls_FromReader(IDataReader reader)
    {
        List<CRegionDetails> regions = new List<CRegionDetails>();
        while (reader.Read())
            regions.Add(GetRegionDetails_OutstandingTolls_FromReader(reader));
        return regions;
    }

    protected CRegionDetails GetRegionDetails_Popular_FromReader(IDataReader reader)
    {
        return new CRegionDetails(
            (int)reader["ROfficeID"],
            (string)reader["ROffice_Name"],
            (int)reader["NumberOfTolls"]);

    }

    // Converting a list of objects
    protected List<CRegionDetails> GetRegionDetailsCollection_Popular_FromReader(IDataReader reader)
    {
        List<CRegionDetails> regions = new List<CRegionDetails>();
        while (reader.Read())
            regions.Add(GetRegionDetails_Popular_FromReader(reader));
        return regions;
    }

    #endregion

    #region Customer
    protected CCustomerDetails GetCustomerDetailsFromReader(IDataReader reader)
    {
        return new CCustomerDetails(
            (int)reader["CustomerID"],
            (string)reader["Cus_FName"],
            (string)reader["Cus_LName"],
            (string)reader["Cus_ContactNumber"],
            (string)reader["Cus_IDNumber"],
            (reader["Cus_ProfilePic"] == DBNull.Value ? "" : (string)reader["Cus_ProfilePic"]));
    }

    protected CCustomerDetails GetCustomerDetails_BySurname_FromReader(IDataReader reader)
    {
        return new CCustomerDetails(
            (int)reader["CustomerID"],
            (string)reader["Cus_FName"],
            (string)reader["Cus_LName"],
            (string)reader["Cus_ContactNumber"],
            (reader["Cus_ProfilePic"] == DBNull.Value ? "" : (string)reader["Cus_ProfilePic"]));
    }

    // Converting a list of objects
    protected List<CCustomerDetails> GetCustomerDetailsCollection_BySurname_FromReader(IDataReader reader)
    {
        List<CCustomerDetails> customers = new List<CCustomerDetails>();
        while (reader.Read())
            customers.Add(GetCustomerDetails_BySurname_FromReader(reader));
        return customers;
    }
    #endregion

    #region Vehicle
    protected CVehicleDetails GetVehicleDetailsFromReader(IDataReader reader)
    {
        return new CVehicleDetails(
            (int)reader["VehicleID"],
            (string)reader["Vehicle_Make"],
            (string)reader["Vehicle_Model"],
            (string)reader["Vehicle_Registration"]);

    }

    // Converting a list of objects
    protected List<CVehicleDetails> GetVehicleDetailsCollectionFromReader(IDataReader reader)
    {
        List<CVehicleDetails> regions = new List<CVehicleDetails>();
        while (reader.Read())
            regions.Add(GetVehicleDetailsFromReader(reader));
        return regions;
    }
    #endregion
}