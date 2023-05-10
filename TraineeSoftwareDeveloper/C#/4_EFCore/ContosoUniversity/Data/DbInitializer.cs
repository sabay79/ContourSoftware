using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class DbInitializer
    {
        public static void Initialize(ContosoUniversityContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;
                // DB has been seeded
            }

            var students = new Student[]
            {
                new Student { Name = "Carson Alexander", EnrollmentDate = DateTime.Parse("2019-09-01") },
                new Student { Name = "Meredith Alonso", EnrollmentDate = DateTime.Parse("2017-09-01") },
                new Student { Name = "Arturo Anand", EnrollmentDate = DateTime.Parse("2018-09-01") },
                new Student { Name = "Gytis Barzdukas", EnrollmentDate = DateTime.Parse("2017-09-01") },
                new Student { Name = "Yan Li", EnrollmentDate = DateTime.Parse("2017-09-01") },
                new Student { Name = "Peggy Justice", EnrollmentDate = DateTime.Parse("2016-09-01") },
                new Student { Name = "Laura Norman", EnrollmentDate = DateTime.Parse("2018-09-01") },
                new Student { Name = "Nino Olivetto", EnrollmentDate = DateTime.Parse("2019-09-01") }
            };
            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course { CourseID = 1050, Title = "Programming Fundamentals", Credits = 3 },
                new Course { CourseID = 4022, Title = "Object Oriented Programming", Credits = 3 },
                new Course { CourseID = 4041, Title = "Data Structures & Algorithm", Credits = 3 },
                new Course { CourseID = 1045, Title = "Database", Credits = 4 },
                new Course { CourseID = 3141, Title = "Data Science", Credits = 4 },
                new Course { CourseID = 2021, Title = "Intro. to Computing", Credits = 3 },
                new Course { CourseID = 2042, Title = "Visual Programming", Credits = 4 }
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment { StudentID = 1, CourseID = 1050, Grade = Grade.A },
                new Enrollment { StudentID = 1, CourseID = 4022, Grade = Grade.C },
                new Enrollment { StudentID = 1, CourseID = 4041, Grade = Grade.B },
                new Enrollment { StudentID = 2, CourseID = 1045, Grade = Grade.B },
                new Enrollment { StudentID = 2, CourseID = 3141, Grade = Grade.F },
                new Enrollment { StudentID = 2, CourseID = 2021, Grade = Grade.F },
                new Enrollment { StudentID = 3, CourseID = 1050 },
                new Enrollment { StudentID = 4, CourseID = 1050 },
                new Enrollment { StudentID = 4, CourseID = 4022, Grade = Grade.F },
                new Enrollment { StudentID = 5, CourseID = 4041, Grade = Grade.C },
                new Enrollment { StudentID = 6, CourseID = 1045 },
                new Enrollment { StudentID = 7, CourseID = 3141, Grade = Grade.A },
            };
            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
