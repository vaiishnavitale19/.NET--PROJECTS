using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Employee Name : ");
        string name = Console.ReadLine();

        Console.Write("Enter Employee ID : ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Welcome " + name);

        VehicleManagement vm = new VehicleManagement();

        int choice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("ABC MOTORS");
            Console.WriteLine("Vehicle Management System");
            Console.WriteLine("==================================");

            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. View All Vehicles");
            Console.WriteLine("3. Search Vehicle");
            Console.WriteLine("4. Update Vehicle Price");
            Console.WriteLine("5. Delete Vehicle");
            Console.WriteLine("6. Calculate Discount");
            Console.WriteLine("7. Show Vehicle Details");
            Console.WriteLine("8. Exit");

            Console.Write("Enter Your Choice : ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    vm.AddVehicle();
                    break;

                case 2:
                    vm.ViewAllVehicles();
                    break;

                case 3:
                    vm.SearchVehicle();
                    break;

                case 4:
                    vm.UpdateVehiclePrice();
                    break;

                case 5:
                    vm.DeleteVehicle();
                    break;

                case 6:
                    vm.CalculateDiscount();
                    break;

                case 7:
                    vm.ShowVehicleDetails();
                    break;

                case 8:
                    Console.WriteLine("Thank you for using ABC Motors System.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }

        } while (choice != 8);
    }
}