// temp <= 0 - Freezing cold
//temo > 0 AND temp < 10 - cold
//tmeps >=10 AND temp < 15 - Chilly
//temp >= 15 AND temp < 20 - warm
//temo >=20 AND temp < 30 - hot
//temp >= 30 - Boiling hot


Console.WriteLine("Enter the temperature: ");
int temp = Int32.Parse(Console.ReadLine());


if(temp >= 30)
{
    Console.WriteLine("Boiling hot");
}
else if(temp <30  && temp >= 20)
{
    Console.WriteLine("Hot");

}
else if(temp < 20 && temp >= 15)
{
    Console.WriteLine("Warm");

}
else if(temp < 15 && temp >= 10)
{
    Console.WriteLine("Chilly");

}
else if (temp < 10 && temp >= 0)
{
    Console.WriteLine("Cold");

}
else
{
    Console.WriteLine("Freezing cold");

}