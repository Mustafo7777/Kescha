System.Console.Write("Ismingizni kiriting : ");
string name = System.Console.ReadLine();
string greeting = $"Salom, {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Ali yoshini kiriting : ");
string ageAsString = System.Console.ReadLine();
int age =Convert.ToInt32(ageAsString);
System.Console.Write("Valini yoshini kiriting : ");
string keschasAgeAsString =  System.Console.ReadLine();
int keschasAge = Convert.ToInt32(keschasAgeAsString);

System.Console.WriteLine($"Ali katta Validan {age> keschasAge}");
System.Console.WriteLine($"Ali kichkina Validan {age< keschasAge}");
System.Console.WriteLine($"Ali katta yoki teng Validan {age>= keschasAge}");
System.Console.WriteLine($"Ali kichkina Validan {age <= keschasAge}");
System.Console.WriteLine($"Ali bilan Vali teng {age == keschasAge}");
System.Console.WriteLine($"Ali bilan Vali teng emas {age != keschasAge}");