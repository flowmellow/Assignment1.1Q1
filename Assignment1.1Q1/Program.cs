// Create a simple console application and store your name, age (should take decimal),
// address in a string variable and print them back on console. Prompt the user to each time enter name, age and address.

string name;
double age;
string address;

Console.WriteLine("Hello, to utilize this application please follow the upcoming prompts.");
Console.WriteLine("What is your name: ");
name = Console.ReadLine();
Console.WriteLine("Your name is:" + name);

Console.WriteLine(); // added for spacing
Console.WriteLine("What is your age:");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);

Console.WriteLine();// added for spacing
Console.WriteLine("What is your address:");
address = Console.ReadLine();
Console.WriteLine("Your address is: " + address);


