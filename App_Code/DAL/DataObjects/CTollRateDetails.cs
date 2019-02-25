using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CTollRateDetails
/// </summary>
public class CTollRateDetails
{
    #region Private Data Members
    private int iTRateID;
    private decimal decTRate_Amount;
    #endregion

    #region Constructor
    //Constructor for GetRegions
    public CTollRateDetails(int _iTRateID, decimal _decTRate_Amount)
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

}