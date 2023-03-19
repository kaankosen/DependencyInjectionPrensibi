using static DependencyInjectionPrensibi.DependencyInjectionPrensibiDogru;

class Program
{
    static void Main(string[] args)
    {
        Vasita vasitaAraba = new Vasita(new Araba());
        vasitaAraba.Kullan();
        //veya
        Vasita vasitaOtobus = new Vasita(new Otobus());
        vasitaOtobus.Kullan();
        //veya
        Vasita vasitaMotor = new Vasita(new Motor());
        vasitaMotor.Kullan();
    }
}