using System.Reflection.Emit;

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



            #region Question 2: Fluent API Configurations
            //            using Microsoft.EntityFrameworkCore;
            //            using Microsoft.EntityFrameworkCore.Metadata.Builders;

            //public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
            //        {
            //            public void Configure(EntityTypeBuilder<Instructor> builder)
            //            {
            //                builder.HasKey(i => i.Id);
            //                builder.Property(i => i.FullName).IsRequired().HasMaxLength(100);
            //                builder.Property(i => i.Email).IsRequired().HasMaxLength(150);
            //                builder.Property(i => i.Bio).HasMaxLength(500);
            //                builder.Property(i => i.JoinedDate).IsRequired();
            //            }
            //        }

            //        public class CategoryConfiguration : IEntityTypeConfiguration<Category>
            //        {
            //            public void Configure(EntityTypeBuilder<Category> builder)
            //            {
            //                builder.HasKey(c => c.Id);
            //                builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            //                builder.Property(c => c.Description).HasMaxLength(300);


            //                builder.HasOne(c => c.Parent)
            //                       .WithMany(c => c.SubCategories)
            //                       .HasForeignKey(c => c.ParentId)
            //                       .OnDelete(DeleteBehavior.Restrict);
            //            }
            //        }

            //        public class CourseConfiguration : IEntityTypeConfiguration<Course>
            //        {
            //            public void Configure(EntityTypeBuilder<Course> builder)
            //            {
            //                builder.HasKey(c => c.Id);
            //                builder.Property(c => c.Title).IsRequired().HasMaxLength(150);
            //                builder.Property(c => c.Description).HasMaxLength(1000);
            //                builder.Property(c => c.Price).HasColumnType("decimal(18,2)").IsRequired();
            //                builder.Property(c => c.Level).IsRequired();
            //                builder.Property(c => c.IsPublished).IsRequired();

            //                builder.HasOne(c => c.Instructor)
            //                       .WithMany(i => i.Courses)
            //                       .HasForeignKey(c => c.InstructorId)
            //                       .OnDelete(DeleteBehavior.Cascade);

            //                builder.HasOne(c => c.Category)
            //                       .WithMany(cat => cat.Courses)
            //                       .HasForeignKey(c => c.CategoryId)
            //                       .OnDelete(DeleteBehavior.Restrict);
            //            }
            //        }

            //        public class StudentConfiguration : IEntityTypeConfiguration<Student>
            //        {
            //            public void Configure(EntityTypeBuilder<Student> builder)
            //            {
            //                builder.HasKey(s => s.Id);
            //                builder.Property(s => s.FullName).IsRequired().HasMaxLength(100);
            //                builder.Property(s => s.Email).IsRequired().HasMaxLength(150);
            //                builder.Property(s => s.DateOfBirth).IsRequired();
            //            }
            //        }

            //        public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
            //        {
            //            public void Configure(EntityTypeBuilder<Enrollment> builder)
            //            {

            //                builder.HasKey(e => new { e.StudentId, e.CourseId });

            //                builder.Property(e => e.EnrollmentDate).IsRequired();
            //                builder.Property(e => e.ProgressPercentage).IsRequired();
            //                builder.Property(e => e.Status).IsRequired();
            //                builder.Property(e => e.FinalGrade).HasColumnType("decimal(5,2)");

            //                builder.HasOne(e => e.Student)
            //                       .WithMany(s => s.Enrollments)
            //                       .HasForeignKey(e => e.StudentId)
            //                       .OnDelete(DeleteBehavior.Cascade);

            //                builder.HasOne(e => e.Course)
            //                       .WithMany(c => c.Enrollments)
            //                       .HasForeignKey(e => e.CourseId)
            //                       .OnDelete(DeleteBehavior.Cascade);
            //            }
            //        }
            #endregion


            #region Question 3: DbContext Setup
            //            using Microsoft.EntityFrameworkCore;

            //public class LearningPlatformDbContext : DbContext
            //        {
            //            public DbSet<Instructor> Instructors { get; set; }
            //            public DbSet<Category> Categories { get; set; }
            //            public DbSet<Course> Courses { get; set; }
            //            public DbSet<Student> Students { get; set; }
            //            public DbSet<Enrollment> Enrollments { get; set; }

            //            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //            {

            //                optionsBuilder.UseSqlServer("Server=.;Database=OnlineLearningPlatformDb;Trusted_Connection=True;TrustServerCertificate=True;");
            //            }

            //            protected override void OnModelCreating(ModelBuilder modelBuilder)
            //            {
            //                base.OnModelCreating(modelBuilder);


            //                modelBuilder.ApplyConfigurationsFromAssembly(typeof(LearningPlatformDbContext).Assembly);
            //            }
            //        }
            #endregion



            #region Question 4: Data Seeding via HasData
            
