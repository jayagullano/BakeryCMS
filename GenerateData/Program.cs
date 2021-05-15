using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using AuntRosieEntities;

namespace GenerateData
{
    class Program
    {
        static string[] provinces = new string[] {"ON", "BC", "QC", "NS", "PE", "AB" };
        static void Main(string[] args)
        {
            String DatabasePath = @"C:\Users\rulec\OneDrive\Documents\AuntRosieUserInterface\AuntRosieApplication\bin\Debug";
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;

            //GenEventLocations(40);
            //GenEvents(2);
            GenEmployment(30);
            //GenSupplier(30);
            Console.ReadLine();
            conn.Disconnect();
        }

        private static void GenSupplier(int nRecords)
        {
            for(int i = 0; i < nRecords; i++)
            {
                try
                {
                    Supplier insertSupplier = new Supplier();
                    insertSupplier.Name = Company.Name();
                    insertSupplier.ContactFirstName = Name.First();
                    insertSupplier.ContactLasttName = Name.Last();
                    insertSupplier.Phone = GenPhone();
                    insertSupplier.Email = Internet.Email();
                    insertSupplier.City = Faker.Address.City();
                    insertSupplier.Province = GetRandProvince();
                    insertSupplier.Street = Faker.Address.StreetAddress();
                    insertSupplier.PostalCode = GetPostalCode();
                    insertSupplier.Create();
                    //insertSupplier.PostalCode = txtPostalCode.Text.Trim();

                }
                catch
                {

                }
            }
        }

        /// <summary>
        /// Generate random phone number
        /// </summary>
        /// <returns></returns>
        private static string GenPhone()
        {
            return $"({RandomNumber.Next(100, 999)})-{RandomNumber.Next(100, 999)}-{RandomNumber.Next(1000, 9999)}";
        }

        private static void GenEmployment(int nRecords)
        {
            for (int i = 0; i < nRecords; i++)
            {
                try
                {
                    Employee insertEmployee = new Employee();
                    insertEmployee.FirstName = Name.First();
                    insertEmployee.LastName = Name.Last();
                    insertEmployee.Phone = GenPhone();
                    insertEmployee.Email = Internet.Email();
                    insertEmployee.City = Faker.Address.City();
                    insertEmployee.Province = GetRandProvince();
                    insertEmployee.Street = Faker.Address.StreetAddress();

                    insertEmployee.PostalCode = GetPostalCode();
                    insertEmployee.Role = SelectRandomFromString(new string[] { "kitchen assistant", "Helper" });
                    insertEmployee.Type = "F";

                    if (insertEmployee.Type == "F")
                    {
                        insertEmployee.Salary = RandomNumber.Next(500, 4000);
                        insertEmployee.EmploymentDate = DateTime.Now.AddDays(RandomNumber.Next(-500, 0));
                    }

                    insertEmployee.Create();
                }
                catch
                {

                }
            }
        }

