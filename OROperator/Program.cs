
//Math >= 90 OR Chemistry >= 90 OR

//math && chemistry || math && bilogy || chemistry && biology

int math, biology, chemistry;

Console.WriteLine("enter your Math reuslts:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("enter your Biology results:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("enter yout Chemistry results:");
chemistry = Int32.Parse(Console.ReadLine());



if((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90 ) || (chemistry >= 90 && biology >= 90 ))
{
    Console.WriteLine("Congratiolation! You got accepted");
}
else
{

    Console.WriteLine("Your application cannot be approved.");

}