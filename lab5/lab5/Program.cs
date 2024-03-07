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
int[] secondArr = { 19, -6, 32};
bool check = false;
for (int i = 0; i < secondArr.Length; i++)
{
    check = false;
  for (int j = 0; j <firstArr.Length; j++)
    {
        if (secondArr[i]==firstArr[j])
        {
            check = true;
            break;
        }
    }
       if(check==false)
        {
            check=false;
            break;
        }
}
    Console.WriteLine(check);