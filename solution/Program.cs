Console.WriteLine("Use default array? type: (y/n)");
ConsoleKeyInfo userAnswer = Console.ReadKey();
string [] inputArray = new string [0];
string [] resultArray = new string [0];

if (userAnswer.Key == ConsoleKey.Y)
{
    string[] defaultArray = new string[] { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer scince", "Russia", "Denmark", "Kazan" };
    Array.Resize (ref inputArray, defaultArray.Length);
    Array.Copy (defaultArray, 0, inputArray, 0, inputArray.Length);
    Console.WriteLine($"\nDefault array is:");
    printArray(inputArray);
    Console.WriteLine();
}
else if (userAnswer.Key == ConsoleKey.N)
{
    Console.WriteLine("\nType any words, separate them with 'space'");
    string userInput = Console.ReadLine();
    inputArray = userInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
}
else
{
    Console.WriteLine("Incorrect inputs. The program will be terminated. Try again");
    return;
}

int i = 0;
foreach (string input in inputArray)
{
    if (input.Length <= 3)
    {
        Array.Resize(ref resultArray, resultArray.Length+1);
        resultArray[i] = input;
        i++;
    }
}
Console.WriteLine("Result array is:");    
printArray(resultArray);

void printArray (string [] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        else
        {
            Console.Write($"\"{array[i]}\"");
        }
    }
    Console.Write("]");
}
