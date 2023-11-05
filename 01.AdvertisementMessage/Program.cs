namespace _01.AdvertisementMessage
{
    class Advertisement
    {
        public string[] Phrases { get; set; }
        public string[] Events { get; set; }
        public string[] Authors { get; set; }
        public string[] Cities { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Advertisement advertisement = new Advertisement();

            advertisement.Phrases = new[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };

            advertisement.Events = new[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            advertisement.Authors = new[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            advertisement.Cities = new[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                int randomIndex = random.Next(advertisement.Phrases.Length);
                string phrase = advertisement.Phrases[randomIndex];

                randomIndex = random.Next(advertisement.Events.Length);
                string events = advertisement.Events[randomIndex];

                randomIndex = random.Next(advertisement.Authors.Length);
                string authors = advertisement.Authors[randomIndex];

                randomIndex = random.Next(advertisement.Cities.Length);
                string cities = advertisement.Cities[randomIndex];

                Console.WriteLine($"{phrase} {events} {authors} – {cities}.");
            }
        }
    }
}
