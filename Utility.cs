using System;
using System.Security.Cryptography;
using System.Text;

namespace CovidAirlines
{
    public class Utility
    {
        /// <summary>
        /// Hashing function using SHA-512
        /// </summary>
        /// <param name="pass">Raw password as a string</param>
        /// <returns>SHA-512 Hash</returns>
        public static byte[] GenerateHash(string pass)
        {
            using (SHA512 shaM = new SHA512Managed())
            {
                return shaM.ComputeHash(Encoding.UTF8.GetBytes(pass));
            }
        }

        /// <summary>
        /// Set hours, minutes, and seconds to current UTC date 
        /// </summary>
        /// <param name="hours">Hours in military time</param>
        /// <param name="minutes">Minutes in military time</param>
        /// <param name="seconds">Optional: Seconds in military time</param>
        /// <returns>Current UTC date with given time</returns>
        public static DateTime Time(int hours, int minutes, int seconds = 0)
        {
            return new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, hours, minutes, seconds);
        }

        /// <summary>
        /// We award 10 points for every dollar spent
        /// </summary>
        /// <param name="ticketPrice"></param>
        /// <returns>Points</returns>
        public static int CalculatePointsAwarded(double ticketPrice)
        {
            return Convert.ToInt32(ticketPrice * 10);
        }

        /// <summary>
        /// Calculate ticket price based on distance between given cities
        /// - Fixed price of $50
        /// - Every connection is charged $8 for the TSA
        /// - Charge 12 cents per mile
        /// </summary>
        /// <param name="city1ID">Origin City ID</param>
        /// <param name="city2ID">Destination City ID</param>
        /// <returns>Ticket Price based on distance between given cities</returns>
        public static decimal CalculateTicketPrice(int city1ID, int city2ID)
        {
            double fixedPrice = 50.00 + 8.00;
            return Convert.ToDecimal(fixedPrice + CalculateDistanceBetween(city1ID, city2ID) * 0.12);
        }

        /// <summary>
        /// Degree to radian conversion
        /// </summary>
        /// <param name="degree">Latitude or longitude</param>
        /// <returns>Radians</returns>
        private static double ToRadian(double degree)
        {
            return (Math.PI / 180) * degree;
        }

        /// <summary>
        /// Calculate distance between two cities using the Haversine formula
        /// Creds to jammin77 on GitHub
        /// </summary>
        /// <param name="city1ID">Origin City ID</param>
        /// <param name="city2ID">Destination City ID</param>
        /// <returns>Distance, in miles, between two cities</returns>
        public static double CalculateDistanceBetween(int city1ID, int city2ID)
        {
            using (var entities = new CovidAirlinesEntities())
            {
                City city1 = entities.Cities.Find(city1ID);
                City city2 = entities.Cities.Find(city2ID);

                if (city1 == null || city2 == null)
                {
                    return 0;
                }

                double latitude1 = decimal.ToDouble(city1.Latitude);
                double latitude2 = decimal.ToDouble(city2.Latitude);
                double latitudeDifference = ToRadian(latitude2 - latitude1);

                double longitude1 = decimal.ToDouble(city1.Longitude);
                double longitude2 = decimal.ToDouble(city2.Longitude);
                double longitudeDifference = ToRadian(longitude2 - longitude1);

                double a = Math.Sin(latitudeDifference / 2) * Math.Sin(latitudeDifference / 2) +
                Math.Cos(ToRadian(latitude1)) * Math.Cos(ToRadian(latitude2)) *
                Math.Sin(longitudeDifference / 2) * Math.Sin(longitudeDifference / 2);
                double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
                double d = 3960 * c;

                return d;
            }
        }
    }
}
