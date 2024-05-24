namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input reads text (architecture's name) and integer number (count of projects for creation)
            string name = Console.ReadLine();
            int countProjects = int.Parse(Console.ReadLine());

            // Calculate how many hours will be needed for projects creation, if you know: one project creation takes 3 hours
            int hoursProjCreation = countProjects * 3;

            // Output the data
            Console.WriteLine($"The architect {name} will need {hoursProjCreation} hours to complete {countProjects} project/s.");
        }
    }
}
