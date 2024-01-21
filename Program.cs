using System;

class Program
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        int size = 10; // Change the size of the array as needed
        int minValue = 1; // Change the minimum value as needed
        int maxValue = 100; // Change the maximum value as needed

        int[] randomArray = GenerateRandomIntArray(size, minValue, maxValue);


        for(int i = 0; i < randomArray.Length; i++)
        {
            Console.Write(randomArray[i] + " ");
        }

        BubbleSort(randomArray);
        Console.WriteLine();

        for (int i = 0; i < randomArray.Length; i++)
        {
            Console.Write(randomArray[i] + " ");
        }
    }

    static int[] GenerateRandomIntArray(int size, int minValue, int maxValue)
    {
        if (size <= 0 || minValue > maxValue)
        {
            throw new ArgumentException("Invalid arguments");
        }

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(minValue, maxValue + 1);
        }
        return arr;
    }
    public static void BubbleSort(int[] arr)
    {
        int arrayLength = arr.Length;
        bool hasSwapped;


        for (int currentPass = 0; currentPass < arrayLength - 1; currentPass++)
        {
            hasSwapped = false;
            for (int currentIndex = 0; currentIndex < arrayLength - 1 - currentPass; currentIndex++)
            {
                if (arr[currentIndex] > arr[currentIndex + 1])
                {
                    // Store the value of the element at currentIndex in a temporary variable called temp
                    int temp = arr[currentIndex];

                    // Replace the value at currentIndex with the value of the next element (currentIndex + 1)
                    arr[currentIndex] = arr[currentIndex + 1];

                    // Assign the original value (stored in temp) back to the next element, completing the swap
                    arr[currentIndex + 1] = temp;

                    hasSwapped |= true;
                }
            }
            if (!hasSwapped) { break; }
        }

    }

}
