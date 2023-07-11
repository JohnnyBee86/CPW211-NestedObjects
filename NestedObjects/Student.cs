﻿
namespace NestedObjects
{
	/// <summary>
	/// Represents a individual college student
	/// </summary>
	public class Student
	{
		/// <summary>
		/// The legal first name
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// The legal last name
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// The assigned school email address
		/// </summary>
		public string SchoolEmail { get; set; }

		/// <summary>
		/// Phone number
		/// </summary>
		public string PhoneNumber { get; set; }

		/// <summary>
		/// The student's advisor
		/// </summary>
		public Advisor AssignedAdvisor { get; set; }
	}
}
