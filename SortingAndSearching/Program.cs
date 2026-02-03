namespace SortingAndSearching;

class Program
{
    static void Main(string[] args)
    {
        // Test cases for binary search
        int[] arr1 = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int[] arr2 = { 2, 4, 6, 8, 10 };
        int[] arr3 = { 5 };
        int[] arr4 = { };
        
        // Test case 1: Target found in middle
        Console.WriteLine($"Searching for 7 in [1,3,5,7,9,11,13,15]: {binarySearch(arr1, 7)}"); // Expected: 3
        
        // Test case 2: Target found at beginning
        Console.WriteLine($"Searching for 1 in [1,3,5,7,9,11,13,15]: {binarySearch(arr1, 1)}"); // Expected: 0
        
        // Test case 3: Target found at end
        Console.WriteLine($"Searching for 15 in [1,3,5,7,9,11,13,15]: {binarySearch(arr1, 15)}"); // Expected: 7
        
        // Test case 4: Target not found (too small)
        Console.WriteLine($"Searching for 0 in [1,3,5,7,9,11,13,15]: {binarySearch(arr1, 0)}"); // Expected: -1
        
        // Test case 5: Target not found (too large)
        Console.WriteLine($"Searching for 20 in [1,3,5,7,9,11,13,15]: {binarySearch(arr1, 20)}"); // Expected: -1
        
        // Test case 6: Target not found (in between)
        Console.WriteLine($"Searching for 4 in [1,3,5,7,9,11,13,15]: {binarySearch(arr1, 4)}"); // Expected: -1
        
        // Test case 7: Even length array
        Console.WriteLine($"Searching for 6 in [2,4,6,8,10]: {binarySearch(arr2, 6)}"); // Expected: 2
        
        // Test case 8: Single element array (found)
        Console.WriteLine($"Searching for 5 in [5]: {binarySearch(arr3, 5)}"); // Expected: 0
        
        // Test case 9: Single element array (not found)
        Console.WriteLine($"Searching for 3 in [5]: {binarySearch(arr3, 3)}"); // Expected: -1
    }

    public static int binarySearch(int [] a, int x)
    {
        int low = 0;
        int high = a.Length-1;
        int mid;

        while (low<=high){
            mid = (low + high)/2;
            if (a[mid] < x)
            {
                low = mid+1;
            }
            else if(a[mid]>x)
            {
                high = mid - 1;
            }
            else    
            {
                return mid;
            }
        }
        return -1;
    }
}
