System.Console.Write("Ismingizni kiriting : ");
string name = System.Console.ReadLine();
string greeting = $"Salom, {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Ali yoshini kiriting : ");
string alisAgeAsString = System.Console.ReadLine();
int alisAge =Convert.ToInt32(alisAgeAsString);
System.Console.Write("Valini yoshini kiriting : ");
string valisAgeAsString =  System.Console.ReadLine();
int valisAge = Convert.ToInt32(valisAgeAsString);
if(alisAge<valisAge)
{
  System.Console.WriteLine("Ali kichkina Validan");
}
else if(alisAge==valisAge)
{
  System.Console.WriteLine("Ali bilan Vali teng");
}
else 
{
    System.Console.WriteLine("Ali katta Validan");
}