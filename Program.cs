Console.Write("Введите число =>");
string inputedString = Console.ReadLine();  
int number = Convert.ToInt32(inputedString);
int number12 = (number%2);
if (number12 == 0) Console.Write("DA");   
else 
Console.Write("no");