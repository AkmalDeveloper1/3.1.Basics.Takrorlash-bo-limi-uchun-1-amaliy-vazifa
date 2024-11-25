// 1.Write a program that displays the sum of odd numbers from 1 to 1000 on the screen.
// 1 dan 1000 gacha bo’lgan toq sonlarni yig’indisini ekranga chiqaradigan dastur tuzing. 
// While loop dan foydalaning!
// //------- 1-way ------- 
uint count1 = 1;
uint sum1 = 0;
while (count1 <= 1000)
{
    sum1 += count1;
    count1 += 2;
}
Console.WriteLine("Result: " + sum1);
//------- 2-way -------    
uint count12 = 1;
uint sum12 = 0;
while (count12 <= 1000)
{
    sum12 += count12 % 2 == 1 ? count12 : 0;
    count12++;
}
Console.WriteLine("Result: " + sum12);

//2.Create a program that displays the product of the largest and smallest 
// values in an array. Use a For loop! 
// -Array ichidagi eng katta va eng kichik qiymatlarni 
// ko’paytmasini ekranga chiqaradigan dastur tuzing. For loop dan foydalaning!
Console.Write("Enter the size of array :");
int size2 = int.Parse(Console.ReadLine());
int[] array2 = new int[size2];
int checkMax2;
int checkMin2;
Random random = new Random();
for (int counter1 = 0; counter1 < array2.Length; counter1++)
    array2[counter1] = random.Next(100);
checkMax2 = array2[0];
checkMin2 = array2[0];
for (int counter2 = 0; counter2 < array2.Length; counter2++)
{
    checkMax2 = checkMax2 > array2[counter2] ? checkMax2 : array2[counter2];
    checkMin2 = checkMin2 < array2[counter2] ? checkMin2 : array2[counter2];
}
foreach (int number in array2) //-------------to check
    Console.Write(number+",");
Console.WriteLine($"\tMax :{checkMax2}\tMin :{checkMin2}");
Console.WriteLine($"Max :{array2.Max()}\tMin :{array2.Min()}");  //----------------- to check

//3. Create a program that calculates x! (x factorial) for an integer of type int entered into the console => int x
// x! Create a program that calculates (x factorial) - 
// - Consolga int tipidagi butun son kiritilgan => int x , x! (x factorial) ni hisoblaydigan dastur tuzing.
Console.Write("Enter the number: ");
int number3 = int.Parse(Console.ReadLine());
ulong numberFaktar = 1;
for (int counter = 1; counter <= number3; counter++)
    numberFaktar *= (ulong)counter;
Console.WriteLine("Result: " + numberFaktar);