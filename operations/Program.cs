class  Program
{
    static void Main (string [] args){
        Console.WriteLine("added value of a and b is " + add(4,5));
        Console.WriteLine("added value of a and b is " + sub(4,5));
        Console.WriteLine("multiplied value of a and b is " + mul(4,5));
        Console.WriteLine("divided value of a and b is " + div(4,5));
        Console.WriteLine("modulus value of a and b is " + mod(4,5));
        Console.WriteLine("increment value of a is " + inc_a(4));
        Console.WriteLine("increment value of b is " + inc_b(5));
        Console.WriteLine("decrement value of a is " + dec_a(4));
        Console.WriteLine("decrement value of b is " + dec_b(5));
        Console.WriteLine("added value of " + add("Saran placed in a ", "Microsoft"));
        Console.WriteLine("added value of a and b is " + add(4.7,5.7));
        Console.WriteLine("added value of a and b is " + sub(4.7,5.7));
        Console.WriteLine("multiplied value of a and b is " + mul(4.7,5.7));
        Console.WriteLine("divided value of a and b is " + div(4.7,5.7));
        Console.WriteLine("modulus value of a and b is " + mod(4.7,5.7));
        Console.WriteLine("increment value of a is " + inc_a(4.7));
        Console.WriteLine("increment value of b is " + inc_b(5.7));
        Console.WriteLine("decrement value of a is " + dec_a(4.7));
        Console.WriteLine("decrement value of b is " + dec_b(5.7));

        constructordemo cd=new constructordemo();
        constructordemo cd1=new constructordemo(45,55);
    }

    static int add(int a, int b){
        return a+b;
    }

    static string add(string a, string b){
        return a+b;
    }

    static double add(double a, double b){
        return a+b;
    }




    static int sub(int a, int b){
        return a+b;
    }

    static double sub(double a, double b){
        return a-b;
    }





    static int mul(int a, int b){
        return a+b;
    }

    static double mul(double a, double b){
        return a+b;
    }



    static int div(int a, int b){
        return a/b;
    }

    static double div(double a, double b){
        return a/b;
    }


    static int mod(int a, int b){
        return a%b;
    }

    static double mod(double a, double b){
        return a%b;
    }


    static int inc_a(int a){
        return a++;
    }

    static double inc_a(double a){
        return a++;
    }

    static int inc_b(int b){
        return b++;
    }

    static double inc_b(double b){
        return b++;
    }




    static int dec_a(int a){
        return a--;
    }

    static double dec_a(double a){
        return a--;
    }

    static int dec_b(int b){
        return b--;
    }

    static double dec_b(double b){
        return b--;
    }
}




class constructordemo{
    public constructordemo(){
        Console.WriteLine("Its working");
    }
    public constructordemo(int a, int b){
        Console.WriteLine("yes constructor is workiong "+ (a+b));
    }
}