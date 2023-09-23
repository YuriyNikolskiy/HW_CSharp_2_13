Console.Write("Enter a number: ");
string number = Console.ReadLine();
int number1 = Int32.Parse(number);

if(number1>99)
{
    Console.WriteLine(number[2]);
}
else
{
    Console.WriteLine("There is no third digit");
}