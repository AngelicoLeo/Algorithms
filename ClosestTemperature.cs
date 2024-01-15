namespace Algoritms;
public static class ClosestTemperature
{
    public static double ClosestToZero(double[] temperatures)
    {
        if (temperatures == null || temperatures.Length == 0)
        {
            // Return 0 if the array is empty or null
            return 0;
        }

        double closestTemperature = temperatures[0];

        foreach (var temperature in temperatures)
        {
            // Check if the absolute value of the current temperature is closer to 0
            if (Math.Abs(temperature) < Math.Abs(closestTemperature) ||
                (Math.Abs(temperature) == Math.Abs(closestTemperature) && temperature > closestTemperature))
            {
                closestTemperature = temperature;
            }
        }

        return closestTemperature;
    }
}
