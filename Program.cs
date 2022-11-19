System.Console.Write("Ismingizni kiriting : ");
string name = System.Console.ReadLine();
string greeting = $"Salom, {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Yoshingizni kiriting : ");
string ageAsString = System.Console.ReadLine();
int age =Convert.ToInt32(ageAsString);
System.Console.Write("Keschani yoshini kiriting : ");
string keschasAgeAsString =  System.Console.ReadLine();
int keschasAge = Convert.ToInt32(keschasAgeAsString);
System.Console.WriteLine("Ayiruv amalga oshirilmoqda...");

System.Console.WriteLine($"Muvaffaqiyatli amalga oshirildi!!! Sizning yoshongiz va Keschaning yoshodagi farq {age - keschasAge} ekan");



