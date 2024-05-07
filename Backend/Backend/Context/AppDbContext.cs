using Backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Answers> Answers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillStatus> BillStatuses  { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<CertificateType> CertificateTypes { get; set; }
        public DbSet<CommentBlog> CommentBlogs { get; set; }
        public DbSet<ConfirmEmail> ConfirmEmails { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseSubject> CourseSubjects { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<DoHomework> DoHomeworks { get; set; }
        public DbSet<LearningProgress> LearningProgresses { get; set; }
        public DbSet<LikeBlog> LikeBlogs { get; set; }
        public DbSet<MakeQuestion> MakeQuestions { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Practice> Practices { get; set; }
        public DbSet<ProgramingLanguage> ProgramingLanguages { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<RegisterStudy> RegisterStudies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RunTestCase> RunTestCases { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectDetail> SubjectDetails { get; set; }
        public DbSet<TestCase> TestCases { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ward> Wards { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=WARMACHINE\\SQLEXPRESS; database=Intern-project; integrated security=sspi; Encrypt=True; TrustServerCertificate=True");
        }
    }
}
