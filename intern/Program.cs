namespace intern
{
    class Program
    {
        static void Main (string [] args){

            Brightskills bs= new Brightskills();
            Console.WriteLine("Hi, I have a trainer, his name is "+bs.gettrainer());
            Console.WriteLine("My branch is located at "+bs.getlocation());
        }
    }
}