//public class CategoryConfiguration : IEntityTypeConfiguration<Category>
//        {
//            public void Configure(EntityTypeBuilder<Category> builder)
//            {
               

//                builder.HasData(
//                    new Category { Id = 1, Name = "Programming", Description = "Software development courses", ParentId = null },
//                    new Category { Id = 2, Name = "Backend", Description = "Server-side development", ParentId = 1 },
//                    new Category { Id = 3, Name = "ASP.NET", Description = "ASP.NET Core web framework", ParentId = 2 },
//                    new Category { Id = 4, Name = "Frontend", Description = "Client-side development", ParentId = 1 },
//                    new Category { Id = 5, Name = "Database", Description = "Database design and SQL", ParentId = null }
//                );
//            }
//        }

        
//        public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
//        {
//            public void Configure(EntityTypeBuilder<Instructor> builder)
//            {
                

//                builder.HasData(
//                    new Instructor { Id = 1, FullName = "Ahmed Ali", Email = "ahmed.ali@platform.com", Bio = "Senior .NET Developer", JoinedDate = new DateTime(2023, 1, 10) },
//                    new Instructor { Id = 2, FullName = "Mona Hassan", Email = "mona.hassan@platform.com", Bio = "Database Expert", JoinedDate = new DateTime(2023, 3, 15) },
//                    new Instructor { Id = 3, FullName = "Khaled Omar", Email = "khaled.omar@platform.com", Bio = "Full Stack Engineer", JoinedDate = new DateTime(2023, 5, 20) }
//                );
//            }
//        }

        
//        public class CourseConfiguration : IEntityTypeConfiguration<Course>
//        {
//            public void Configure(EntityTypeBuilder<Course> builder)
//            {
                
