namespace DSAProblem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Choose a number to go to the respective problem \n");
            Console.WriteLine("1 for Permutation");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //UC1
                    Permutation permutationsofstring = new Permutation();
                    permutationsofstring.permutations();
                    break;
            }
        }
    }
}