using System;
using System.Collections.Generic;

public class Course
{
    public string title { get; set; }
    public string length { get; set; }

    public Course(string title_, string length_)
    {
        title = title_;
        length = length_;
    }
}

public class Student
{
    public string nume { get; set; }
    public string prenume { get; set; }
    public List<Course> Courses { get; set; }

    public Student(string nume_, string prenume_)
    {
        nume = nume_;
        prenume = prenume_;
        Courses = new List<Course>();
    }

    public void AddCourse(string title_, string length_)
    {
        Courses.Add(new Course(title_, length_));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new("RussianGuy", "Boris");
        student1.AddCourse("Math", "2 hours");
        student1.AddCourse("Sports", "6 hours");

        Student student2 = new("Brabete", "Marius");
        student2.AddCourse(".NET", "2 hours");
        student2.AddCourse("Math again", "3 hours");

        List<Student> students = new() { student1, student2 };

        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.nume}, Prenume: {student.prenume}");
            Console.WriteLine("Courses:");
            foreach (var course in student.Courses)
            {
                Console.WriteLine($"- {course.title}, Length: {course.length}");
            }
            Console.WriteLine();
        }
    }
}