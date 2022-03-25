

List<string> students = new List<string>();
bool done = false;

do
{
    Console.Write("Enter the students name to add to to roster. enter a 'BLANK' name to complete: ");
    string? name = Console.ReadLine();

    if (name != "")
    {
        students.Add(name);
    }
    else
    {
        done = true;
    }
} while (done != true);

Console.WriteLine($"You have registered {students.Count()} into the class.");