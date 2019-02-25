using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CRegionDetails
/// </summary>
public class CRegionDetails
{
    #region Private Data Members
    private int iROfficeID;
    private string sROffice_Name;

    //---- Additional
    private decimal decTotalOutstanding;
    private int iNumberOfTolls;
    #endregion

    #region Constructors
    //Constructor for GetRegions
    public CRegionDetails(int _iROfficeID, string _sROffice_Name)
    {
        this.ROfficeID = _iROfficeID;
        this.ROffice_Name = _sROffice_Name;
    }

    //Constructor for OutstandingTollsReport
    public CRegionDetails(int _iROfficeID, string _sROffice_Name, 
    decimal _decTotalOutstanding)
    {
        this.ROfficeID = _iROfficeID;
        this.ROffice_Name = _sROffice_Name;
        this.TotalOutstanding = _decTotalOutstanding;
    }

    //Constructor for PopularRegionRep
    public CRegionDetails(int _iROfficeID, string _sROffice_Name,
        int _iNumberOfTolls)
    {
        this.ROfficeID = _iROfficeID;
        this.ROffice_Name = _sROffice_Name;
        this.NumberOfTolls = _iNumberOfTolls;
    }
    #endregion

    #region Public Properties
    public int ROfficeID
    {
        get
        {
            return iROfficeID;
        }
        set
        {
            iROfficeID = value;
        }
    }

    public string ROffice_Name
    {
        get
        {
            return sROffice_Name;
        }
        set
        {
            sROffice_Name = value;
        }
    }

    public decimal TotalOutstanding
    {
        get
        {
            return decTotalOutstanding;
        }
        set
        {
            decTotalOutstanding = value;
        }
    }

    public int NumberOfTolls
    {
        get
        {
            return iNumberOfTolls;
        }
        set
        {
            iNumberOfTolls = value;
        }
    }

    #endregion
}