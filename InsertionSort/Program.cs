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
            }
        }
    }
}