using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class Hotel
    {
        private string name;
        private string city;
        public LinkedList<Room> listOfRooms= new LinkedList<Room>();
        private readonly int numarCamere;

        public string Name { get; set; }
        public string City { get; set; }
        public int NumarCamere { get; set; }

        public Hotel():this("NoName Hotel","Iasi City",5) { }
        public Hotel(string nume) : this(nume, "Iasi City", 5) { }
        public Hotel(string nume, int numarcam) : this(nume, "Iasi City", numarcam) { }
        public Hotel(string nume,string oras,int numarcam)
        {
            Name = nume;
            this.City = oras;
            this.NumarCamere = numarcam;
            for (int i = 0; i < numarcam; i++)
            {
                string numec = string.Concat("Camera ", i);
                this.listOfRooms.AddLast(new Room(numec));
            }
        }
        public double getPriceForRooms(int numberOfRooms)
        {
            double preturi = 0;
            foreach (var cam in listOfRooms)
            {
                preturi += cam.pret.Amount;
            }
            return preturi;
        }
        public void PrintHotelInfo()
        {
            Console.WriteLine("\nHotel info: name: {0} , City: {1} , Number of Rooms: {2} , totalprice of rooms: {3} , \n",
                this.Name,this.City,this.NumarCamere,this.getPriceForRooms(NumarCamere));
            foreach (var cam in listOfRooms)
            {
                Console.WriteLine("List of Rooms- name:{0}, pret: {1} {2}",cam.name,cam.pret.Amount,Rate.cUrrency);
            }
        }

    }
}
