using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CTollTransaction
/// </summary>
public class CTollTransaction
{
    #region Private Data Members
    private int iTTID;
    private DateTime dtTT_DateTime;
    private bool isTT_IsPaid;
    private decimal decTT_Amount;
    private string sTT_VehicleRegistration;

    //Additional
    private string sFullName;
    #endregion

    #region Constructors
    //Constructor for GetTollTransactions
    public CTollTransaction(int _iTTID, DateTime _TT_DateTime, decimal _TT_Amount,
                                   bool _isTT_IsPaid, string _TT_VehicleRegistration,
                                   string _FullName)
    {
        this.TTID = _iTTID;
        this.TT_DateTime = _TT_DateTime;
        this.TT_Amount = _TT_Amount;
        this.isTT_IsPaid = _isTT_IsPaid;
        this.TT_VehicleRegistration = _TT_VehicleRegistration;
        this.FullName = _FullName;
    }

    //Constructor for NinetyDaysUnpaidReport
    public CTollTransaction(DateTime _TT_DateTime, decimal _TT_Amount,
                                   string _TT_VehicleRegistration,
                                   string _FullName)
    {
        this.TT_DateTime = _TT_DateTime;
        this.TT_Amount = _TT_Amount;
        this.TT_VehicleRegistration = _TT_VehicleRegistration;
        this.FullName = _FullName;
    }
    #endregion

    #region Public Properties
    public int TTID
    {
        get
        {
            return iTTID;
        }
        set
        {
            iTTID = value;
        }
    }
    public DateTime TT_DateTime
    {
        get
        {
            return dtTT_DateTime;
        }
        set
        {
            dtTT_DateTime = value;
        }
    }
    public bool TT_IsPaid
    {
        get
        {
            return isTT_IsPaid;
        }
        set
        {
            isTT_IsPaid = value;
        }
    }
    public decimal TT_Amount
    {
        get
        {
            return decTT_Amount;
        }
        set
        {
            decTT_Amount = value;
        }
    }
    public string TT_VehicleRegistration
    {
        get
        {
            return sTT_VehicleRegistration;
        }
        set
        {
            sTT_VehicleRegistration = value;
        }
    }
    public string FullName
    {
        get
        {
            return sFullName;
        }
        set
        {
            sFullName = value;
        }
    }
    #endregion*/

    #region Static Methods

    public static int AddTollTransaction(string TTVehicleRegistration, int GantryID)
    {
        return CProviderBase.Instance.AddTollTransaction(TTVehicleRegistration, GantryID);

    }

    public static List<CTollTransaction> GetTollTransactions()
    {
        return GetTollTransactionListFromTollTransactionDetailList(CProviderBase.Instance.GetTollTransactions());
    }

    public static List<CTollTransaction> NinetyDayUnpaidReport()
    {
        return GetTollTransactionList_Unpaid_FromTollTransactionDetailList(CProviderBase.Instance.NinetyDayUnpaidReport());
    }
    #endregion

    #region Conversion Methods
    private static List<CTollTransaction> GetTollTransactionList_Unpaid_FromTollTransactionDetailList(List<CTollTransactionDetails> _TollTransactionDetailObjectList)
    {
        List<CTollTransaction> TollTransactions = new List<CTollTransaction>();
        foreach (CTollTransactionDetails TollTransactionDetailObject in _TollTransactionDetailObjectList)
        {
            TollTransactions.Add(GetTollTransaction_Unpaid_FromTollTransactionDetail(TollTransactionDetailObject));
        }
        return TollTransactions;
    }

    private static CTollTransaction GetTollTransaction_Unpaid_FromTollTransactionDetail(CTollTransactionDetails _TollTransactionDetailObject)
    {
        if (_TollTransactionDetailObject == null)
            return null;
        else
        {
            return new CTollTransaction(_TollTransactionDetailObject.TT_DateTime, 
                _TollTransactionDetailObject.TT_Amount,
                _TollTransactionDetailObject.TT_VehicleRegistration,
                _TollTransactionDetailObject.FullName);
        }
    }

    private static List<CTollTransaction> GetTollTransactionListFromTollTransactionDetailList(List<CTollTransactionDetails> _TollTransactionDetailObjectList)
    {
        List<CTollTransaction> TollTransactions = new List<CTollTransaction>();
        foreach (CTollTransactionDetails TollTransactionDetailObject in _TollTransactionDetailObjectList)
        {
            TollTransactions.Add(GetTollTransactionFromTollTransactionDetail(TollTransactionDetailObject));
        }
        return TollTransactions;
    }

    private static CTollTransaction GetTollTransactionFromTollTransactionDetail(CTollTransactionDetails _TollTransactionDetailObject)
    {
        if (_TollTransactionDetailObject == null)
            return null;
        else
        {
            return new CTollTransaction(_TollTransactionDetailObject.TTID,
                _TollTransactionDetailObject.TT_DateTime,
                _TollTransactionDetailObject.TT_Amount,
                _TollTransactionDetailObject.TT_IsPaid,
                _TollTransactionDetailObject.TT_VehicleRegistration,
                _TollTransactionDetailObject.FullName);
        }
    }
    #endregion

}