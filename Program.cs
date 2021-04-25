using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CovidAirlines.Enums;

namespace CovidAirlines
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }

        //Adds all 10 cities to the Cities database - ONLY RUN ONCE ON INITIAL SETUP
        static void AddCities()
        {
            using (var entities = new CovidAirlinesEntities())
            {
                City[] CITIES = new City[10];
                CITIES[0] = new City
                {
                    CityID = 1,
                    Name = "Atlanta, Georgia",
                    Code = "ATL",
                    Latitude = 33.6377988m,
                    Longitude = -84.4292712m
                };
                CITIES[1] = new City
                {
                    CityID = 2,
                    Name = "Nashville, Tennessee",
                    Code = "BNA",
                    Latitude = 36.1195898m,
                    Longitude = -86.683087m
                };
                CITIES[2] = new City
                {
                    CityID = 3,
                    Name = "Cleveland, Ohio",
                    Code = "CLE",
                    Latitude = 41.4066186m,
                    Longitude = -81.8512021m
                };
                CITIES[3] = new City
                {
                    CityID = 4,
                    Name = "Denver, Colorado",
                    Code = "DEN",
                    Latitude = 39.8606676m,
                    Longitude = -104.6853674m
                };
                CITIES[4] = new City
                {
                    CityID = 5,
                    Name = "Dallas, Texas",
                    Code = "DFW",
                    Latitude = 32.8965194m,
                    Longitude = -97.0465221m
                };
                CITIES[5] = new City
                {
                    CityID = 6,
                    Name = "New York City, New York",
                    Code = "JFK",
                    Latitude = 40.6429479m,
                    Longitude = -73.7793734m
                };
                CITIES[6] = new City
                {
                    CityID = 7,
                    Name = "Los Angles, California",
                    Code = "LAX",
                    Latitude = 33.9421675m,
                    Longitude = -118.421393m
                };
                CITIES[7] = new City
                {
                    CityID = 8,
                    Name = "Minneapolis, Minnesota ",
                    Code = "MSP",
                    Latitude = 44.8780191m,
                    Longitude = -93.2209281m
                };
                CITIES[8] = new City
                {
                    CityID = 9,
                    Name = "Chicago, Illinois",
                    Code = "ORD",
                    Latitude = 41.9779849m,
                    Longitude = -87.9093214m
                };
                CITIES[9] = new City
                {
                    CityID = 10,
                    Name = "Seattle, Washington",
                    Code = "SEA",
                    Latitude = 47.4475673m,
                    Longitude = -122.3080159m
                };
                entities.Cities.AddRange(CITIES);
                entities.SaveChanges();
            }
        }

        static void AddRoutes()
        {
            using (var entities = new CovidAirlinesEntities())
            {
                Route newRoute = new Route
                {
                    RouteID = 1
                };
            }
        }
        static void AddUser()
        {
            using (var entities = new CovidAirlinesEntities())
            {
                /*
                User customer = new User
                {
                    UserID = 0,
                    UserType = (byte)UserType.CUSTOMER,
                    FullName = "CUSTOMER DEMO",
                    PasswordHash = Utility.GenerateHash("customer"),
                    Address = "1234 Customer Address",
                    City = "Customer City, State",
                    ZipCode = "99999",
                    PhoneNumber = "9991234567",
                    Age = 99,
                    CardNumber = "1234123412341234",
                    CardExpiryDate = new DateTime(2099, 12, 1),
                    CardCVV = 999,
                    PointsAvailable = 999999999,
                    PointsRedeemed = 0
                };
                
                User loadEngineer = new User
                {
                    UserID = 1,
                    UserType = (byte)UserType.LOAD_ENGINEER,
                    FullName = "LOAD ENGINEER",
                    PasswordHash = Utility.GenerateHash("load"),
                    Address = "1234 Load Address",
                    City = "Load City, State",
                    ZipCode = "11111",
                    PhoneNumber = "9991234567",
                    Age = 99,
                    CardNumber = "1234123412341234",
                    CardExpiryDate = new DateTime(2099, 12, 1),
                    CardCVV = 999,
                    PointsAvailable = 999999999,
                    PointsRedeemed = 0
                };
                */
                User marketManager = new User
                {
                    UserID = 2,
                    UserType = (byte)UserType.MARKETING_MANAGER,
                    FullName = "MARKETING MANAGER",
                    PasswordHash = Utility.GenerateHash("market"),
                    Address = "1234 Market Address",
                    City = "Market City, State",
                    ZipCode = "22222",
                    PhoneNumber = "9991234567",
                    Age = 99,
                    CardNumber = "1234123412341234",
                    CardExpiryDate = new DateTime(2099, 12, 1),
                    CardCVV = 999,
                    PointsAvailable = 999999999,
                    PointsRedeemed = 0
                };
                entities.Users.Add(marketManager);
                
                User flightManager = new User
                {
                    UserID = 3,
                    UserType = (byte)UserType.FLIGHT_MANAGER,
                    FullName = "FLIGHT MANAGER",
                    PasswordHash = Utility.GenerateHash("flight"),
                    Address = "1234 Flight Address",
                    City = "Flight City, State",
                    ZipCode = "33333",
                    PhoneNumber = "9991234567",
                    Age = 99,
                    CardNumber = "1234123412341234",
                    CardExpiryDate = new DateTime(2099, 12, 1),
                    CardCVV = 999,
                    PointsAvailable = 999999999,
                    PointsRedeemed = 0
                };
                entities.Users.Add(flightManager);
                
                User accountant = new User
                {
                    UserID = 4,
                    UserType = (byte)UserType.ACCOUNTANT,
                    FullName = "ACCOUNTING MANAGER",
                    PasswordHash = Utility.GenerateHash("accountant"),
                    Address = "1234 Accountant Address",
                    City = "Accountant City, State",
                    ZipCode = "44444",
                    PhoneNumber = "9991234567",
                    Age = 99,
                    CardNumber = "1234123412341234",
                    CardExpiryDate = new DateTime(2099, 12, 1),
                    CardCVV = 999,
                    PointsAvailable = 999999999,
                    PointsRedeemed = 0
                };
                entities.Users.Add(accountant);
                entities.SaveChanges();
            }
        }
    }
}

