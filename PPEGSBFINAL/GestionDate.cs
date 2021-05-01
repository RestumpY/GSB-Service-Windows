using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEGSBFINAL
{
    public class GestionDate
    {

        public String dateDuJour()
        {
            DateTime now = DateTime.Now;
            string asString = now.ToString("yyyyMM");
            return asString;
        }

        public String dateMoisPrecedent()
        {
            DateTime now = DateTime.Now;

            now = now.AddMonths(-1);
            string asString = now.ToString("yyyyMM");
            return asString;

        }


        public string getJour()
        {
            DateTime date = DateTime.Now;
            string asString = date.ToString("dd");
            return asString;
        }



    }
}
