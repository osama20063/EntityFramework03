namespace Assignment_3_EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Question 1: Entities and Enums
//public enum CourseLevel
//        {
//            Beginner,
//            Intermediate,
//            Advanced
//        }

//        public enum EnrollmentStatus
//        {
//            Active,
//            Completed,
//            Dropped
//        }

//        public class Instructor
//        {
//            public int Id { get; set; }
//            public string FullName { get; set; }
//            public string Email { get; set; }
//            public string? Bio { get; set; }
//            public DateTime JoinedDate { get; set; }

//            public ICollection<Course> Courses { get; set; } = new List<Course>();
//        }

//        public class Category
//        {
//            public int Id { get; set; }
//            public string Name { get; set; }
//            public string? Description { get; set; }

//            public int? ParentId { get; set; }
//            public Category? Parent { get; set; }
//            public ICollection<Category> SubCategories { get; set; } = new List<Category>();

//            public ICollection<Course> Courses { get; set; } = new List<Course>();
//        }

//        public class Course
//        {
//            public int Id { get; set; }
//            public string Title { get; set; }
//            public string? Description { get; set; }
//            public decimal Price { get; set; }
//            public CourseLevel Level { get; set; }
//            public bool IsPublished { get; set; }
//            public DateTime? PublishedDate { get; set; }

//            public int InstructorId { get; set; }
//            public Instructor Instructor { get; set; }

//            public int CategoryId { get; set; }
//            public Category Category { get; set; }

//            public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
//        }

//        public class Student
//        {
//            public int Id { get; set; }
//            public string FullName { get; set; }
//            public string Email { get; set; }
//            public DateTime DateOfBirth { get; set; }

//            public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
//        }

//        public class Enrollment
//        {
//            public int StudentId { get; set; }
//            public Student Student { get; set; }

//            public int CourseId { get; set; }
//            public Course Course { get; set; }

//            public DateTime EnrollmentDate { get; set; }
//            public int ProgressPercentage { get; set; }
//            public EnrollmentStatus Status { get; set; }
//            public decimal? FinalGrade { get; set; }
//        }
            #endregion
    }
}
}
