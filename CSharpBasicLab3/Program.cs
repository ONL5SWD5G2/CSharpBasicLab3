
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
Console.Write("enter number: ");
int num = int.Parse(Console.ReadLine());
string binary = "";

while (num > 0)
{
    binary = (num % 2) + binary;
    num = num / 2;
}

Console.WriteLine("binary is: " + binary);
#endregion

#endregion
