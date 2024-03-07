//int a = 5;
//for (int i = 1; i <= a; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
int[] firstArr = { 211, 9, -6, 12, 34, 56, 32, 5, 19 };
int[] secondArr = { 19, -6, 32 };
bool check = true;
for (int i = 0; i < firstArr.Length; i++)
{
  for (int j = 0; j < secondArr.Length; j++)
    {
        if (firstArr[i]==secondArr[j])
        {
            Console.WriteLine(check=true);
        }
        else
        {
            Console.WriteLine(check &= false);
        }
    }
}