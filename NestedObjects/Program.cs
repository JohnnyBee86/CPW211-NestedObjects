
using NestedObjects;

Advisor computerSciAdvisor = new()
{
	Email = "Annemarie@cptc.edu",
	FullName = "Annemarie Smith",
	OfficeLocation = "B17 Rm 150"
};

Student stu1 = new()
{
	FirstName = "Homer",
	LastName = "Simpson",
	DateOfBirth = new DateOnly(2000, 3, 20),
	AssignedAdvisor = computerSciAdvisor,
	PhoneNumber = "2535895580",
	SchoolEmail = "HSimpson@students.cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName}");
Console.ReadLine();