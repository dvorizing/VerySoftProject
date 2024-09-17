using System;
using System.Collections.Generic;
using VerySoftProject;

public class VehicleRental
{
    public static void Main(string[] args)
    {
        // הקצאת שני סוגי רכבים
        Car car1 = new Car("123ABC", "Toyota", "Corolla", 50, "Sedan");
        Truck truck1 = new Truck("456DEF", "Ford", "F150", 80, 5000);

        // הקצאת שני סוגי לקוחות
        RegularCustomer customer1 = new RegularCustomer("John Doe");
        CorporateCustomer customer2 = new CorporateCustomer("Jane Smith", "Tech Corp");

        // חישוב ועדכון השכרת רכב על פי סוג רכב ומספר ימים
        double carRentalCost = customer1.RentVehicle(car1, 5); 
        double carRentalCostForCorporateCustomer = customer2.RentVehicle(car1, 5);
        double truckRentalCost = customer1.RentVehicle(truck1, 3); 
        double truckRentalCostForCorporateCustomer = customer2.RentVehicle(truck1, 3);

        // הדפסות חישובים עבור השכרות רכב
        //לקוח 1 השכרת רכב
        Console.WriteLine($"{customer1.GetName()} rented the {car1.GetMake()} {car1.GetModel()} for 5 days.");
        Console.WriteLine($"Total Rental Cost: ${carRentalCost}");
        Console.WriteLine();
        //לקוח 1 השכרת משאית
        Console.WriteLine($"{customer1.GetName()} from {customer1.GetName()} rented the {truck1.GetMake()} {truck1.GetModel() } for 3 days.");
        Console.WriteLine($"Total Rental Cost after discount: ${truckRentalCost}");
        Console.WriteLine();

        //לקוח 2 השכרת רכב
        Console.WriteLine($"{customer2.GetName()} from {customer2.GetCompanyName()} rented the {car1.GetMake()} {car1.GetModel()} for 5 days.");
        Console.WriteLine($"Total Rental Cost after discount: ${carRentalCostForCorporateCustomer}");
        Console.WriteLine();
        //לקוח 2 השכרת משאית
        Console.WriteLine($"{customer2.GetName()} from {customer2.GetCompanyName()} rented the {truck1.GetMake()} {truck1.GetModel()} for 3 days.");
        Console.WriteLine($"Total Rental Cost after discount: ${truckRentalCostForCorporateCustomer}");
        Console.WriteLine();

        //ICustomer מדפיס עבור כל לקוח את הרכבים המושכרים שלו בהתאמה לסוג הרכב וסוג הלקוח הפונקציה מקבלת את האובייקט מסוג ממשק 
        DisplayRentedVehicles(customer1);
        DisplayRentedVehicles(customer2);
    }

    // הדפסת הרכבים עבור הלקוח הנוכחי
    public static void DisplayRentedVehicles(ICustomer customer)
    {
        List<Vehicle> rentedVehicles = customer.GetRentedVehicles();

        Console.WriteLine($"{customer.GetName()}'s rented vehicles:");
        int i = 0;
        foreach (Vehicle vehicle in rentedVehicles)
        {
            i++;
            Console.WriteLine($" vehicle number: {i} ");
            Console.WriteLine($"--- {vehicle.GetMake()} {vehicle.GetModel()} (License Plate: {vehicle.GetLicensePlate()}) Price:{vehicle.GetRentalPrice()}");
        }

        Console.WriteLine();
    }
}
