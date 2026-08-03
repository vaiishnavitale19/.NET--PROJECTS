using System;

class problem1
{
    static void Main()
    {
        int totalPackages = 0;
        int qualityCheck = 0;
        int priorityShipment = 0;
        int normalProcessing = 0;

        for (int packageId = 1001; packageId <= 1020; packageId++)
        {
            totalPackages++;

            if (packageId % 4 == 0)
            {
                Console.WriteLine("Package ID: " + packageId + " - Quality Check Required");
                qualityCheck++;
            }
            else if (packageId % 5 == 0)
            {
                Console.WriteLine("Package ID: " + packageId + " - Priority Shipment");
                priorityShipment++;
            }
            else
            {
                Console.WriteLine("Package ID: " + packageId + " - Normal Processing");
                normalProcessing++;
            }
        }

        Console.WriteLine("Total Packages Processed: " + totalPackages);
        Console.WriteLine("Packages Requiring Quality Check: " + qualityCheck);
        Console.WriteLine("Priority Shipments: " + priorityShipment);
        Console.WriteLine("Normal Packages: " + normalProcessing);
    }
}