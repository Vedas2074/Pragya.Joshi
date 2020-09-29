using System;
class Methods
{
    void Printinfo()
    {
        Console.WriteLine("Printing Something..");
        Multiply(23.5f, 2234.657f);

        Sum(2.3, 45.1);
        Sum(2.3, 45.1, 1);

        Greet("Pragya","Mrs.");
        Greet("Bishnu");

        byte[] numbers = {2, 4, 6, 8, 12, 18, 58}; 
        (byte Min , byte Max) result = FindMinMax(numbers);
        PrintCustomerDetails(age : 24, name : "Pragya", isfemale : true, address : "Lalitpur");


    }

    void PrintSomething(string message)
    {
        Console.WriteLine(message);
        
    }

    float Multiply(float firstNum, float secondNum)
    {
        float product = firstNum * secondNum;
        return product;
    }
    float Multiply(float firstNum, float secondNum, float thirdNUm)
    {
        float product = firstNum * secondNum * thirdNum;
        return product;
    }

    double Sum(params double[] numbers)
    {
        double sum = 0;
        foreach(double num in numbers)
        { 
            sum = sum + num;

        }
        return sum;

    }

    //optional arguments
    string Greet(string name, string prefix = "Mrs.")
    {
        string fullName = $"{prefix} , {name}"; //string interpolatiom
        return fullName;
    }

    //Returning MUltiple Values : using tuples
    (byte, byte) FindMinMax(byte[] numbers)
    {
         byte max = numbers.Max();
         byte min = numbers.Min();

         return (min, max);
    }

    void PrintCustomerDetails(string name, byte age, string address)
    {
        Console.WriteLine($"{name}[{age}], {address}");
    }

    //Expression bodied method syntax

    float Subtract(float firstNum, float secondNum) => firstNum - secondNum;

}
