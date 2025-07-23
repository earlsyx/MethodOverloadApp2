using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create hotel room model
            HotalRoomModel room = new HotalRoomModel();

            room.TurnOnAir().SetTemparature(72).OpenShades();//chaining
            //since each one return a hotel room model.
            // the return alue of air is what we work on temp, and return value of temp is the one we work on openshades  
            // since we return the same object we can do multiple things on it
            //OpenShades(SetTemperateure(TurnOnAir(room)));

            //known as fluent design - use to extend your own things or something you dont control, this method. , has o b static c lass,has to be static method, also this kewotd ciritcal, if it's dont have ti then it's just the moherod

            room.TurnOffAir().CloseShades();
            //readable et of fmethod calls.
            "HelloWorld".PrintToConsole();
            Console.ReadLine();
        }
    }

    public class HotalRoomModel
    {
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; }
    }
    public static class ExtensionSamples
    {
        //extension methods haet obe static and need to be in a static classs
        // note: keyword this. -indiciates exnstion metthod.
        // extending string, attaching own method to string
        public static void PrintToConsole(this string message) {
            Console.WriteLine(message);

        }

        //extension emthods, extending hotel room model 

        public static HotalRoomModel TurnOnAir(this HotalRoomModel room)
        {
            room.IsAirRunning = true;
            return room;
        }
        public static HotalRoomModel TurnOffAir(this HotalRoomModel room)
        {
            room.IsAirRunning = false;
            return room;
        }


        public static HotalRoomModel SetTemparature(this HotalRoomModel room, int temperature)
        {
            room.Temperature = temperature;
            return room;
        }

        public static HotalRoomModel OpenShades(this HotalRoomModel room)
        {
            room.AreShadesOpen = true;
            return room;
        }

        public static HotalRoomModel CloseShades(this HotalRoomModel room)
        {
            room.AreShadesOpen = false;
            return room;
        }
    }
}
