Console.WriteLine("What is your room's length?");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("What is your room's width?");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("What is your room's height?");
double height = double.Parse(Console.ReadLine());

double perimeter = length + length + width + width;
double area = length * width;
double volume = length * width * height;
double surfaceArea = (2 *(length * width)) + (2*(length * height)) + (2*(height * width));

Console.WriteLine("Your room's perimeter is " + perimeter + " feet");
Console.WriteLine("Your room's area is " + area + " square feet");
Console.WriteLine("Your room's volume is " + volume + " cubic feet");
Console.WriteLine("Your room's surface area is " + surfaceArea + " square feet");

if (area >= 650)
{
    Console.WriteLine("This is a large room");

} else if (area >= 250)
{
    Console.WriteLine("This is a medium-sized room");
} else if (area >= 0)
{
    Console.WriteLine("This is a small room");
} else
{
    Console.WriteLine("Bro, your room can't possibly exist.. how did you measure that on a tape measure?");
}