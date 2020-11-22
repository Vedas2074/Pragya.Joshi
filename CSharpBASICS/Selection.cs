using System;
class SelectionStatement
{
    public void LearnIfElse()
    {
        Console.Write("Enter your age: ");
        string ageString = Console.ReadLine();

        byte age =byte.Parse(ageString);
        if (age > 60)
        {
            Console.WriteLine("You are eligible for pension.");

        }
        else if(age < 60)l
        {
            Console.WriteLine("You are about to eligible for pension.");
        }
        else
        {
            Console.WriteLine("You are not eligible for pension.");
        }

        
    }
    public void LearnSwitchCases()
    {
        Console.Write("Enter your hobby");
        string hobby = Console.ReadLine();

        switch(hobby) 
        {
            case "Travel":
            Console.WriteLine("oh!you are a cool person");
            break;
            case "Sports":
            Console.WriteLine("oh!you must be a healthy person");
            break;
            case "singing":
            Console.WriteLine("oh! you love music");
            break;
            case "poetry":
            Console.WriteLine("oh!you are a writer");
            break;
            default:
            Console.WriteLine("soon you will find your source of interest");
            break;

        }
    }
    
}
