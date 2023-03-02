//1.Verilmiş ədədlər siyahısını artan sıra ilə düzülmüş ədədlər halına gətirən alqoritmi.
using System.ComponentModel.Design;

int[] numbers =  { 2, 1, 8, 0, 4, 3, 5, 7, 9 };
Array.Sort(numbers);
for (int n = 0; n < numbers.Length; n++)
{

    Console.WriteLine(numbers[n]);
}



//2
int[] array1 = { 1, 3, 6, 7, 8, 9 };
int[] array2 = { 6, 3, 1, 9, 8, 7 };
Array.Sort(array1);
Array.Sort(array2);
int count = 0;
for (int m = 0;m < array1.Length; m++)
{
    if (array1[m] == array2[m])
    {
        count++;   
    }
 }
if (array1.Length == count)
{
    Console.WriteLine(true);
}
else { Console.WriteLine(false); }





//3.
int[] nums = { 4, 6, 2, 8, 5, 12, 65 };
int m = 5;
int max = 0;
int min = nums.Length - 1;
int mid;
while (max >= min)
{
    mid = (max + min) / 2;
    if (nums[mid] == m)
    {
    Console.WriteLine(mid);
    break;

    }
else if (nums[mid]>m) {
        max = mid - 1;
}
    else if (nums[mid]<m)
    {
        min = mid + 1;
    }
    else { Console.WriteLine(1); }
}

