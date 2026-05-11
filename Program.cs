string input;

List<TeamMember> members = new List<TeamMember>();

Console.WriteLine("Plan Your Heist!");

Console.WriteLine("enter a team member's name and save that name");

string memberName = Console.ReadLine()!;

while (!string.IsNullOrEmpty(memberName)){

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

Console.WriteLine("enter a team member's name and save that name or press enter to quit");

memberName = Console.ReadLine()!;
}

Console.WriteLine("Crew Members:");
foreach (TeamMember member in members){
    Console.WriteLine($"Name: {member.Name} SkillLevel: {member.SkillLevel} CourageFactor: {member.CourageFactor}");
}
