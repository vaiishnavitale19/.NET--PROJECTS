using System;
using System.Collections.Generic;

public class VehicleManagement : IVehicle
{
    List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle()
    {
        Vehicle v = new Vehicle();

        Console.Write("Vehicle ID : ");
        v.VehicleId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Vehicle Name : ");
        v.VehicleName = Console.ReadLine();

        Console.Write("Vehicle Type : ");
        v.VehicleType = Console.ReadLine();

        Console.Write("Brand : ");
        v.Brand = Console.ReadLine();

        Console.Write("Price : ");
        v.Price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Manufacturing Year : ");
        v.ManufacturingYear = Convert.ToInt32(Console.ReadLine());

        vehicles.Add(v);

        Console.WriteLine("Vehicle Added Successfully.");
    }

    public void ViewAllVehicles()
    {
        if (vehicles.Count == 0)
        {
            Console.WriteLine("No Vehicles Available.");
            return;
        }

        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("ID\tName\tBrand\tType\tPrice\t\tYear");
        Console.WriteLine("---------------------------------------------------------------");

        foreach (Vehicle item in vehicles)
        {
            Console.WriteLine(item.VehicleId + "\t" +
                              item.VehicleName + "\t" +
                              item.Brand + "\t" +
                              item.VehicleType + "\t" +
                              item.Price + "\t" +
                              item.ManufacturingYear);
        }
    }

    public void SearchVehicle()
    {
        Console.Write("Enter Vehicle ID : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Vehicle item in vehicles)
        {
            if (item.VehicleId == id)
            {
                Console.WriteLine("Vehicle Found");
                Console.WriteLine("ID : " + item.VehicleId);
                Console.WriteLine("Name : " + item.VehicleName);
                Console.WriteLine("Brand : " + item.Brand);
                Console.WriteLine("Type : " + item.VehicleType);
                Console.WriteLine("Price : " + item.Price);
                Console.WriteLine("Year : " + item.ManufacturingYear);
                return;
            }
        }

        Console.WriteLine("Vehicle Not Found.");
    }

    public void UpdateVehiclePrice()
    {
        Console.Write("Enter Vehicle ID : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Vehicle item in vehicles)
        {
            if (item.VehicleId == id)
            {
                Console.Write("Enter New Price : ");
                item.Price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Price Updated Successfully.");
                return;
            }
        }

        Console.WriteLine("Vehicle ID does not exist.");
    }

    public void DeleteVehicle()
    {
        Console.Write("Enter Vehicle ID : ");
        int id = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < vehicles.Count; i++)
        {
            if (vehicles[i].VehicleId == id)
            {
                vehicles.RemoveAt(i);
                Console.WriteLine("Vehicle Deleted Successfully.");
                return;
            }
        }

        Console.WriteLine("Vehicle not available.");
    }

    public void CalculateDiscount()
    {
        Console.Write("Enter Vehicle ID : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Vehicle item in vehicles)
        {
            if (item.VehicleId == id)
            {
                double discount = 0;

                switch (item.VehicleType.ToLower())
                {
                    case "car":
                        discount = item.Price * 0.10;
                        break;

                    case "bike":
                        discount = item.Price * 0.05;
                        break;

                    case "truck":
                        discount = item.Price * 0.12;
                        break;

                    default:
                        Console.WriteLine("Invalid Vehicle Type");
                        return;
                }

                Console.WriteLine("Vehicle Price : " + item.Price);
                Console.WriteLine("Discount : " + discount);
                Console.WriteLine("Final Price : " + (item.Price - discount));
                return;
            }
        }

        Console.WriteLine("Vehicle Not Found.");
    }

    public void ShowVehicleDetails()
    {
        Console.Write("Enter Vehicle Type : ");
        string type = Console.ReadLine().ToLower();

        switch (type)
        {
            case "car":
                Console.WriteLine("Car is a four wheeler.");
                Console.WriteLine("Suitable for family.");
                break;

            case "bike":
                Console.WriteLine("Bike is fuel efficient.");
                Console.WriteLine("Suitable for city rides.");
                break;

            case "truck":
                Console.WriteLine("Truck is used for transportation.");
                Console.WriteLine("Heavy load vehicle.");
                break;

            default:
                Console.WriteLine("Invalid Vehicle Type.");
                break;
        }
    }
}