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
    }
}
}
