﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for CVehicleDetails
/// </summary>
public class CVehicle
{
    #region Private Data Members
    private int iVehicleID;
    private string sVehicle_Make;
    private string sVehicle_Model;
    private string sVehicle_Registration;
    #endregion

    #region Constructor
    //Constructor for Get Customer Vehicles
    public CVehicle(int _iVehicleID, string _sVehicle_Make, 
        string _sVehicle_Model, string _sVehicle_Registration)
    {
        this.VehicleID = _iVehicleID;
        this.Vehicle_Make = _sVehicle_Make;
        this.Vehicle_Model = _sVehicle_Model;
        this.Vehicle_Registration = _sVehicle_Registration;
    }
    #endregion

    #region Public Properties
    public int VehicleID
    {
        get
        {
            return iVehicleID;
        }
        set
        {
            iVehicleID = value;
        }
    }

    public string Vehicle_Make
    {
        get
        {
            return sVehicle_Make;
        }
        set
        {
            sVehicle_Make = value;
        }
    }

    public string Vehicle_Model
    {
        get
        {
            return sVehicle_Model;
        }
        set
        {
            sVehicle_Model = value;
        }
    }

    public string Vehicle_Registration
    {
        get
        {
            return sVehicle_Registration;
        }
        set
        {
            sVehicle_Registration = value;
        }
    }


    #endregion

    #region Static methods
    public static int DeleteVehicle(int VehicleID)
    {
        return CProviderBase.Instance.DeleteVehicle(VehicleID);
    }

    public static List<CVehicle> GetCustomerVehicles(int CustomerID)
    {
        return GetVehicleListFromVehicleDetailList(CProviderBase.Instance.GetCustomerVehicles(CustomerID));
    }

    public static int InsertVehicle(string Vehicle_Make, 
        string Vehicle_Model, string Vehicle_Registration, int CustomerID)
    {
        return CProviderBase.Instance.MaintainVehicle(0,  Vehicle_Make, 
            Vehicle_Model,  Vehicle_Registration, CustomerID);  
    }

    public static int UpdateVehicle(int VehicleID, string Vehicle_Make,
        string Vehicle_Model, string Vehicle_Registration, int CustomerID)
    {
        return CProviderBase.Instance.MaintainVehicle(VehicleID, Vehicle_Make,
            Vehicle_Model, Vehicle_Registration, CustomerID); 
    }

    #endregion

    #region Conversion Methods
    private static List<CVehicle> GetVehicleListFromVehicleDetailList(List<CVehicleDetails> _VehicleDetailObjectList)
    {
        List<CVehicle> Vehicles = new List<CVehicle>();
        foreach (CVehicleDetails VehicleDetailObject in _VehicleDetailObjectList)
        {
            Vehicles.Add(GetVehicleFromVehicleDetail(VehicleDetailObject));
        }
        return Vehicles;
    }

    private static CVehicle GetVehicleFromVehicleDetail(CVehicleDetails _VehicleDetailObject)
    {
        if (_VehicleDetailObject == null)
            return null;
        else
        {
            return new CVehicle(_VehicleDetailObject.VehicleID,
                _VehicleDetailObject.Vehicle_Make, _VehicleDetailObject.Vehicle_Model, _VehicleDetailObject.Vehicle_Registration);
        }
    }
    #endregion

}