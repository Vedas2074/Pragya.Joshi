using System;
<<<<<<< HEAD
class IterationStatement{
    //PascalCase -> method name, class name
    //camelCase -> variable name 

    
    void LearnForLoops()
    {
        
        int [] numbers = {4,5,6,7,8,9,10};
        foreach(int num in numbers){
            if (num % 2 !=0){
                Console.WriteLine(num);
            }
        }

    }

    void LearnWhileLoops()
    {
        string confirm = "Y";
        while(confirm == "Y")
        {
            Console.WriteLine("HEllo");
            Console.WriteLine("Want to print more?");
            confirm = Console.ReadLine();
        }
    }
}
=======
class IterationStatement
{
    // Pascal case: IterationStatement
    // Camel case: iterationStatement
    static void Main()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnForLoops();
    }

    void LearnForLoops()
    {
        Console.WriteLine("Hello world");
    

    int [] numbers =  {4, 5, 66, 78, 88 };
    foreach(int num in numbers)
    {
        Console.WriteLine(num);

        
    }
    }
    }

>>>>>>> 15e0cfe3bd5864d0df63435b2e7cf1bf606bc90f
