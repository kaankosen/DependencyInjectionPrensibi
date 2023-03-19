using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPrensibi
{
    public class DependencyInjectionPrensibiDogru
    {
       public class Vasita
        {
            ITasit _tasit;
            public Vasita(ITasit tasit)
            {
                _tasit = tasit;
            }

            public void Kullan()
            {
                _tasit.GazVer();
                _tasit.SagaSinyal();
                _tasit.FrenYap();
                _tasit.SolaSinyal();
            }
        }
       public interface ITasit
        {
            void GazVer()
            {
                Console.WriteLine("Gaz verildi");
            }
            void FrenYap()
            {
                Console.WriteLine("Fren yapıldı");
            }
            void SagaSinyal()
            {
                Console.WriteLine("Sağa sinyal verildi");
            }
            void SolaSinyal()
            {
                Console.WriteLine("Sola sinyal verildi");
            }
        }
       public  class Araba : ITasit
        {
            public void GazVer() {  }
            public void FrenYap() { }
        
            public void SagaSinyal() { }
           
            public void SolaSinyal() { }
            
        }

       public class Otobus : ITasit
        {
            public void GazVer() { }
            public void FrenYap() { }

            public void SagaSinyal() { }

            public void SolaSinyal() { }
        }

       public class Motor : ITasit
        {
            public void GazVer() { }
            public void FrenYap() { }

            public void SagaSinyal() { }

            public void SolaSinyal() { }
        }
    }
}
