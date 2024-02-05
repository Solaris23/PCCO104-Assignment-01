using System;

class Program {
    public static void Main(string[] args) {
        double denomination = 0.01; // Manual input needed

        string personality = getPersonality(denomination);
        Console.WriteLine($"Personality found on the {denomination} bank note: {personality}");
    }

    static string getPersonality(double denomination) {
        switch (denomination) {
            case 0.01:
            case 0.05:
            case 0.25:
                return "No Person is found";
            case 1:
                return "Jose Rizal";
            case 5:
                return "Emilio Aguinaldo";
            case 10:
                return "Andres Bonifacio & Apolinario Mabini";
            case 20:
                return "Manuel L. Quezon";
            case 50:
                return "Sergio Osmena";
            case 100:
                return "Manuel Roxas";
            case 200:
                return "Diosdado Macapagal";
            case 500:
                return "Benigno Sr. & Corazon Aquino";
            case 1000:
                return "Jose Abad Santos, Vicente Lim & Josefa Llanes Escoda";
            default:
                return $"Invalid Denomination: {denomination}";
        }
    }
}
