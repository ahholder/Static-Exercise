namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double temp = 0;
            string input = "";
            double far = 0;
            double cel = 0;
            Console.Write("Enter Temperature: ");
            input = Console.ReadLine();
            if (input != null && double.TryParse(input, out var placeholder) == true) temp = double.Parse(input);
            cel = TempConverter.CelsiusToFahrenheit(temp);
            far = TempConverter.FahrenheitToCelsius(temp);
            Console.WriteLine($"{temp} Celsius becomes {far} Fahrenheit.");
            Console.WriteLine($"{temp} Fahrenheit becomes {cel} Celsius.");
        }
    }
}
