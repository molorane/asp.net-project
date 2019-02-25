using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CCustomerDetails
/// </summary>
public class CCustomerDetails
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
    //Constructor for GetCustomer
    public CCustomerDetails(int _iCustomerID, string _sCus_FName,
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
    public CCustomerDetails(int _iCustomerID, string _sCus_FName,
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
}