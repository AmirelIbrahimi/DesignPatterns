using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            // Create instances of displays 
            new CurrentConditionDisplay(weatherData);
            new ForecastDisplay(weatherData);
            new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(8, 80, 1013.2f);
            weatherData.SetMeasurements(18, 60, 1018.5f);
            weatherData.SetMeasurements(30, 35, 1008.7f);
        }
    }
}