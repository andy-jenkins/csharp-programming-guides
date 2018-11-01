namespace ProgrammingGuides.StaticMembers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fordFiesta = new Car(make: "Ford", model: "Fiesta");
            var miniCooper = new Car(make: "Mini", model: "Cooper");
            var seatIbiza = new Car(make: "Seat", model: "Ibiza");

            fordFiesta.Print();
            miniCooper.Print();
            seatIbiza.Print();
        }
    }
}