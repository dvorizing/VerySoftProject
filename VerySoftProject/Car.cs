using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoftProject
{
    public class Car : Vehicle
    {
        //הוספת שדה בנוסף לפרמטרים מהמחלקה האבסטרקטית
        private string type;

        //של מחלקת האב ומעדכן את השדה שהוסף למחלקה היורשת Constructor מקבל את כל הפרמטרים מפעיל את ה 
        public Car(string licensePlate, string make, string model, double rentalPrice, string type)
            : base(licensePlate, make, model, rentalPrice)
        {
            this.type = type;
        }

        //מוגדר פרטי ולא ניתן לגשת אליו מבחוץ PROP  מחזיר את סוג הרכב כי ה
        public string GetCarType()
        {
            return type;
        }

        // דורס וממש את הפונקציה שהוגדרה במחלקת האב
        public override double CalculateRentalCost(int days)
        {
            return GetRentalPrice() * days;
        }
    }
}
