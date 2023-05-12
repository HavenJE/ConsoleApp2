
// Accessing elements of an array using (While loop) and (For loop for modifying values)

class Program
{
    static void Main()
    {
        int[] myScores = { 100, 76, 88, 100, 90 };

        int index = 0;

        Console.WriteLine("The elements of array before initialisation are: ");

        while (index < 5)
        {
            Console.WriteLine("{0, 4}", myScores[index]);
            index++;
        }

        // Changing the values using for loop 
        Console.WriteLine("The array elements post modification are: ");
        for (index = 0; index < 5; index++) 
        {
            myScores[index] += 3;
            Console.WriteLine("{0, 4}", myScores[index]);           
        }
    }
}