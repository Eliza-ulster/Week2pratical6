Main();

static void Main()
{
    int option = 0;
    double radius = 0;
    double height= 0;
    double volumeOfCylinder= 0;
    do
    {
        Console.WriteLine("1.Enter radius to find area of a circle");
        Console.WriteLine("0. Exit qpplication");
        Console.WriteLine("Enter an option:");

        option = Convert.ToInt32(Console.ReadLine());

        switch(option)
        {
            case 0:
                Console.WriteLine("Goodbye");
                break;
            case 1:
                Console.WriteLine("Enter radius:");
                radius = Convert.ToDouble(Console.ReadLine());
                double circleArea = CircleArea(radius);
                Console.WriteLine($"Area of the cylinder is {circleArea}");
                break;

            default:
                Console.WriteLine("Please enter a valid option");
                break;
        }
    }
    while (option != 0) ;
}
static double CircleArea(double radius)
{
    double area = Math.PI * Math.Pow(radius, 2);
    
    return area;
}