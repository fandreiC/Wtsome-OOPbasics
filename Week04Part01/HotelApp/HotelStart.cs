using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    public class HotelStart
    {
        static void Main(string[] args)
        {
            ShowScreen();
        }
        public static void ShowScreen()
        {
            Console.WriteLine("\n ShowScreen of Simple Hotel App \n");
            DoStuff();
            Console.ReadKey();
        }
        public static void DoStuff()
        {
            Rate rata = new Rate();
            rata.printRate();
            Room camera112 = new Room("camera112");
            camera112.PrintRoomInfo();

            Hotel hotel1 = new Hotel("hotel1");
            hotel1.PrintHotelInfo();

            LinkedList<Hotel> listOfHotels = new LinkedList<Hotel>();
            Console.WriteLine("cate hoteluri doriti in lista ?: ");
            int numarhotel = int.Parse(Console.ReadLine());
            for (int i = 0; i < numarhotel; i++)
            {
                string numeH = string.Concat("Hotel ", i+1);
                listOfHotels.AddLast(new Hotel(numeH,(i+1)*2));
            }
            foreach (var hotel in listOfHotels)
            {
                Console.WriteLine("Hoteluri in lista :{0} (camere: {1}) ",hotel.Name,hotel.NumarCamere);
            }
            Console.WriteLine("Introduceti pretul maxim ptr o camera ? :");
            double pretmax = int.Parse(Console.ReadLine());
            foreach (var hotel in listOfHotels)
            {
                foreach (var room in hotel.listOfRooms)
                {
                    //Console.WriteLine("Camera {0} pret {1} vs pret cautat {2}", room.name, room.pret.Amount,pretmax);

                    if (room.pret.Amount < pretmax)
                    {
                        Console.WriteLine("Camera {0} din Hotel{2} are pretul mai mic: {1}", room.name, room.pret.Amount, hotel.Name);
                    }
                }
            }

        }
    }
}
