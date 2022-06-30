namespace DSAProblem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Choose a number to go to the respective problem \n");
            Console.WriteLine("1 for Permutation");
            Console.WriteLine("2 for BinarySearch");

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
            }
        }
    }
}