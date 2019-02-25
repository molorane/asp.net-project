using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CRegion
/// </summary>
public class CRegion
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
    public CRegion(int _iROfficeID, string _sROffice_Name)
    {
        this.ROfficeID = _iROfficeID;
        this.ROffice_Name = _sROffice_Name;
    }

    //Constructor for OutstandingTollsReport
    public CRegion(int _iROfficeID, string _sROffice_Name, 
    decimal _decTotalOutstanding)
    {
        this.ROfficeID = _iROfficeID;
        this.ROffice_Name = _sROffice_Name;
        this.TotalOutstanding = _decTotalOutstanding;
    }

    //Constructor for PopularRegionRep
    public CRegion(int _iROfficeID, string _sROffice_Name,
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

    #region Static Methods
  
    public static List<CRegion> GetRegions()
    {
        return GetRegionListFromRegionDetailList(CProviderBase.Instance.GetRegions());
    }

    public static List<CRegion> OutstandingTollsReport()
    {
        return GetRegionList_OutstandingTolls_FromRegionDetailList(CProviderBase.Instance.OutstandingTollsReport());
    }

    public static List<CRegion> PopularRegionReport(DateTime StartDate, DateTime EndDate)
    {
        return GetRegionList_Popular_FromRegionDetailList(CProviderBase.Instance.PopularRegionReport(StartDate, EndDate));
    }
    #endregion

    #region Conversion Methods
    private static List<CRegion> GetRegionListFromRegionDetailList(List<CRegionDetails> _RegionDetailObjectList)
    {
        List<CRegion> Regions = new List<CRegion>();
        foreach (CRegionDetails RegionDetailObject in _RegionDetailObjectList)
        {
            Regions.Add(GetRegionFromRegionDetail(RegionDetailObject));
        }
        return Regions;
    }

    private static CRegion GetRegionFromRegionDetail(CRegionDetails _RegionDetailObject)
    {
        if (_RegionDetailObject == null)
            return null;
        else
        {
            return new CRegion(_RegionDetailObject.ROfficeID,
                _RegionDetailObject.ROffice_Name);
        }
    }
    private static List<CRegion> GetRegionList_OutstandingTolls_FromRegionDetailList(List<CRegionDetails> _RegionDetailObjectList)
    {
        List<CRegion> Regions = new List<CRegion>();
        foreach (CRegionDetails RegionDetailObject in _RegionDetailObjectList)
        {
            Regions.Add(GetRegion_OutstandingTolls_FromRegionDetail(RegionDetailObject));
        }
        return Regions;
    }

    private static CRegion GetRegion_OutstandingTolls_FromRegionDetail(CRegionDetails _RegionDetailObject)
    {
        if (_RegionDetailObject == null)
            return null;
        else
        {
            return new CRegion(_RegionDetailObject.ROfficeID,
                _RegionDetailObject.ROffice_Name,
                _RegionDetailObject.TotalOutstanding);
        }
    }

    private static List<CRegion> GetRegionList_Popular_FromRegionDetailList(List<CRegionDetails> _RegionDetailObjectList)
    {
        List<CRegion> Regions = new List<CRegion>();
        foreach (CRegionDetails RegionDetailObject in _RegionDetailObjectList)
        {
            Regions.Add(GetRegion_Popular_FromRegionDetail(RegionDetailObject));
        }
        return Regions;
    }

    private static CRegion GetRegion_Popular_FromRegionDetail(CRegionDetails _RegionDetailObject)
    {
        if (_RegionDetailObject == null)
            return null;
        else
        {
            return new CRegion(_RegionDetailObject.ROfficeID,
                _RegionDetailObject.ROffice_Name,
                _RegionDetailObject.NumberOfTolls);
        }
    }

    #endregion

}