namespace DSAProblem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Choose a number to go to the respective problem \n");
            Console.WriteLine("1 for Permutation");
            Console.WriteLine("2 for BinarySearch");
            Console.WriteLine("3 for InserationSort");
            Console.WriteLine("4 for BubbleSort");
            Console.WriteLine("5 for MrgeSort");
            Console.WriteLine("6 for Anagram");
            Console.WriteLine("7 for PrimeNumberRange");
            Console.WriteLine("8 for Search Sort Generics");
            Console.WriteLine("9 for PrimePalindromecs");
            Console.WriteLine("10 for Find Number");
            Console.WriteLine("11 for TaskDoneByMaximumAmount");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
               
                    Permutation permutationsofstring = new Permutation();
                    permutationsofstring.permutations();
                    break;
                case 2:
                    BinarySearch Binary = new BinarySearch();
                    Binary.Binary();
                    break;
                case 3:
                   
                    int[] arr = { 12, 11, 13, 5, 6 };
                    InsertionSort Insert = new InsertionSort();
                    Insert.sort(arr);
                    Insert.printArray(arr);
                    break;
                case 4:
                    
                    int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
                    BubbleSort BS = new BubbleSort();
                    BS.bubbleSort(arr1);
                    Console.WriteLine("Sorted array");
                    BS.printArray(arr1);
                    break;
                case 5:
                    
                    int[] arr2 = { 12, 11, 13, 5, 6, 7 };
                   
                    MergeSort Marge = new MergeSort();
                    Marge.sort(arr2, 0, arr2.Length - 1);
                    Console.WriteLine("\nSorted array");
                    Marge.printArray(arr2);
                    break;
                case 6:
                    
                    string str1 = "Atul";
                    string str2 = "Sikarwal";

                    if (Anagram.areAnagram(str1, str2))
                        Console.Write("The two strings are " +
                                      "anagram of each other");
                    else
                        Console.Write("The two strings are " +
                                      "not anagram of each other");
                    break;
                case 7:
                   
                    PrimeNumbers.PrimeNumber();
                    break;
                case 8:

                    Genrics genrics = new Genrics();
                    genrics.SearchingAndSorting();
                    break;
                case 9:
                   
                    PrimePaildrome.countPal(100, 1000);
                    break;
                case 10:
                   
                    FindNumber findnumber = new FindNumber();
                    findnumber.Find();
                    findnumber.Question(12, 23);
                    break;
                case 11:
                    TaskMaxAmount taskdonebymaximumamount = new TaskMaxAmount();
                    taskdonebymaximumamount.tasks();
                    break;

            }
        }
    }
}