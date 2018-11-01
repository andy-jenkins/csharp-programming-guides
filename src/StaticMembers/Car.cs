namespace StaticMembers
{
    public class Car
    {
        public Car(string make, string model)
        {
            _make = make;
            _model = model;
        }

        private static string _make;
        private static string _model;
    }
}