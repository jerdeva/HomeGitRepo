namespace Module1HW3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter N: ");
        string n = Console.ReadLine();
        int n2 = Convert.ToInt32(n);

        int[] nums = new int[n2];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = new Random().Next(1, 27);
        }

        int oddCount = 0;
        int evenCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        int[] numsOdd = new int[oddCount];
        int[] numsEven = new int[evenCount];
        oddCount = 0;
        evenCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                numsEven[evenCount] = nums[i];
                evenCount++;
            }
            else
            {
                numsOdd[oddCount] = nums[i];
                oddCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Even: ");
        for (int i = 0; i < numsEven.Length; i++)
        {
            Console.Write("[" + i + "]: " + numsEven[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Odd: ");
        for (int i = 0; i < numsOdd.Length; i++)
        {
            Console.Write(i + ": " + numsOdd[i] + " ");
        }

        char[] alphabet = new[] { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Odd chars: ");
        char[] oddChars = new char[numsOdd.Length];
        for (int i = 0; i < numsOdd.Length; i++)
        {
            oddChars[i] = alphabet[numsOdd[i] - 1];
            Console.Write("'" + oddChars[i] + "', ");
        }

        Console.WriteLine();
        Console.WriteLine("Even chars: ");
        char[] evenChars = new char[numsEven.Length];
        for (int i = 0; i < numsEven.Length; i++)
        {
            evenChars[i] = alphabet[numsEven[i] - 1];
            Console.Write("'" + evenChars[i] + "', ");
        }
    }
}