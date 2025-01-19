using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstCoreApp.Learning;

namespace FirstCoreApp.MainRun
{
    public class MainRun
    {
        public static void Main(string[] args)
        {
            //Car CitroenPicasso = new Car("Citroen Picasso", 200, 4);
            //CitroenPicasso.DisplayCarDetails();

            //Human emptyHuman = new Human();
            //emptyHuman.Introduction();

            //Human isma = new Human("Ismael", "Naciri", "brown", 22, Human._Gender.Male);
            //isma.Introduction();


            Box box1 = new Box(14.9f, 13.2f, 15f);
            box1.DisplayInfo();
            box1.Length = 99.9346743f;
            box1.RecalculateVolume();
            box1.DisplayInfo();
        }
    }
}
