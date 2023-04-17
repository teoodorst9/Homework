internal class Program
{
    private static void Main(string[] args)
    {
        switch (animalType)
        {
            case "dog":
                Console.WriteLine("mammal"); break;
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("reptile");
                break;
            default:
                Console.WriteLine("unknown"); break;
        }
    }
}