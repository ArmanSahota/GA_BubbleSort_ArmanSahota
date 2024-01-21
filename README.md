# GA_BubbleSort_ArmanSahota
 





    public static void BubbleSort(int[] arr){
        int arrayLength = arr.Length;
        bool hasSwapped;
First line is making the function bubble sort
array length is just a shortend arr.length
create the bool has swapped to check if the number has or has not swapped

        for (int currentPass = 0; currentPass < arrayLength - 1; currentPass++)
        {        
        hasSwapped = false;
         
Start with 0 current passes
the current pass has to be less then the array length -1
I think it is array length -1 because if you go through the array 9 times all 10 of the numbers should be in order if the 9 others are already in order
and then each run the pass number goes up 1
         
         for (int currentIndex = 0; currentIndex < arrayLength - 1 - currentPass; currentIndex++)
            {
I think we subtract the current pass so we look at the next index. 
If we stayed on the same index then we would be looking at the same number over and over again but since we add an index and subtract the current pass we look at a different number each time


                if (arr[currentIndex] > arr[currentIndex + 1])
this checks if the current index if greater than the next index

                {
                    // Store the value of the element at currentIndex in a temporary variable called temp
                    int temp = arr[currentIndex];

                    // Replace the value at currentIndex with the value of the next element (currentIndex + 1)
                    arr[currentIndex] = arr[currentIndex + 1];

                    // Assign the original value (stored in temp) back to the next element, completing the swap
                    arr[currentIndex + 1] = temp;

                    hasSwapped |= true;
We create a temperary index to hold our current index since we know that the current index if larger than the index infront of us
the next line we swap the current index with the index infront of it
the line after we assine the temperary index that we were saving to the current index infront of ours

so if the numbers were 7 and 5
7 would save to the temp index
5 would swap with 7
and temp index would swap with the index infront of 5 

                }
            }
        if (!hasSwapped) { break; }
        }
If it has not swapped end the cycle

    }

}


