List<TeamMember> members = new List<TeamMember>();

Console.WriteLine("Plan Your Heist!");

Console.WriteLine("enter a team member's name and save that name");

string memberName = Console.ReadLine()!;

while (!string.IsNullOrEmpty(memberName)){

Console.WriteLine("enter a team member's skill level and save that skill level with the name");

int skillLevel = int.Parse(Console.ReadLine()!);

Console.WriteLine("enter a team member's courage factor, a decimal between 0.0 and 2.0, and save that courage factor with the name");

decimal courageFactor = decimal.Parse(Console.ReadLine()!);

TeamMember teamMember = new TeamMember()
{
    Name = memberName,
    SkillLevel = skillLevel,
    CourageFactor = courageFactor
};

members.Add(teamMember);

Console.WriteLine("enter a team member's name and save that name or press enter to quit");

memberName = Console.ReadLine()!;
}

Console.WriteLine("Crew Members:");

foreach (TeamMember member in members){
    Console.WriteLine($"Name: {member.Name} Skill Level: {member.SkillLevel} Courage Factor: {member.CourageFactor}");
}

 int bankDifficulty = 100;

 int totalSkill= 0;

    foreach (TeamMember member in members){
    totalSkill += member.SkillLevel; 
    }

Random random = new Random();

int luck = random.Next(-10,11);


int randomDifficulty = bankDifficulty + luck;

Console.WriteLine($"the team's combined skill level is:  {totalSkill}");

Console.WriteLine($"the bank's difficulty level is:  {randomDifficulty}");

if (totalSkill >= randomDifficulty)
{
    Console.WriteLine("You Succeed!");
}

else
{
    Console.WriteLine("You Fail!");
}