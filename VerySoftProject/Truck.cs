using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoftProject
{
    public class Truck : Vehicle
    {
        // תכונה אישים למשאית -קיבולת
        private int capacity;

        //של מחלקת האב ומעדכן את השדה שהוסף למחלקה היורשת Constructor מקבל את כל הפרמטרים מפעיל את ה 
        public Truck(string licensePlate, string make, string model, double rentalPrice, int capacity)
            : base(licensePlate, make, model, rentalPrice)
        {
            this.capacity = capacity;
        }

        //מוגדר פרטי ולא ניתן לגשת אליו מבחוץ PROP  מחזיר את קיבולת המשעית  כי ה
        public int GetCapacity()
        {
            return capacity;
        }

        // דורס וממש בהתאם למחלקה הנוכחית את הפונקציה שהוגדרה במחלקת האב
        public override double CalculateRentalCost(int days)
        {
            //לכל יחידת קיבולת מוסיף עוד 10 שקלים במחיר
            double additionalCost = capacity * 10.0;  
            return (GetRentalPrice() + additionalCost) * days;
        }
    }
}
