int sumDivision = 0;
int amountDivision = 0;
int count;
int limit;
int variable;
Console.WriteLine("Enter first num: " );
count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter last num: " );
limit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the variable you want to divide the number by : " );
variable = Convert.ToInt32(Console.ReadLine());

while (count <= limit)
{
    if (count % variable == 0)
    {
        sumDivision = sumDivision + count;
        amountDivision++;
    }
     
    
count++;
}


Console.WriteLine("Sum of numbers which divide on variable: " + sumDivision);
Console.WriteLine("Amount of numbers which divide on variable: " + amountDivision);



