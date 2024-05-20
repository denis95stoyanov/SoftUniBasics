string aName = Console.ReadLine();
int projects = int.Parse(Console.ReadLine());
int hourForProject = 3 * projects;
Console.WriteLine($"The architect {aName} will need {hourForProject} hours to complete {projects} project/s.");