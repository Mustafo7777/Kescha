string password ="";
do{
  System.Console.WriteLine("kodni kiriting :");
  password= Console.ReadLine();
}
while (password != "1111");

System.Console.Write("Ismingizni kiriting : ");
string name = System.Console.ReadLine();
string greeting = $"Salom, {name}, Kescha dasturiga xush kelibsiz!";
System.Console.WriteLine(greeting);