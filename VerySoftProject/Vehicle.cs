using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoftProject
{
    public abstract class Vehicle
    {
        //private הגדרת פרפרטי למחלקה לא יהיה ניתן לגשת מבחוץ הוגדרו כ 
        private string licensePlate;
        private string make;
        private string model;

       //המחלקות היורשות יוכלו לגשת
        protected double rentalPrice;

        // Constructor 
        public Vehicle(string licensePlate, string make, string model, double rentalPrice)
        {
            this.licensePlate = licensePlate;
            this.make = make;
            this.model = model;
            this.rentalPrice = rentalPrice;
        }

        //אל מחוץ למחלקה PROPTIES פונקצית שיחזירות את ערכי ה 
        public string GetLicensePlate()
        {
            return licensePlate;
        }

        public string GetMake()
        {
            return make;
        }

        public string GetModel()
        {
            return model;
        }
        //protected שהוגדרה כ rentalPrice את הפונקציה הזו אפשר לעשות במחלקות היורשות כי גם הן יכולות לגשת אל 
        public double GetRentalPrice()
        {
            return rentalPrice;
        }

        // הצהרה על פונקציה שתיהיה ממומשת במחלקות שירשו את המחלקה האבסטרקתית הנוכחית
        public abstract double CalculateRentalCost(int days);
    }
}
