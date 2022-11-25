using Karartek.DataAccess.Concrete.EntityFramework.Context.Seed;
using Karartek.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Karartek.DataAccess.Concrete.EntityFramework.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Judgment> Judgments { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<JudgmentType> JudgmentTypes { get; set; }
        public DbSet<JudgmentPool> JudgmentPools { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<LawyerJudgment> LawyerJudgments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<SearchType> SearchTypes { get; set; }
        public DbSet<LawyerJudgmentState> LawyerJudgmentStates { get; set; }
        public DbSet<Commission> Commissions { get; set; }
        public DbSet<Court> Courts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\KararTek;Encrypt=false;TrustServerCertificate=False;Integrated Security=true");
            optionsBuilder.UseSqlServer(@"Server=localhost;user=sa;Database=KararTek;Password=irem@123;Encrypt=false;TrustServerCertificate=False");

            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KararTek1;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().Property(x => x.Email).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.FirstName).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.LastName).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.IdentityNumber).HasMaxLength(11).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.PhoneNumber).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.PasswordHash).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.PasswordSalt).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            modelBuilder.Entity<User>().HasOne<UserType>(x => x.UserType).WithMany(x => x.Users).IsRequired().HasForeignKey(x => x.UserTypeId);
            modelBuilder.Entity<User>().HasOne<City>(x => x.City).WithMany(x => x.Users).IsRequired().HasForeignKey(x => x.CityId).OnDelete(DeleteBehavior.NoAction); ;
            modelBuilder.Entity<User>().HasOne<District>(x => x.District).WithMany(x => x.Users).HasForeignKey(x => x.DistrictId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Student>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Student>().Property(x => x.University).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Student>().Property(x => x.Faculty).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Student>().Property(x => x.Grade).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Student>().Property(x => x.StudentNumber).HasMaxLength(11).IsRequired();
            modelBuilder.Entity<Student>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Student>().Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            modelBuilder.Entity<Student>().HasOne<User>(x => x.User).WithOne(x => x.Student).HasForeignKey<Student>(x => x.Id).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Lawyer>().ToTable("Lawyers");
            modelBuilder.Entity<Lawyer>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Lawyer>().Property(x => x.BarRegisterNo).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Lawyer>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Lawyer>().Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            modelBuilder.Entity<Lawyer>().HasOne<User>(x => x.User).WithOne(x => x.Lawyer).HasForeignKey<Lawyer>(x => x.Id).OnDelete(DeleteBehavior.Cascade);



            modelBuilder.Entity<Judgment>().ToTable("Judgments");
            modelBuilder.Entity<Judgment>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Judgment>().Property(x => x.CommissionId) .IsRequired();
            modelBuilder.Entity<Judgment>().Property(x => x.CourtId).IsRequired();
            modelBuilder.Entity<Judgment>().Property(x => x.Decree).HasMaxLength(9999999).IsRequired();
            modelBuilder.Entity<Judgment>().Property(x => x.DecreeType).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Judgment>().Property(x => x.MeritsYear).IsRequired();
            modelBuilder.Entity<Judgment>().Property(x => x.MeritsNo).IsRequired();
            modelBuilder.Entity<Judgment>().Property(x => x.DecreeYear).IsRequired();
            modelBuilder.Entity<Judgment>().Property(x => x.DecreeNo).IsRequired();
            modelBuilder.Entity<Judgment>().Property(x => x.Decision).IsRequired();
            modelBuilder.Entity<Judgment>().Property(x => x.Likes).IsRequired();
            modelBuilder.Entity<Judgment>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Judgment>().Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            modelBuilder.Entity<Judgment>().HasOne<JudgmentType>(x => x.JudgmentType).WithMany(x => x.Judgments).IsRequired().HasForeignKey(x => x.JudgmentTypeId);
            modelBuilder.Entity<Judgment>().HasOne<Commission>(x => x.Commission).WithMany(x => x.Judgments).IsRequired().HasForeignKey(x => x.CommissionId).OnDelete(DeleteBehavior.NoAction); ;
            modelBuilder.Entity<Judgment>().HasOne<Court>(x => x.Court).WithMany(x => x.Judgments).HasForeignKey(x => x.CourtId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<LawyerJudgment>().ToTable("LawyerJudgments");
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.CommissionId).IsRequired();
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.CourtId).IsRequired();
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.Decree).HasMaxLength(9999999).IsRequired();
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.LawyerAssessment).HasMaxLength(9999999).IsRequired();
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.DecreeType).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.MeritsYear).IsRequired();
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.MeritsNo).IsRequired();
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.DecreeYear).IsRequired();
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.DecreeNo).IsRequired();
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.Decision).IsRequired();
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.TBBComments).HasMaxLength(99999);
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            modelBuilder.Entity<LawyerJudgment>().Property(x => x.Likes).IsRequired();
            modelBuilder.Entity<LawyerJudgment>().HasOne<LawyerJudgmentState>(x => x.LawyerJudgmentState).WithMany(x => x.LawyerJudgments).IsRequired().HasForeignKey(x => x.StateId);
            modelBuilder.Entity<LawyerJudgment>().HasOne<User>(x => x.User).WithMany(x => x.LawyerJudgments).IsRequired().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<LawyerJudgment>().HasOne<Commission>(x => x.Commission).WithMany(x => x.LawyerJudgments).IsRequired().HasForeignKey(x => x.CommissionId).OnDelete(DeleteBehavior.NoAction); ;
            modelBuilder.Entity<LawyerJudgment>().HasOne<Court>(x => x.Court).WithMany(x => x.LawyerJudgments).HasForeignKey(x => x.CourtId).OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<LawyerJudgmentState>().ToTable("LawyerJudgmentState");
            modelBuilder.Entity<LawyerJudgmentState>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<LawyerJudgmentState>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<LawyerJudgmentState>().Property(x => x.StateId).IsRequired();
            modelBuilder.Entity<LawyerJudgmentState>().Property(x => x.StateName).ValueGeneratedNever();
            modelBuilder.Entity<LawyerJudgmentState>().Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            modelBuilder.Entity<LawyerJudgmentState>().HasData(LawyerJudgmentStateSeeds.LawyerJudgmentState);//programcs


            modelBuilder.Entity<UserType>().ToTable("UserTypes");
            modelBuilder.Entity<UserType>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<UserType>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<UserType>().Property(x => x.TypeId).IsRequired();
            modelBuilder.Entity<UserType>().Property(x => x.TypeName).ValueGeneratedNever();
            modelBuilder.Entity<UserType>().Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            modelBuilder.Entity<UserType>().HasData(UserTypeSeeds.userTypes);



            modelBuilder.Entity<SearchType>().ToTable("SearchTypes");
            modelBuilder.Entity<SearchType>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<SearchType>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<SearchType>().Property(x => x.TypeId).IsRequired();
            modelBuilder.Entity<SearchType>().Property(x => x.TypeName).ValueGeneratedNever();
            modelBuilder.Entity<SearchType>().Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            modelBuilder.Entity<SearchType>().HasData(SearchTypeSeeds.searchTypes);

            modelBuilder.Entity<JudgmentType>().ToTable("JudgmentTypes");
            modelBuilder.Entity<JudgmentType>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<JudgmentType>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<JudgmentType>().Property(x => x.TypeId).IsRequired();
            modelBuilder.Entity<JudgmentType>().Property(x => x.TypeName).ValueGeneratedNever();
            modelBuilder.Entity<JudgmentType>().Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            modelBuilder.Entity<JudgmentType>().HasData(JudgmentTypeSeeds.judgmentTypes);



            modelBuilder.Entity<JudgmentPool>().ToTable("JudgmentPool");
            modelBuilder.Entity<JudgmentPool>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<JudgmentPool>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<JudgmentPool>().Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            modelBuilder.Entity<JudgmentPool>().HasOne<Judgment>(x => x.Judgment).WithMany(x => x.JudgmentPools).IsRequired().HasForeignKey(x => x.JudgmentId);
            modelBuilder.Entity<JudgmentPool>().HasOne<User>(x => x.User).WithMany(x => x.JudgmentPools).IsRequired().HasForeignKey(x => x.UserId);
            modelBuilder.Entity<JudgmentPool>().HasOne<SearchType>(x => x.SearchType).WithMany(x => x.JudgmentPools).IsRequired().HasForeignKey(x => x.SearchTypeId);

            modelBuilder.Entity<City>().ToTable("City");
            modelBuilder.Entity<City>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<City>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<City>().Property(x => x.OrderIndex).IsRequired();
            modelBuilder.Entity<City>().Property(x => x.PlateCode).IsRequired();
            modelBuilder.Entity<City>().HasData(CitySeeds.cities);


            modelBuilder.Entity<District>().ToTable("Districts");
            modelBuilder.Entity<District>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<District>().Property(x => x.CityId).IsRequired();
            modelBuilder.Entity<District>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<District>().Property(x => x.OrderIndex).IsRequired();
            modelBuilder.Entity<District>().HasOne<City>(x => x.City).WithMany(x => x.Districts).IsRequired().HasForeignKey(x => x.CityId);
            modelBuilder.Entity<District>().HasData(DistrictSeeds.districts);

            modelBuilder.Entity<Commission>().ToTable("Commissions");
            modelBuilder.Entity<Commission>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Commission>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Commission>().HasData(CommisionSeeds.commissions);//

            modelBuilder.Entity<Court>().ToTable("Courts");
            modelBuilder.Entity<Court>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Court>().Property(x => x.CommissionId).IsRequired();
            modelBuilder.Entity<Court>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Court>().HasOne<Commission>(x => x.Commission).WithMany(x => x.Courts).IsRequired().HasForeignKey(x => x.CommissionId);
            modelBuilder.Entity<Court>().HasData(CourtSeeds.courts);//




        }
    }
}
