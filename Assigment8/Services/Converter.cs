namespace Assigment8.Services;

public static class Converter
{
 public static string AppName { get; set; }

 public static double KmToMiles(double km)
 {
  double miles = km * 0.621;
  return miles;
 }

 public static double MileToKm(double mile)
 {
  double miles = mile / 0.621;
  return miles;
 }
}