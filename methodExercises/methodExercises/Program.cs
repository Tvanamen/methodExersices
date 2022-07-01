using System;

namespace methodExercise;

internal class program
{
    public static void Main(string[] argus)
    {
        string userName;
        string userAge;
        string userGameConsole;
        string userFavoriteGame;

        Console.WriteLine("What is your name?");
        userName = Console.ReadLine();
        Console.WriteLine("How old are you?");
        userAge = Console.ReadLine();
        Console.WriteLine("What is your gaming console of chose?");
        userGameConsole = Console.ReadLine();
        Console.WriteLine("What is your Favorite game?");
        userFavoriteGame = Console.ReadLine();
        if (userGameConsole == "xbox")
        {
            Console.WriteLine("I perfer to use xbox as well");
            Console.WriteLine($"I love to play {userFavoriteGame} on my xbox");
        }
        if (userGameConsole == "playstation")
        {
            Console.WriteLine("I perfer to use Playstation to");
            Console.WriteLine($"I love to play {userFavoriteGame} on my Playstation");
        }
        Console.WriteLine($"{userName} is {userAge} and plays their favorite game {userFavoriteGame} on their {userGameConsole}");

        Console.WriteLine("Time to do some math");
        Console.WriteLine("Please enter two numbers you would like added together");
        int num1 = int.Parse(Console.ReadLine());
        int num2= int.Parse(Console.ReadLine());
        int add = addition(num1, num2);
        Console.WriteLine(add);

        Console.WriteLine("Please enter two numbers you would like subracted from eachother");
        int num3= int.Parse(Console.ReadLine());
        int num4= int.Parse(Console.ReadLine());
        int sub = subtraction(num3, num4);
        Console.WriteLine(subtraction);

        Console.WriteLine("Please enter two numbers you would like mutiplyed together");
        int num5 = int.Parse(Console.ReadLine());
        int num6 = int.Parse(Console.ReadLine());
        int mut = multiplication(num5, num6);
        Console.WriteLine(mut);

        Console.WriteLine("Last but not least enter two numbers to divide");
        int num7 = int.Parse(Console.ReadLine());
        int num8 = int.Parse(Console.ReadLine());   
        int div = division(num7, num8);
        Console.WriteLine(div);


    }

    public static int addition(int num1,int num2)
    {
        return num1 + num2;
    }
 
    public static int subtraction(int num3,int num4)
    {
        return num3 - num4;
    }
    public static int multiplication(int num5,int num6)
    {
        return num5 * num6;
    }
    public static int division(int num7,int num8)
    {
        return num7 % num8;
    }
}



 
















