using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoftProject
{
    public class CorporateCustomer : ICustomer
    {
        private string name;
        private string companyName;

        //רשימת הרכבים של הלקוח
        private List<Vehicle> rentedVehicles;

        // Constructor 
        public CorporateCustomer(string name, string companyName)
        {
            this.name = name;
            this.companyName = companyName;
            this.rentedVehicles = new List<Vehicle>();
        }

        //שתחזיר את שם הלקוח GetName מימוש הפונקציה 
        public string GetName()
        {
            return name;
        }

        // RentVehicle מימוש הפונקציה 
        public double RentVehicle(Vehicle vehicle, int days)
        {
            rentedVehicles.Add(vehicle);
           return vehicle.CalculateRentalCost(days) * 0.9;

        }

        //שמחזירה את הרכבים השכורים של הלקוח הנוכחי GetRentedVehicles מימוש הפונקציה 
        public List<Vehicle> GetRentedVehicles()
        {
            return rentedVehicles;
        }

        //ICustomer פונקציה שלא קיימת ב ממשק 
        public string GetCompanyName()
        {
            return companyName;
        }
    }
}
