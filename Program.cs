// Distance Calculator By Kevin
#nullable disable

// WELCOME
Console.Clear();
Console.WriteLine("WELCOME TO THE DISTANCE CALCULATOR!");

Console.Write("Enter x1 value: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y1 value: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter x2 value: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y2 value: ");
int y2 = Convert.ToInt32(Console.ReadLine());

// Process
int distance = (int)Math.Sqrt((x2-x1) * (x2-x1)+ (y2-y1) * (y2-y1));

// Output
Console.WriteLine($"Distance between the two points is {distance}");




