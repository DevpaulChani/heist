List<TeamMember> members = new List<TeamMember>();

Console.WriteLine("Plan Your Heist!");

Console.WriteLine("Enter a bank difficulty level");

int bankDifficulty = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter a team member's name and save that name");

string memberName = Console.ReadLine()!;

while (!string.IsNullOrEmpty(memberName))
{
    int skillLevel = 0;

    while (skillLevel == 0)
    {
        Console.WriteLine("Enter a team member's skill level and save that skill level with the name");
        try
        {
            skillLevel = int.Parse(Console.ReadLine()!);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please only enter a number");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("There was an error. Please try again.");
        }
    }
    decimal courageFactor = 0.0M;

    while (courageFactor == 0.0M)
    {
        Console.WriteLine("Enter a team member's courage factor, a decimal between 0.0 and 2.0, and save that courage factor with the name");
        try
        {
            courageFactor = decimal.Parse(Console.ReadLine()!);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please only enter a decimal between 0.0 and 2.0");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("There was an error. Please try again.");
        }
    }

    TeamMember teamMember = new TeamMember()
    {
        Name = memberName,
        SkillLevel = skillLevel,
        CourageFactor = courageFactor
    };

    members.Add(teamMember);

    Console.WriteLine("Enter a team member's name and save that name or press enter to quit");

    memberName = Console.ReadLine()!.Trim();
}

Console.WriteLine("Crew Members:");

foreach (TeamMember member in members)
{
    Console.WriteLine($"Name: {member.Name} Skill Level: {member.SkillLevel} Courage Factor: {member.CourageFactor}");
}

List<TeamMember> heistMembers = new List<TeamMember>();

foreach (TeamMember member in members)
{
    if ((decimal)member.SkillLevel * member.CourageFactor > bankDifficulty)
    {
        heistMembers.Add(member);
    }
    else
    {
        Console.WriteLine($"{member.Name} has chickened out!");
    }
}

int totalSkill = 0;

foreach (TeamMember member in heistMembers)
{
    totalSkill += member.SkillLevel;
}

Console.WriteLine($"The team's combined skill level is:  {totalSkill}");

Console.WriteLine("Enter the number of trial runs");

int runs = int.Parse(Console.ReadLine()!);

Random random = new Random();

int successes = 0;
int failures = 0;

for (int i = 1; i <= runs; i++)
{
    int luck = random.Next(-10, 11);

    int randomDifficulty = bankDifficulty + luck;

    Console.WriteLine($"The bank's difficulty level is:  {randomDifficulty}");

    if (totalSkill >= randomDifficulty)
    {
        Console.WriteLine("You Succeed!");
        successes += 1;
    }

    else
    {
        Console.WriteLine("You Fail!");
        failures += 1;
    }
}

Console.WriteLine($"You succeeded {successes} times and failed {failures} times.");