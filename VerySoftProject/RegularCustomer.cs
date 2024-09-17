using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoftProject
{
    //ICustomer המחלקה הנוכחית ממשת את הפונקציות שהוגדרו בממשק 
    public class RegularCustomer : ICustomer
    {
        //שם הלקוח
        private string name;

        // רשימה של הרכבים אותם הלקוח שכר
        private List<Vehicle> rentedVehicles;

        // Constructor 
        public RegularCustomer(string name)
        {
            this.name = name;
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
            return vehicle.CalculateRentalCost(days);
        }

        //שמחזירה את הרכבים השכורים של הלקוח הנוכחי GetRentedVehicles מימוש הפונקציה 
        public List<Vehicle> GetRentedVehicles()
        {
            return rentedVehicles;
        }
    }
}
