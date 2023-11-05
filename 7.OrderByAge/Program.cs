namespace _7.OrderByAge
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            PersonName = name;
            ID = id;
            PersonAge = age;
        }

        public string PersonName { get; set; }
        public string ID { get; set; }
        public int PersonAge { get; set; }

        public override string ToString()
        {
            return $"{PersonName} with ID: {ID} is {PersonAge} years old.";
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commands = command.Split();

                string personName = commands[0];
                string id = commands[1];
                int age = int.Parse(commands[2]);

                var newPerson = new Person(personName, id, age);

                Person personFoundId = person.FirstOrDefault(p => p.ID == id);

                if (personFoundId != null)
                {
                    personFoundId.PersonAge = age;
                    personFoundId.PersonName = personName;
                }
                else
                {
                    person.Add(newPerson);
                }
            }

            var orderedPersons = person.OrderBy(person => person.PersonAge).ToList();

            foreach (Person p in orderedPersons)
            {
                Console.WriteLine(p);
            }
        }
    }
}
