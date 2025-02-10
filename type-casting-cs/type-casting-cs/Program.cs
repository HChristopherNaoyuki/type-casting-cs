internal class Program
{
    private static void Main(string[] args)
    {
        /* Type Casting with Exception Handling
         * Converting a value to a different data type.
         * If conversion fails, an exception will be caught and handled.
         */

        const double PiValue = 3.1415;

        try
        {
            int piAsInteger = Convert.ToInt32(PiValue);  // Convert double to int
            int integerValue = 111;
            double resultValue = Convert.ToDouble(integerValue) + 1.12; // Convert int to double

            Console.WriteLine("PiValue's type: " + typeof(double)); // Show the type of PiValue (double)
            Console.WriteLine("piAsInteger (converted from PiValue): " + piAsInteger);  // This will show the int value of PiValue (rounded down)
            Console.WriteLine("resultValue: " + resultValue);  // This will show the double value

            // Show the type of piAsInteger and resultValue
            Console.WriteLine("piAsInteger's type: " + piAsInteger.GetType());
            Console.WriteLine("resultValue's type: " + resultValue.GetType());
        }
        catch (FormatException ex)
        {
            // This block handles issues with incorrect format during conversion (though unlikely here)
            Console.WriteLine("Error: Invalid format for conversion. " + ex.Message);
        }
        catch (InvalidCastException ex)
        {
            // This block handles invalid casting errors
            Console.WriteLine("Error: Invalid type cast. " + ex.Message);
        }
        catch (OverflowException ex)
        {
            // This block handles errors when a conversion overflows (e.g., too large or too small for the target type)
            Console.WriteLine("Error: Overflow during conversion. " + ex.Message);
        }
        catch (Exception ex)
        {
            // This block catches any other general exceptions
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
