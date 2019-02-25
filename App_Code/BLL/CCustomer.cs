using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Security;
/// <summary>
/// Summary description for CCustomer
/// </summary>
public class CCustomer
{
    #region Private Data Members
    private int iCustomerID;
    private string sCus_FName;
    private string sCus_LName;
    private string sCus_ContactNumber;
    private string sCus_IDNumber;
    private string sCus_ProfilePic;
    #endregion

    #region Constructors
    //Constructor for GetCutomer
    public CCustomer(int _iCustomerID, string _sCus_FName,
    string _sCus_LName, string _sCus_ContactNumber,
    string _sCus_IDNumber, string _sCus_ProfilePic)
    {
        this.CustomerID = _iCustomerID;
        this.Cus_FName = _sCus_FName;
        this.Cus_LName = _sCus_LName;
        this.Cus_ContactNumber = _sCus_ContactNumber;
        this.Cus_IDNumber = _sCus_IDNumber;
        this.Cus_ProfilePic = _sCus_ProfilePic;
    }

    //Constructor for SearchSurname
    public CCustomer(int _iCustomerID, string _sCus_FName,
        string _sCus_LName, string _sCus_ContactNumber, string _sCus_ProfilePic)
    {
        this.CustomerID = _iCustomerID;
        this.Cus_FName = _sCus_FName;
        this.Cus_LName = _sCus_LName;
        this.Cus_ContactNumber = _sCus_ContactNumber;
        this.Cus_ProfilePic = _sCus_ProfilePic;
    }
    #endregion

    #region Public Properties
    public int CustomerID
    {
        get
        {
            return iCustomerID;
        }
        set
        {
            iCustomerID = value;
        }
    }
    public string Cus_FName
    {
        get
        {
            return sCus_FName;
        }
        set
        {
            sCus_FName = value;
        }
    }
    public string Cus_LName
    {
        get
        {
            return sCus_LName;
        }
        set
        {
            sCus_LName = value;
        }
    }
    public string Cus_ContactNumber
    {
        get
        {
            return sCus_ContactNumber;
        }
        set
        {
            sCus_ContactNumber = value;
        }
    }

    public string Cus_IDNumber
    {
        get
        {
            return sCus_IDNumber;
        }
        set
        {
            sCus_IDNumber = value;
        }
    }

    public string Cus_ProfilePic
    {
        get
        {
            return sCus_ProfilePic;
        }
        set
        {
            sCus_ProfilePic = value;
        }
    }

    #endregion

    #region Static Methods
    public static int AddCustomer(string Cus_FName, string Cus_LName, string Cus_ContactNumber,
        string Cus_IDNumber, string Cus_ProfilePic)
    {
        return CProviderBase.Instance.AddCustomer(Cus_FName, Cus_LName, Cus_ContactNumber, Cus_IDNumber, Cus_ProfilePic);
    }

    public static string DailyReminder(int CustomerID)
    {
        return CProviderBase.Instance.DailyReminder(CustomerID);
    }

    public static CCustomer GetCustomer(int CustomerID)
    {
        return GetCustomerFromCustomerDetail(CProviderBase.Instance.GetCustomer(CustomerID));
    }


    public static List<CCustomer> SearchSurname(string LName)
    {
        return GetCustomerList_BySurname_FromCustomerDetailList(CProviderBase.Instance.SearchSurname(LName));
    }

    public static int UpdateCustomer(int CustomerID,string Cus_FName, string Cus_LName, string Cus_ContactNumber,
        string Cus_IDNumber, string Cus_ProfilePic)
    {
        return CProviderBase.Instance.UpdateCustomer(CustomerID, Cus_FName, Cus_LName, Cus_ContactNumber, Cus_IDNumber, Cus_ProfilePic);
    }

    public static bool ValidateCustomerIDNumber(string IDNumber)
    {
        return CProviderBase.Instance.ValidateCustomerIDNumber(IDNumber);
    }

    #endregion

    #region Conversion Methods

    private static List<CCustomer> GetCustomerList_BySurname_FromCustomerDetailList(List<CCustomerDetails> _CustomerDetailObjectList)
    {
        List<CCustomer> Customers = new List<CCustomer>();
        foreach (CCustomerDetails CustomerDetailObject in _CustomerDetailObjectList)
        {
            Customers.Add(GetCustomer_BySurname_FromCustomerDetail(CustomerDetailObject));
        }
        return Customers;
    }

    private static CCustomer GetCustomer_BySurname_FromCustomerDetail(CCustomerDetails _CustomerDetailObject)
    {
        if (_CustomerDetailObject == null)
            return null;
        else
        {
            return new CCustomer(_CustomerDetailObject.CustomerID,
                _CustomerDetailObject.Cus_FName,
                _CustomerDetailObject.Cus_LName,
                _CustomerDetailObject.Cus_ContactNumber,
                _CustomerDetailObject.Cus_ProfilePic);
        }
    }

    private static CCustomer GetCustomerFromCustomerDetail(CCustomerDetails _CustomerDetailObject)
    {
        if (_CustomerDetailObject == null)
            return null;
        else
        {
            return new CCustomer(_CustomerDetailObject.CustomerID,
                _CustomerDetailObject.Cus_FName,
                _CustomerDetailObject.Cus_LName,
                _CustomerDetailObject.Cus_ContactNumber,
                _CustomerDetailObject.Cus_IDNumber,
                _CustomerDetailObject.Cus_ProfilePic);
        }
    }

    #endregion


}