using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public abstract class ToolVehicle
    {
        public int VehicleID;
        public string Model;
        public string RegNo;
        public string Brand;
        public decimal BasePrice;
        public string VehicleType;

        public static int TotalVehicles = 0;
        public static int TotalTaxPayingVehicles = 0;
        public static int TotalNonTaxPayingVehicles = 0;
        public static decimal TotalTaxCollected = 0;

        public ToolVehicle(int VehicleID, string Model, string RegNo, string Brand, decimal BasePrice, string VehicleType)
        {
            this.VehicleID = VehicleID;
            this.Model = Model;
            this.RegNo = RegNo;
            this.Brand = Brand;
            this.BasePrice = BasePrice;
            this.VehicleType = VehicleType;
        }

        public abstract void PayTax(int BasePrice);
        public void PayTaxPassWithoutPaying()
        {
            TotalNonTaxPayingVehicles++;
            TotalVehicles++;

        }

    }

    public class Car : ToolVehicle
    {
        public Car(int VehicleID, string Model, string RegNo, string Brand, decimal BasePrice, string VehicleType) : base(VehicleID, Model, RegNo, Brand, BasePrice, VehicleType)
        {
            this.VehicleID = VehicleID;
            this.Model = Model;
            this.RegNo = RegNo;
            this.Brand = Brand;
            this.BasePrice = BasePrice;
            this.VehicleType = VehicleType;
        }

        public override void PayTax(int BasePrice)
        {
            TotalTaxCollected += BasePrice;
            TotalVehicles++;
            TotalTaxPayingVehicles++;
        }
    }

    public class Bike : ToolVehicle
    {
        public Bike(int VehicleID, string Model, string RegNo, string Brand, decimal BasePrice, string VehicleType) : base(VehicleID, Model, RegNo, Brand, BasePrice, VehicleType)
        {
            this.VehicleID = VehicleID;
            this.Model = Model;
            this.RegNo = RegNo;
            this.Brand = Brand;
            this.BasePrice = BasePrice;
            this.VehicleType = VehicleType;
        }

        public override void PayTax(int BasePrice)
        {
            TotalTaxCollected += BasePrice;
            TotalTaxPayingVehicles++;
            TotalVehicles++;
        }
    }

    public class HeavyCar : ToolVehicle
    {
        public HeavyCar(int VehicleID, string Model, string RegNo, string Brand, decimal BasePrice, string VehicleType) : base(VehicleID, Model, RegNo, Brand, BasePrice, VehicleType)
        {
            this.VehicleID = VehicleID;
            this.Model = Model;
            this.RegNo = RegNo;
            this.Brand = Brand;
            this.BasePrice = BasePrice;
            this.VehicleType = VehicleType;
        }

        public override void PayTax(int BasePrice)
        {
            TotalTaxCollected += BasePrice;
            TotalTaxPayingVehicles++;
            TotalVehicles++;
        }
    }
}
