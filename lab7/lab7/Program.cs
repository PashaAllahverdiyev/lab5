input:
Console.Write("Say daxil edin: ");
bool check = int.TryParse(Console.ReadLine(), out int val);
if (check)
{
    goto input;
}
int[] arr = new int[val];
arr[0] = 0;
arr[1] = 1;
for (int i = 2; i < arr.Length; i++)
{
    arr[i] = arr[i - 2] + arr[i - 1];
}
foreach (int i in arr)
{
    Console.WriteLine(i);
}