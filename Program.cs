namespace Lab17_18_Task3
{
    internal class Program
    {
        public class Abonement
        {
            public static double price = 2000;
            public int month;

            public Abonement(int month)
            {
                if (month > 12 || month <= 0)
                this.month = 1;
                
                else this.month = month;
            }
            public void Discount()
            {
                if (month >= 6) price *= 0.8;
                if (month >= 3) price *= 0.9;
            }
        }

        public class Client
        {
            public Abonement Abonement;
            public string Name;
            public Client(string Name, Abonement abonement)
            {
                this.Name = Name;
                this.Abonement = abonement;
            }
        }
        static void Main(string[] args)
        {

            Abonement abonement = new Abonement(4);
            abonement.Discount();
            Client client = new Client("Alex", abonement);
            Console.WriteLine(client);
        }
    }
}
