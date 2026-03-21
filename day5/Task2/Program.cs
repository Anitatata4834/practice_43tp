namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coach c1 = new Coach("Анна A.A.");
            Coach c2 = new Coach("Екатерина К.К.");
            Coach c3 = new Coach("Вероника В.В.");
            Team t1 = new Team("Волки");
            Team t2 = new Team("Кокосы");
            Coach[] coachesForMaria = { c1, c2 };
            Coach[] coachesForRoman = { c2 };
            Coach[] coachesForNina = { c1, c3 };
            Athlete a1 = new Athlete("Мария", coachesForMaria, t1);
            Athlete a2 = new Athlete("Роман", coachesForRoman, t2);
            Athlete a3 = new Athlete("Нина", coachesForNina, t1);
            Athlete[] athletes = { a1, a2, a3 };
            foreach (var athlete in athletes)
            {
                athlete.Train();
            }
        }
    }
}
