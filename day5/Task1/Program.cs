namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LearningMode[] modes =
             {
                new Online(),
                new Offline(),
                new Hybrid()
            };

            LearningLogic logic = new LearningLogic();
            logic.Process(modes);
        }
    }
}
