using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CTollRate
/// </summary>
public class CTollRate
{
    #region Private Data Membmers
    private int iTRateID;
    private decimal decTRate_Amount;
    #endregion

    #region Constructor
    //Constructor for GetTollRates
    public CTollRate(int _iTRateID, decimal _decTRate_Amount)
    {
        this.TRateID = _iTRateID;
        this.TRate_Amount = _decTRate_Amount;
    }
    #endregion

    #region Public Properties
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

    public decimal TRate_Amount
    {
        get
        {
            return decTRate_Amount;
        }
        set
        {
            decTRate_Amount = value;
        }
    }
    #endregion

    #region Static Methods
    public static List<CTollRate> GetTollRates()
    {
        return GetTollRateListFromTollRateDetailList(CProviderBase.Instance.GetTollRates());

    }
    #endregion

    #region Conversion Methods
    private static List<CTollRate> GetTollRateListFromTollRateDetailList(List<CTollRateDetails> _TollRateDetailObjectList)
    {
        List<CTollRate> TollRates = new List<CTollRate>();
        foreach (CTollRateDetails TollRateDetailObject in _TollRateDetailObjectList)
        {
            TollRates.Add(GetTollRateFromTollRateDetail(TollRateDetailObject));
        }
        return TollRates;
    }

    private static CTollRate GetTollRateFromTollRateDetail(CTollRateDetails _TollRateDetailObject)
    {
        if (_TollRateDetailObject == null)
            return null;
        else
        {
            return new CTollRate(_TollRateDetailObject.TRateID,
                _TollRateDetailObject.TRate_Amount);
        }
    }
    #endregion

}