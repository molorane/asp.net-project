using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CGantry
/// </summary>
public class CGantry
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
    public CGantry(int _iGantryID, string _sGantry_Name, string _sGantry_Desc,
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
    public CGantry(int _iGantryID, string _sGantry_Name)
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

    #region Static methods
    public static List<CGantry> GetGantries()
    {
        return GetGantryListFromGantryDetailList(CProviderBase.Instance.GetGantries());
    }

    public static CGantry GetGantry(int GantryID)
    {
        return GetGantry_Complete_FromGantryDetail(CProviderBase.Instance.GetGantry(GantryID));
    }

    public static int MaintainGantry(int GantryID, string Gantry_Name, 
        string Gantry_Desc, string Gantry_GPSLocation, int TRateID, int ROfficeID)
    {
        return CProviderBase.Instance.MaintainGantry(GantryID, Gantry_Name, 
            Gantry_Desc, Gantry_GPSLocation, TRateID, ROfficeID);
    }
    #endregion

    #region Conversion Methods

    private static CGantry GetGantry_Complete_FromGantryDetail(CGantryDetails _GantryDetailObject)
    {
        if (_GantryDetailObject == null)
            return null;
        else
        {
            return new CGantry(_GantryDetailObject.GantryID,
                _GantryDetailObject.Gantry_Name,
                _GantryDetailObject.Gantry_Desc,
                _GantryDetailObject.Gantry_GPSLocation,
                _GantryDetailObject.TRateID,
                _GantryDetailObject.ROfficeID);
        }
    }
    private static List<CGantry> GetGantryListFromGantryDetailList(List<CGantryDetails> _GantryDetailObjectList)
    {
        List<CGantry> Gantrys = new List<CGantry>();
        foreach (CGantryDetails GantryDetailObject in _GantryDetailObjectList)
        {
            Gantrys.Add(GetGantryFromGantryDetail(GantryDetailObject));
        }
        return Gantrys;
    }

    private static CGantry GetGantryFromGantryDetail(CGantryDetails _GantryDetailObject)
    {
        if (_GantryDetailObject == null)
            return null;
        else
        {
            return new CGantry(_GantryDetailObject.GantryID,
                _GantryDetailObject.Gantry_Name);
        }
    }
    #endregion
}