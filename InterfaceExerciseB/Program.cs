namespace InterfaceExerciseB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IDistanceRunner person = new Person();
            person.Run();

            IRunner person2 = new Person();
            person.Run();
        }
    }
}
