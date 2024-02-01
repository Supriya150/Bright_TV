namespace BrightTV // Do not change the namespace name
{
    public class Program // Do not change the class name
    {
        public static void Main(string[] args)  // Do not change the 'Main' method signature
        {
            //Implement your code here
            string model;
            int screenSize;
            string resolution;
            string panelType;
            string operatingSystem;

            Console.WriteLine("Enter the Model");
            model = Console.ReadLine();
            Console.WriteLine("Enter the ScreenSize");
            screenSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Resolution");
            resolution = Console.ReadLine();

            Console.WriteLine("Enter the Panel Type");
            panelType = Console.ReadLine();
            Console.WriteLine("Enter the Operating System");
            operatingSystem = Console.ReadLine();
            TelevisionUtility t1 = new TelevisionUtility();
            t1.Model = model;
            t1.ScreenSize = screenSize;
            t1.Resolution = resolution;
            t1.PanelType = panelType;
            t1.OperatingSystem = operatingSystem;

           // TelevisionUtility t1 = new TelevisionUtility(model, screenSize, resolution, panelType, operatingSystem);
            bool res = t1.ValidateSpecification();
            if (res == false)
            {
                Console.WriteLine("Invalid specification");
            }
            else
            {
                double tot = t1.CalculatePrice();
                double disc = t1.CalculateDiscountedPrice();
                Console.WriteLine("The total price " + tot);
                Console.WriteLine("The discounted price " + disc);
            }
            Console.ReadKey();

        }
    }
}