        private static string GetPostalCode()
        {
            string[] alphabets = new string[] { "a", "b", "c", "d", "e", "f", "g", "h",
            "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

            return $"{SelectRandomFromString(alphabets)}{RandomNumber.Next(1,9)}{SelectRandomFromString(alphabets)}" +
                $"{RandomNumber.Next(1, 9)}{SelectRandomFromString(alphabets)}{RandomNumber.Next(1, 9)}";
        }

        private static string SelectRandomFromString(string[] choices)
        {
            return choices[RandomNumber.Next(0, choices.Length - 1)].ToUpper();
        }

        private static void GenCustomers(int nRecords)
        {
            //Customer customer = new 
        }

        private static string GetRandProvince()
        {
            return provinces[Faker.RandomNumber.Next(0, provinces.Length-1)];
        }

        private static void GenProduction(int nRecords, RosieEvent rosieEvent)
        {
            List<ProductItem> productItems = ProductItem.GetProductItems();
            int count = productItems.Count;
            Random randGen = new Random();

            for (int i = 0; i < nRecords; i++)
            {
                try
                {
                    ProductItem slctPrdItem = productItems[randGen.Next(0, count - 1)];
                    Production productionToBeCreated = new Production();
                    productionToBeCreated.ProductItemID = slctPrdItem.Id;
                    productionToBeCreated.Quantity = (short)randGen.Next(0, 200);
                    //Set valid dates
                    productionToBeCreated.ProductionDate = DateTime.Now.AddDays(-1 * randGen.Next(0, nRecords))
                        .AddHours(-1 * randGen.Next(0, 12)).AddMinutes(-1 * randGen.Next(0, 30));
                    productionToBeCreated.ExpiryDate = DateTime.Now.AddDays(randGen.Next(5, nRecords + 5))
                        .AddHours(randGen.Next(0, 12)).AddMinutes(randGen.Next(0, 30));
                    productionToBeCreated.Create();
                    //Console.WriteLine(productionToBeCreated);
                    // Add production to event

                    GenEventProduct(Production.GetLastID(), productionToBeCreated.Quantity, rosieEvent);
                }
                catch
                {

                }
            }
        }

        private static void GenEvents(int nRecords)
        {
            List<EventLocation> locations = EventLocation.GetLocations();
            DateTime lastDate = DateTime.Now.AddDays(1);

            foreach(EventLocation location in locations)
            {
                lastDate = GenEvent(nRecords, location, lastDate);
            }
            //Faker.Company.Name()
        }

        private static DateTime GenEvent(int nRecords, EventLocation location, DateTime lastDate)
        {
            DateTime latestDate = lastDate;

            for (int i = 0; i < nRecords; i++)
            {
                try
                {
                    RosieEvent rosieEvent = new RosieEvent();
                    rosieEvent.Name = "";
                    rosieEvent.EventDate = latestDate.AddDays(RandomNumber.Next(1, 5));
                    rosieEvent.LocationId = location.Id;
                    rosieEvent.Type = SelectEventType();
                    rosieEvent.Create();

                    latestDate = rosieEvent.EventDate;
                }
                catch
                {
                    
                }
            }

            return latestDate;
        }

        private static EventType SelectEventType()
        {
            EventType[] types = new EventType[] { EventType.FarmersMarket, EventType.HomeShow, EventType.Other };
            return types[RandomNumber.Next(0, types.Length-1)];
        }

        private static string GenEventLocationName(string[] suffixes)
        {
            string prefix = "";
            int choice = RandomNumber.Next(1);
            if (choice == 1)
            {
                prefix = Company.Name();
            }
            else if(choice ==2)
            {
                prefix = Name.Last();
            }
            else if(choice == 3)
            {
                prefix = Faker.Name.First();
            }
            else
            {
                return "";
            }

            return $"{prefix} {suffixes[RandomNumber.Next(0, suffixes.Length-1)]}";
        }

        private static void GenEventLocations(int nRecords)
        {
            string[] suffixes = new string[] { "Hall", "Symporium", "Valley", "Farmer's Market", "Mart",
                "Centre", "Park", "Lounge", "Community Centre"};
            

            for (int i = 0; i < nRecords; i++)
            {
                try
                {
                    EventLocation eventLocation = new EventLocation();
                    eventLocation.Name = GenEventLocationName(suffixes);
                    eventLocation.Address = new AuntRosieEntities.Address();
                    eventLocation.Address.City = Faker.Address.City();
                    eventLocation.Address.Province = GetRandProvince();
                    eventLocation.Address.Street = Faker.Address.StreetAddress();
                    eventLocation.Create();
                }
                catch
                {

                }
            }
        }

        private static void GenEventProduct(long productionID, short prevQuantity, RosieEvent rosieEvent)
        {
            
                EventProduct eventProduct = new EventProduct();
                eventProduct.ProductionId = productionID;
                eventProduct.EventId = rosieEvent.Id;
                eventProduct.Quantity = (short)Faker.RandomNumber.Next(0, prevQuantity);
                eventProduct.Create();
        }

        private static void GenEmployees()
        {

        }
        
    }
}
