using System;

class problem2
{
    static void Main()
    {
        int totalPower = 0;
        int maintenance = 0;
        int normal = 0;
        int efficient = 0;

        for (int lightNumber = 1; lightNumber <= 30; lightNumber++)
        {
            int power = 80 + (lightNumber * 5);
            totalPower += power;

            Console.Write("Light " + lightNumber + " : Power = " + power + " W - ");

            if (power > 180)
            {
                Console.WriteLine("Maintenance Required");
                maintenance++;
            }
            else if (power >= 140 && power <= 180)
            {
                Console.WriteLine("Normal Operation");
                normal++;
            }
            else
            {
                Console.WriteLine("Energy Efficient");
                efficient++;
            }
        }

        double averagePower = (double)totalPower / 30;

        Console.WriteLine("Total Power Consumed: " + totalPower + " W");
        Console.WriteLine("Average Power Consumption: " + averagePower + " W");
        Console.WriteLine("Maintenance Required Lights: " + maintenance);
        Console.WriteLine("Normal Operation Lights: " + normal);
        Console.WriteLine("Energy Efficient Lights: " + efficient);
    }
}