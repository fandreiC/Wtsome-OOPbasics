using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class Room
    {
        public string name;
        public Rate pret;
        public int NrOfAdults;
        public int NoOfChildren;

        public Room() : this("No name",2,0) { }
        public Room(string nume) : this(nume,3,1) { }
        public Room(string nume,int nrPersoane, int nrCopii)
        {
            this.pret = new Rate(1200);
            this.name = nume;
            this.NrOfAdults = nrPersoane;
            this.NoOfChildren = nrCopii;
        }
        public double GetPriceForDays(int nrOfDays)
        {
            return nrOfDays * this.pret.Amount;
        }
        public void PrintRoomInfo()
        {
            Console.WriteLine("Room info : name : {0} , pret : {1:C} {4} , numar persoane : {2} , numar copii : {3}",
                this.name,this.pret.Amount,this.NrOfAdults,this.NoOfChildren,Rate.cUrrency);

        }
    }
}
