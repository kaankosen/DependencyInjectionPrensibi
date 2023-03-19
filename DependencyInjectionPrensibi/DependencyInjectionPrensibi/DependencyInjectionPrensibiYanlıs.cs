using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPrensibi
{
    public class DependencyInjectionPrensibiYanlıs
    {
        class Araba
        {
            public void GazVer()
            {
                Console.WriteLine("Gaz verildi");
            }
            public void FrenYap()
            {
                Console.WriteLine("Fren yapıldı");
            }
            public void SagaSinyal()
            {
                Console.WriteLine("Sağa sinyal verildi");
            }
            public void SolaSinyal()
            {
                Console.WriteLine("Sola Sinyal verildi");
            }
        }

        class Vasita
        {
            Araba araba;
            public Vasita()
            {
                araba = new Araba();
            }

            public void Kullan()
            {
                araba.GazVer();
                araba.SagaSinyal();
                araba.FrenYap();
                araba.SolaSinyal();
            }
        }
    }
}
