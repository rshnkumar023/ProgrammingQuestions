using System.Linq;

public class Stringtest
{
    public static void Main(String[] args)
    {
        Console.WriteLine("please Insert the String to Test");
        string inputString = Console.ReadLine();
        //Method To Get Number of Vowels
        //TestVowels(inputString);
        FindDuplicate(inputString);
        Console.ReadLine();
    }




    //Find Number of Vowels in Input String
    public static void TestVowels(string inputString)
    {


        int counter = 0;

        for (int i = 0; i < inputString.Length; i++)
        {
            if (inputString[i] == 'a' || inputString[i] == 'e' || inputString[i] == 'i' || inputString[i] == 'o' || inputString[i] == 'u')
            {
                counter++;
            }
        }
        System.Console.WriteLine("Number of vowels " + counter);

    }
    //Find duplicate characters in a string
    public static void FindDuplicate(string inputString)
    {
        // Declare an array of size 256 as we have 256 chracters in ASCII 
        int[] inputArray = new int[256];


        //run a foreach loop to get the ascii value of all characters of inputstring
        foreach (char c in inputString)
        {
            inputArray[c]++;
            Console.WriteLine(c);
        }

        for (int i = 0; i < 256; i++)
        {
            if (inputArray[i] > 1)
                Console.WriteLine(i);
        }

    }
}


