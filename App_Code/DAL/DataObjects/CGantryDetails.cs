using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CGantryDetails
/// </summary>
public class CGantryDetails
{
    #region Private Data Members
    private int iGantryID;
    private string sGantry_Name;
    private string sGantry_Desc;
    private string sGantry_GPSLocation;
    private int iTRateID;
    private int iROfficeID;
    #endregion

    #region Constructors
    //Constructor for GetGantry
    public CGantryDetails(int _iGantryID, string _sGantry_Name, string _sGantry_Desc,
   string _sGantry_GPSLocation, int _iTRateID, int _iROfficeID)
    {
        this.GantryID = _iGantryID;
        this.Gantry_Name = _sGantry_Name;
        this.Gantry_Desc = _sGantry_Desc;
        this.Gantry_GPSLocation = _sGantry_GPSLocation;
        this.TRateID = _iTRateID;
        this.ROfficeID = _iROfficeID;

    }
    //Constructor for GetGantries
    public CGantryDetails(int _iGantryID, string _sGantry_Name)
    {
        this.GantryID = _iGantryID;
        this.Gantry_Name = _sGantry_Name;
    }
    #endregion

    #region Public Properties
    public int GantryID
    {
        get
        {
            return iGantryID;
        }
        set
        {
            iGantryID = value;
        }
    }
    public string Gantry_Name
    {
        get
        {
            return sGantry_Name;
        }
        set
        {
            sGantry_Name = value;
        }
    }
    public string Gantry_Desc
    {
        get
        {
            return sGantry_Desc;
        }
        set
        {
            sGantry_Desc = value;
        }
    }
    public string Gantry_GPSLocation
    {
        get
        {
            return sGantry_GPSLocation;
        }
        set
        {
            sGantry_GPSLocation = value;
        }
    }
    public int TRateID
    {
        get
        {
            return iTRateID;
        }
        set
        {
            iTRateID = value;
        }
    }
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
    #endregion

}