//                builder.HasData(
//                    new Course { Id = 1, Title = "C# Basics", Description = "Introduction to C#", Price = 100.00m, Level = CourseLevel.Beginner, IsPublished = true, PublishedDate = new DateTime(2023, 2, 1), InstructorId = 1, CategoryId = 1 },
//                    new Course { Id = 2, Title = "Advanced ASP.NET Core", Description = "Build Web APIs", Price = 250.00m, Level = CourseLevel.Advanced, IsPublished = true, PublishedDate = new DateTime(2023, 4, 1), InstructorId = 1, CategoryId = 3 },
//                    new Course { Id = 3, Title = "SQL Server Masterclass", Description = "T-SQL and Tuning", Price = 150.00m, Level = CourseLevel.Intermediate, IsPublished = true, PublishedDate = new DateTime(2023, 6, 1), InstructorId = 2, CategoryId = 5 },
//                    new Course { Id = 4, Title = "React for Beginners", Description = "Frontend UI library", Price = 120.00m, Level = CourseLevel.Beginner, IsPublished = false, PublishedDate = null, InstructorId = 3, CategoryId = 4 },
//                    new Course { Id = 5, Title = "Entity Framework Core", Description = "ORM in depth", Price = 200.00m, Level = CourseLevel.Intermediate, IsPublished = true, PublishedDate = new DateTime(2023, 7, 1), InstructorId = 1, CategoryId = 2 },
//                    new Course { Id = 6, Title = "System Architecture", Description = "Design patterns", Price = 300.00m, Level = CourseLevel.Advanced, IsPublished = false, PublishedDate = null, InstructorId = 3, CategoryId = 1 }
//                );
//            }
        }
            #endregion


        #region Question 5: Program.cs Seeding and Execution
        //using System;
        //using System.Linq;
        //using Microsoft.EntityFrameworkCore;

        //class Program
        //    {
        //        static void Main(string[] args)
        //        {
        //            using var context = new LearningPlatformDbContext();


        //            context.Database.EnsureCreated();


        //            if (!context.Students.Any())
        //            {
        //                var students = new[]
        //                {
        //                new Student { FullName = "Youssef Mohamed", Email = "youssef@gmail.com", DateOfBirth = new DateTime(2002, 5, 12) },
        //                new Student { FullName = "Fatma Zohra", Email = "fatma@gmail.com", DateOfBirth = new DateTime(2001, 8, 20) },
        //                new Student { FullName = "Ibrahim Khaled", Email = "ibrahim@gmail.com", DateOfBirth = new DateTime(2003, 1, 15) },
        //                new Student { FullName = "Salma Tarek", Email = "salma@gmail.com", DateOfBirth = new DateTime(2000, 11, 5) },
        //                new Student { FullName = "Mahmoud Said", Email = "mahmoud@gmail.com", DateOfBirth = new DateTime(2002, 3, 30) }
        //            };

        //                context.Students.AddRange(students);
        //                context.SaveChanges();
        //                Console.WriteLine("Students seeded successfully.");
        //            }

        //            if (!context.Enrollments.Any())
        //            {
        //                var enrollments = new[]
        //                {
        //                new Enrollment { StudentId = 1, CourseId = 1, EnrollmentDate = DateTime.Now.AddDays(-10), ProgressPercentage = 100, Status = EnrollmentStatus.Completed, FinalGrade = 95.00m },
        //                new Enrollment { StudentId = 1, CourseId = 2, EnrollmentDate = DateTime.Now.AddDays(-5), ProgressPercentage = 40, Status = EnrollmentStatus.Active, FinalGrade = null },
        //                new Enrollment { StudentId = 2, CourseId = 1, EnrollmentDate = DateTime.Now.AddDays(-8), ProgressPercentage = 100, Status = EnrollmentStatus.Completed, FinalGrade = 88.50m },
        //                new Enrollment { StudentId = 2, CourseId = 3, EnrollmentDate = DateTime.Now.AddDays(-3), ProgressPercentage = 10, Status = EnrollmentStatus.Active, FinalGrade = null },
        //                new Enrollment { StudentId = 3, CourseId = 3, EnrollmentDate = DateTime.Now.AddDays(-15), ProgressPercentage = 100, Status = EnrollmentStatus.Completed, FinalGrade = 92.00m },
        //                new Enrollment { StudentId = 3, CourseId = 5, EnrollmentDate = DateTime.Now.AddDays(-2), ProgressPercentage = 0, Status = EnrollmentStatus.Dropped, FinalGrade = null },
        //                new Enrollment { StudentId = 4, CourseId = 2, EnrollmentDate = DateTime.Now.AddDays(-6), ProgressPercentage = 60, Status = EnrollmentStatus.Active, FinalGrade = null },
        //                new Enrollment { StudentId = 5, CourseId = 5, EnrollmentDate = DateTime.Now.AddDays(-12), ProgressPercentage = 100, Status = EnrollmentStatus.Completed, FinalGrade = 90.00m }
        //            };

        //                context.Enrollments.AddRange(enrollments);
        //                context.SaveChanges();
        //                Console.WriteLine("Enrollments seeded successfully covering all three statuses.");
        //            }
        //        }
        //    }
        #endregion

        #region Operation: Add Instructor
        //public static void AddInstructor(LearningPlatformDbContext context, string fullName, string email, string? bio)
        //{
        //    var instructor = new Instructor
        //    {
        //        FullName = fullName,
        //        Email = email,
        //        Bio = bio,
        //        JoinedDate = DateTime.Now
        //    };

        //    context.Instructors.Add(instructor);
        //    context.SaveChanges();

        //    Console.WriteLine($"Instructor added successfully with Id: {instructor.Id}");
        //}
        #endregion



        #region Operation: Add Course
        //public static void AddCourse(LearningPlatformDbContext context, string title, string? description, decimal price, CourseLevel level, bool isPublished, int instructorId, int categoryId)
        //{

        //    var instructorExists = context.Instructors.Any(i => i.Id == instructorId);
        //    var categoryExists = context.Categories.Any(c => c.Id == categoryId);

        //    if (!instructorExists)
        //    {
        //        Console.WriteLine($"Error: Instructor with Id {instructorId} does not exist.");
        //        return;
        //    }

        //    if (!categoryExists)
        //    {
        //        Console.WriteLine($"Error: Category with Id {categoryId} does not exist.");
        //        return;
        //    }

        //    var course = new Course
        //    {
        //        Title = title,
        //        Description = description,
        //        Price = price,
        //        Level = level,
        //        IsPublished = isPublished,
        //        PublishedDate = isPublished ? DateTime.Now : null,
        //        InstructorId = instructorId,
        //        CategoryId = categoryId
        //    };

        //    context.Courses.Add(course);
        //    context.SaveChanges();

        //    Console.WriteLine($"Course added successfully with Id: {course.Id}");
        //}
        #endregion

        #region Operation: Add Several Students
        //    public static void AddStudents(LearningPlatformDbContext context)
        //    {
        //        var students = new List<Student>
        //{
        //    new Student { FullName = "Karim Nabil", Email = "karim@gmail.com", DateOfBirth = new DateTime(2001, 4, 10) },
        //    new Student { FullName = "Nourhan Adel", Email = "nourhan@gmail.com", DateOfBirth = new DateTime(2002, 9, 25) },
        //    new Student { FullName = "Ziad Ahmed", Email = "ziad@gmail.com", DateOfBirth = new DateTime(2003, 12, 1) }
        //};

        //        context.Students.AddRange(students);
        //        context.SaveChanges();

        //        Console.WriteLine("Students added successfully with the following IDs:");
        //        foreach (var student in students)
        //        {
        //            Console.WriteLine($"- Student: {student.FullName}, Id: {student.Id}");
        //        }
        //    }
        #endregion


        #region Operation: Enroll a Student
        //public static void EnrollStudent(LearningPlatformDbContext context, int studentId, int courseId)
        //{
            
        //    var studentExists = context.Students.Any(s => s.Id == studentId);
        //    if (!studentExists)
        //    {
        //        Console.WriteLine($"Enrollment refused: Student with Id {studentId} does not exist.");
        //        return;
        //    }

            
        //    var course = context.Courses.FirstOrDefault(c => c.Id == courseId);
        //    if (course == null)
        //    {
        //        Console.WriteLine($"Enrollment refused: Course with Id {courseId} does not exist.");
        //        return;
        //    }

        //    if (!course.IsPublished)
        //    {
        //        Console.WriteLine($"Enrollment refused: Course '{course.Title}' is not published yet and cannot accept enrollments.");
        //        return;
        //    }

            
        //    var alreadyEnrolled = context.Enrollments.Any(e => e.StudentId == studentId && e.CourseId == courseId);
        //    if (alreadyEnrolled)
        //    {
        //        Console.WriteLine($"Enrollment refused: Student with Id {studentId} is already enrolled in this course.");
        //        return;
        //    }

            
        //    var enrollment = new Enrollment
        //    {
        //        StudentId = studentId,
        //        CourseId = courseId,
        //        EnrollmentDate = DateTime.Now,
        //        ProgressPercentage = 0,
        //        Status = EnrollmentStatus.Active,
        //        FinalGrade = null
        //    };

        //    context.Enrollments.Add(enrollment);
        //    context.SaveChanges();

        //    Console.WriteLine($"Student {studentId} successfully enrolled in course '{course.Title}'!");
        //}
        #endregion

    }
}
}
