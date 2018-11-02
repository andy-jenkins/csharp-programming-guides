namespace ProgrammingGuides.StaticMembers
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var fordFiesta = new Car(make: "Ford", model: "Fiesta");
            var miniCooper = new Car(make: "Mini", model: "Cooper");
            var seatIbiza = new Car(make: "Seat", model: "Ibiza");

            fordFiesta.Print();
            miniCooper.Print();
            seatIbiza.Print();

            var fiatDoblo = new Van(make: "Fiat", model: "Doblo");
            var fordTransit = new Van(make: "Ford", model: "Transit");
            var renaultKangoo = new Van(make: "Renault", model: "Kangoo");

            fiatDoblo.Print();
            fordTransit.Print();
            renaultKangoo.Print();
        }
    }
}