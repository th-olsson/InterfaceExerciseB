namespace InterfaceExerciseB
{
    internal class Person : IRunner, IDistanceRunner
    {
        int IDistanceRunner.Run()
        {
            Console.WriteLine("from int Run");
            return 7;
        }
        void IRunner.Run()
        {
            Console.WriteLine("from void Run");
        }
    }
}
