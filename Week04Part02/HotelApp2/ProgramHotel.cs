using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp2
{
    class ProgramHotel
    {
        static void Main(string[] args)
        {
            ShowScreen();
            Console.ReadKey();
        }
        public static void ShowScreen()
        {
            var HotelManager = new HotelManager();
            var hotel1 = new Hotel();

            var rate1 = new Rate(100,CurrencyOfRates.USD);
            var room1 = new Room(1,2,0,rate1);
            hotel1.Rooms.Add(room1);

            var rate2 = new Rate(80, CurrencyOfRates.USD);
            var room2 = new Room(2, 1, 0, rate2);
            hotel1.Rooms.Add(room2);

            var rate3 = new Rate(50, CurrencyOfRates.USD);
            var room3 = new Room(3, 1, 1, rate3);
            hotel1.Rooms.Add(room3);

            rate1.PrintRate();
            room1.PrintRoom();
            hotel1.PrintHotel();
            HotelManager.AddHotel(hotel1);

            var hotel2 = new Hotel("Plazza","Iasi");
            HotelManager.AddHotel(hotel2);
            var rate4 = new Rate(40, CurrencyOfRates.USD);
            var room4 = new Room(9, 0, 0, rate4);
            hotel2.Rooms.Add(room4);
            hotel2.PrintHotel();
            HotelManager.PrintManagedHotels();

            var hotel3 = new Hotel("Central", "Roman");
            HotelManager.AddHotel(hotel3);
            var rate5 = new Rate(55, CurrencyOfRates.USD);
            var room5 = new Room(2, 0, 1, rate5);
            hotel3.Rooms.Add(room5);
            hotel3.Rooms.Add(new Room());
            hotel3.Rooms.Add(room5);
            hotel3.Rooms.Add(room1);
            hotel3.Rooms.Add(room5);
            hotel3.Rooms.Add(room1);
            hotel3.PrintHotel();

            HotelManager.PrintManagedHotels();
            HotelManager.FindRoom(70);
            HotelManager.DeleteHotel(hotel1);         
            HotelManager.PrintManagedHotels();
            hotel1.PrintHotel();


        }
    }
 
    public enum CurrencyOfRates
    {
        LEI, USD, GBP
    }
    public class Rate
    {
        public int Amount { get; set; }
        public CurrencyOfRates CurrencyCode { get; set; }

        public Rate() : this(70, CurrencyOfRates.LEI) { }
        public Rate(int amount, CurrencyOfRates currencyCode)
        {
            this.Amount = amount;
            this.CurrencyCode = currencyCode;
        }

        public void PrintRate()
        {
            Console.WriteLine($"Room is {this.Amount} {this.CurrencyCode}");
        }
    }
   public class Room
    {
        public int Number { get; set; }
        public int Adult { get; set; }
        public int Children { get; set; }
        public Rate RRate;

        public Room() : this(007,new Rate(80,CurrencyOfRates.GBP)) { }
        public Room(int number,Rate rate):this(number,2,1,rate) { }
        public Room(int number,int adults,int children,Rate rate)
        {
            this.Number = number;
            this.Adult = adults;
            this.Children = children;
            this.RRate = rate;
        }

        public int getPriceForDays(int nrOfDays)
        {
            return nrOfDays * this.RRate.Amount; 
        }
        public  void PrintRoom()
        {
            Console.WriteLine(" Room Nmbr: {0} , pret: {1} {2} , nr persoane: {3} , nr copii: {4}",
                this.Number,this.RRate.Amount,this.RRate.CurrencyCode,this.Adult,this.Children);
            int a = this.getPriceForDays(7);
            Console.WriteLine("Price for 7 days is : "+a);
        }

    }
    public class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Room> Rooms { get; set; }

        public Hotel() : this("~NoName", "~NoCity") { }
        public Hotel(string name, string city)
        {
            this.Name = name;
            this.City = city;
            this.Rooms = new List<Room>();
        }

        public int getPriceForRooms(int numberOfRooms)
        {
            int sum = 0;
            foreach (var room in Rooms)
            {
                sum += room.RRate.Amount;
            }
            return sum;
        }

        public void PrintHotel()
        {
            Console.WriteLine("Hotel name: {0} , from City: {1} , has {2} rooms, with total cost of {3}",
                this.Name,this.City,this.Rooms.Count,this.getPriceForRooms(Rooms.Capacity));
            Console.WriteLine("Rooms are: ");
            foreach (var room in Rooms)
            {
                Console.WriteLine($"- Room {room.Number} , pret: {room.RRate.Amount} {room.RRate.CurrencyCode}");
            }
        }

    }
    public class HotelManager
    {
        public List<Hotel> Hotels { get; set; }

        public HotelManager()
        {
            this.Hotels = new List<Hotel>();
        }

        public void AddHotel(Hotel hotel)
        {
            this.Hotels.Add(hotel);
        }
        public void DeleteHotel(Hotel hotel)
        {            
            this.Hotels.Remove(hotel);
        }
        public void FindRoom(int amount)
        {
            Console.WriteLine("               Seraching for rooms with price lower than "+amount+" :");
            foreach (var hotel in Hotels)
            {
                foreach (var hotelRoom in hotel.Rooms)
                {
                    if(hotelRoom.RRate.Amount<amount)
                        Console.WriteLine($"Finded Room {hotelRoom.Number} , from hote: {hotel.Name} in city {hotel.City}." +
                            $" Price is : {hotelRoom.RRate.Amount} {hotelRoom.RRate.CurrencyCode}");
                }
            }
        }

        public void PrintManagedHotels()
        {
            Console.WriteLine("List of hotels from HotelManager:");
            foreach (var hotel in Hotels)
            {
                Console.WriteLine($"### hotel name : {hotel.Name} , city {hotel.City}");
            }
        }

    }

}
