string input;

List<TeamMember> members = new List<TeamMember>();

Console.WriteLine("Plan Your Heist!");

Console.WriteLine("enter a team member's name and save that name");

string memberName = Console.ReadLine()!;

Console.WriteLine("enter a team member's skill level and save that skill level with the name");

int skillLevel = int.Parse(Console.ReadLine()!);

Console.WriteLine("enter a team member's courage factor and save that courage factor with the name");

decimal courageFactor = decimal.Parse(Console.ReadLine()!);

TeamMember teamMember = new TeamMember()
{
    Name = memberName,
    SkillLevel = skillLevel,
    CourageFactor = courageFactor
};

members.Add(teamMember);

Console.WriteLine($"Name: {teamMember.Name} SkillLevel: {teamMember.SkillLevel} CourageFactor: {teamMember.CourageFactor}");