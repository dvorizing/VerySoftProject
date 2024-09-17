using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoftProject
{
    //ICustomer הצהרת חתימות פונקציות שיממושו במחלקות היורשות את ה  
    public interface ICustomer
    {
        //החזרת שם הלקוח
        string GetName();

        // מסדיר השכרת רכב מסוים למספר ימים
        double RentVehicle(Vehicle vehicle, int days);

        // הגדרת פונקציה שתחזיר את הרכבים שנשכרו על הלקוח הנוכחי
        List<Vehicle> GetRentedVehicles();
    }
}
