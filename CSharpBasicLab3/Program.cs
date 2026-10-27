
#region part1

#region 1
//Console.Write("enter text: ");
//string input = Console.ReadLine();
//string result = "";

//for (int i = input.Length - 1; i >= 0; i--)
//{
//    result = result + input[i];
//}

//Console.WriteLine("reversed: " + result);
#endregion

#region 2
//Console.Write("enter number: ");
//int num = int.Parse(Console.ReadLine());
//string binary = "";

//while (num > 0)
//{
//    binary = (num % 2) + binary;
//    num = num / 2;
//}

//Console.WriteLine("binary is: " + binary);
#endregion

#endregion

#region part2

#region 3
//int[] arr1 = { 1, 3, 5 };
//int[] arr2 = { 2, 4, 6 };
//int[] merged = new int[6];

//for (int i = 0; i < 3; i++) merged[i] = arr1[i];
//for (int i = 0; i < 3; i++) merged[i + 3] = arr2[i];
//Array.Sort(merged);
#endregion

#region 4
//int[] arr = { 1, 2, 2, 3, 1 };

//for (int i = 0; i < arr.Length; i++)
//{
//    int count = 0;
//    for (int j = 0; j < arr.Length; j++)
//    {
//        if (arr[i] == arr[j]) count++;
//    }
//    Console.WriteLine(arr[i] + " appears " + count + " times");
//}
#endregion

#region 5
//int[] numbers = { 10, 5, 20, 8 };
//Array.Sort(numbers);
//Console.WriteLine("second largest: " + numbers[numbers.Length - 2]);
#endregion

#region 6
//int[] cells = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
//int maxdist = 0;

//for (int i = 0; i < cells.Length; i++)
//{
//    for (int j = i + 1; j < cells.Length; j++)
//    {
//        if (cells[i] == cells[j])
//        {
//            int dist = j - i - 1;
//            if (dist > maxdist) maxdist = dist;
//        }
//    }
//}
//Console.WriteLine("max distance: " + maxdist);
#endregion

#region 7
//Console.Write("enter text: ");
//string words = Console.ReadLine();
//string[] splitwords = words.Split(' ');
//Array.Reverse(splitwords);
//Console.WriteLine(string.Join(" ", splitwords));
#endregion

#region 8
//int[,] grid1 = { { 1, 2 }, { 3, 4 } };
//int[,] grid2 = new int[2, 2];

//for (int r = 0; r < 2; r++)
//{
//    for (int c = 0; c < 2; c++)
//    {
//        grid2[r, c] = grid1[r, c];
//        Console.Write(grid2[r, c] + " ");
//    }
//    Console.WriteLine();
//}
#endregion

#endregion

#region part3

#region 9
//static void addval(int x) { x = 10; }
//static void addref(ref int x) { x = 10; }
#endregion

#region 10
//static void changeitem(int[] arr) { arr[0] = 99; }
//static void replacearray(ref int[] arr) { arr = new int[] { 99 }; }
#endregion

#region 11
//static (int sum, int sub) calc(int a, int b, int c, int d)
//{
//    return (a + b, c - d);
//}
#endregion

#region 12
//static int sumdigits(int num)
//{
//    int sum = 0;
//    while (num > 0)
//    {
//        sum += num % 10;
//        num /= 10;
//    }
//    return sum;
//}
#endregion

#region 13
//static bool IsPrime(int num)
//{
//    if (num < 2) return false;
//    for (int i = 2; i < num; i++)
//    {
//        if (num % i == 0) return false;
//    }
//    return true;
//}
#endregion

#region 14
//static void MinMaxArray(int[] arr, ref int min, ref int max)
//{
//    min = arr[0];
//    max = arr[0];
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] < min) min = arr[i];
//        if (arr[i] > max) max = arr[i];
//    }
//}
#endregion

#region 15
//static int factorial(int num)
//{
//    int result = 1;
//    for (int i = 1; i <= num; i++)
//    {
//        result *= i;
//    }
//    return result;
//}
#endregion

#region 16
static string ChangeChar(string text, int index, char newchar)
{
    char[] chars = text.ToCharArray();
    chars[index] = newchar;
    return new string(chars);
}
#endregion

#endregion
