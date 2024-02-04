using System;

class Program
{
    public static void Main(string[] args)
    {
        //Manual input needed
        int denomination = 100;

        string personality = getPersonality(denomination);
        Console.WriteLine($"Personality found on the {denomination} bank note: {personality}");
    }

    static string getPersonality(int denomination)
    {
        switch (denomination)
        {
            case 1:
                return "Jose Rizal";
            case 5:
                return "Emilio Aguinaldo";
            case 10:
                return "Andres Bonifacio, Apolinario Mabini";
            case 20:
                return "Manuel L. Quezon";
            case 50:
                return "Sergio Osmena";
            case 100:
                return "Manuel Roxas";
            case 200:
                return "Diosdado Macapagal";
            case 500:
                return "Benigno Sr. and Corazon Aquino";
            case 1000:
                return "Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda";
            default:
                return "No Person is found";
        }
    }
}