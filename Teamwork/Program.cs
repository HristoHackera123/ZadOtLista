namespace Teamwork
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Name of team: ");
            string name = Console.ReadLine();
            Team team = new Team(name);
            string answer = "";
            do
            {
                Console.Write("Name of player: ");
                name = Console.ReadLine();
                Console.Write("Age of player: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Add player to team? ");
                answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    Person player = new Person(name, age);
                    team.AddPlayer(player);
                }

                Console.Write("Any more players? ");
                answer = Console.ReadLine();
            } while (answer != "no");
            Console.WriteLine($"Team: {team.Name}\n" +
                $"First team: {string.Join(", ", team.FirstTeam.Select(person => person.Name))}\n" +
                $"Reserve team: {string.Join(" ", team.ReserveTeam.Select(person => person.Name))}");
        }
    }
}
