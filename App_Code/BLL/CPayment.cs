using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CPayment
/// </summary>
public class CPayment
{

    #region Static methods
    public static int AddPayment(int TTID, decimal Pay_Amount)
    {
        return CProviderBase.Instance.AddPayment(TTID, Pay_Amount);
    }
     
    #endregion

}