/*
 * Add the sum of 10 integers 9, 1, 6, 9, 2, 4 , 5, 3, 1, 3
 * Also caluate the average
 */

int[] nbrs = { 9, 1, 6, 9, 2, 4, 5, 3, 1, 3 };

int index = 0;

int sum = nbrs[index] + nbrs[++index] + nbrs[++index] + nbrs[++index] + nbrs[++index] + nbrs[++index] + nbrs[++index] + nbrs[++index] + nbrs[++index] + nbrs[++index];

double average;
Console.WriteLine($"Sum is {sum}");

int sum2 = 0;
for (int i = 0; i < nbrs.Length; i++)
{
    sum2 = sum2 + nbrs[i];
}
Console.WriteLine($"The sum is {sum2}");

double sum3 = sum2;
average = sum3 / nbrs.Length;

Console.WriteLine($"The average is {average}");

var sum4 = nbrs.Sum();

Console.WriteLine($"The sum is {sum4}");

Console.WriteLine($"The sum is {nbrs.Sum()}");

Console.WriteLine($"The Average is {nbrs.Average()}");
