using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      // Generate a list of students
      var s1 = new Student
      {
        FirstName = "Loc",
        LastName = "Nguyen",
        Gender = "Male",
        DateOfBirth = new DateTime(1997, 1, 10),
        PhoneNumber = 123456789,
        BirthPlace = "Hanoi",
        IsGraduated = true,
        StartDate = new DateTime(2015, 1, 20),
        EndDate = new DateTime(2018, 6, 20)
      };

      var s2 = new Student
      {
        FirstName = "Nam",
        LastName = "Nguyen",
        Gender = "Male",
        DateOfBirth = new DateTime(1998, 1, 10),
        PhoneNumber = 123456789,
        BirthPlace = "Ho Chi Minh",
        IsGraduated = false,
        StartDate = new DateTime(2020, 1, 20),
        EndDate = new DateTime(2022, 6, 20)
      };

      var s3 = new Student
      {
        FirstName = "Hoa",
        LastName = "Tran",
        Gender = "Female",
        DateOfBirth = new DateTime(1999, 1, 10),
        PhoneNumber = 123456789,
        BirthPlace = "Hanoi",
        IsGraduated = true,
        StartDate = new DateTime(2015, 1, 20),
        EndDate = new DateTime(2018, 6, 20)
      };

      var s4 = new Student
      {
        FirstName = "Thanh",
        LastName = "Tran",
        Gender = "Female",
        DateOfBirth = new DateTime(2000, 1, 10),
        PhoneNumber = 123456789,
        BirthPlace = "Hanoi",
        IsGraduated = false,
        StartDate = new DateTime(2020, 1, 20),
        EndDate = new DateTime(2022, 6, 20)
      };

      var students = new List<Student>() { s1, s2, s3, s4 };

      // Requirements
      Console.WriteLine("\n");
      Console.WriteLine("1. Return a list of members who is Male:");
      foreach (var student in students)
      {
        if (student.Gender == "Male")
        {
          Console.WriteLine($"{student.FirstName} is Male.");
        }
      }

      Console.WriteLine("\n");
      Console.WriteLine("2. Return the oldest one (if return more than one record then select first record):");

      Console.WriteLine("\n");
      Console.WriteLine("3. Return a new list that contains FullName only:");
      foreach (var student in students)
      {
        Console.WriteLine($"{student.FirstName} {student.LastName}");
      }

      Console.WriteLine("\n");
      Console.WriteLine("4. Return 3 lists");

      var dateForComparison = (new DateTime(1998, 1, 1)).Year;

      // A solution with switch case but it doesn't appear clearly to me, so I prefer foreach with if statement
      // foreach (var student in students)
      // {
      //   switch (student.DateOfBirth.Year)
      //   {
      //     case var n when (n == dateForComparison):
      //       Console.WriteLine($"{student.FirstName} {student.LastName} were born in 1998.");
      //       break;
      //     case var n when (n > dateForComparison):
      //       Console.WriteLine($"{student.FirstName} {student.LastName} were born after 1998.");
      //       break;
      //     case var n when (n < dateForComparison):
      //       Console.WriteLine($"{student.FirstName} {student.LastName} were born before 1998.");
      //       break;
      //   }
      // }

      Console.WriteLine("- List of students who were born in 1998:");
      foreach (var student in students)
      {
        if (student.DateOfBirth.Year == dateForComparison)
        {
          Console.WriteLine($"{student.FirstName} {student.LastName}");
        }
      }

      Console.WriteLine("- List of students who were born after 1998:");
      foreach (var student in students)
      {
        if (student.DateOfBirth.Year > dateForComparison)
        {
          Console.WriteLine($"{student.FirstName} {student.LastName}");
        }
      }

      Console.WriteLine("- List of students who were born before 1998:");
      foreach (var student in students)
      {
        if (student.DateOfBirth.Year < dateForComparison)
        {
          Console.WriteLine($"{student.FirstName} {student.LastName}");
        }
      }

      Console.WriteLine("\n");
      Console.WriteLine("5. Return the first person who was born in Ha Noi:");
      foreach (var student in students)
      {
        if (student.BirthPlace == "Hanoi")
        {
          Console.WriteLine($"{student.FirstName} was born in Hanoi");
        }
        break;
        // I don't like the solution using while loop, so I choose to solve it with foreach loop.
      }

      Console.WriteLine("\n");
      Console.WriteLine("6. Return list of member who join class before 22/03/2021:");
    }
  }
}
