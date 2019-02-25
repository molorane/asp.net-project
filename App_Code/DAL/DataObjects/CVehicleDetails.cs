using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CVehicleDetails
/// </summary>
public class CVehicleDetails
{
    #region Private Data Members
    private int iVehicleID;
    private string sVehicle_Make;
    private string sVehicle_Model;
    private string sVehicle_Registration;
    #endregion

    #region Constructor
    //Constructor for Get Customer Vehicles
    public CVehicleDetails(int _iVehicleID, string _sVehicle_Make, 
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
}