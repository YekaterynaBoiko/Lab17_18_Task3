namespace Lab17_18_Task3
{
    enum Status
    {
        Regular,
        Silver,
        Gold
    }
    internal class Program
    {
        public class Abonement
        {
            public static double price = 2000;
            public int month;
            public Status status;

            public Abonement(int month, Status status)
            {
                if (month > 12 || month <= 0)
                this.month = 1;
                
                else this.month = month;
                this.status = status;   
            }

            //public Abonement(Status status)
            //{
            //    this.status = status;
            //}
            public void Discount()
            {
                if (month >= 6) price *= 0.8;
                if (month >= 3) price *= 0.9;
            }

            public void DiscountStatus()
            {
                if (status == Status.Silver) price *= 0.9;
                else if (status == Status.Gold) price *= 0.75;
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

            Abonement abonement = new Abonement(4, Status.Gold);
            abonement.Discount();
            abonement.DiscountStatus();
            Client client = new Client("Alex", abonement);
            Console.WriteLine(client);
        }
    }
}
