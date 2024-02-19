
    class Program 
    {
        static void showmsg3(){
            Console.WriteLine("I have to tell something about saran");
            showmsg1();
        }


        static void showmsg(){
            Console.WriteLine("saran loves rahini");
            showmsg3();
        }


        static void showmsg2(int x){
            Console.WriteLine("and also saran loves samantha and "+ x);
        }



        static void showmsg1(){
            Console.WriteLine("If any doubt in love u can clarify ur doubt to saran");
            showmsg2(10);
        }




        static string returnmethod(){
            string name = "saran";
            return name;
        }


        static void Main(string[] args) 
        {
            Console.WriteLine("hi da, how are you");
            Console.WriteLine("hope u doing well");
            showmsg();
            returnmethod();
        }
    }