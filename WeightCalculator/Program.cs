namespace WeightCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            weightEquation weightCalculate01 = new weightEquation
            {
                Height = 176,
                Gender = 'w'
            };

            int weight = weightCalculate01.WeightUsingEquation();
            Console.WriteLine($"Weight = {weight}");
            int expected = 64;
            //for Manual testing 
            if (weight == expected)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("failed");
            }
        }
    }
}
