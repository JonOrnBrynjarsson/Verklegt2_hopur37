namespace Mooshak20.Models.Entities
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Model1 : DbContext
	{
		public Model1()
			: base("name=Model1")
		{
		}

		public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
		public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
		public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
		public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
		public virtual DbSet<Assignment> Assignments { get; set; }
		public virtual DbSet<Cours> Courses { get; set; }
		public virtual DbSet<ErrorReport> ErrorReports { get; set; }
		public virtual DbSet<GroupMember> GroupMembers { get; set; }
		public virtual DbSet<Message> Messages { get; set; }
		public virtual DbSet<Milestone> Milestones { get; set; }
		public virtual DbSet<Submission> Submissions { get; set; }
		public virtual DbSet<TestCas> TestCases { get; set; }
		public virtual DbSet<Testrun> Testruns { get; set; }
		public virtual DbSet<UserCourseRelation> UserCourseRelations { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AspNetRole>()
				.HasMany(e => e.UserCourseRelations)
				.WithRequired(e => e.AspNetRole)
				.HasForeignKey(e => e.RoleID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<AspNetRole>()
				.HasMany(e => e.AspNetUsers)
				.WithMany(e => e.AspNetRoles)
				.Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

			modelBuilder.Entity<AspNetUser>()
				.HasMany(e => e.AspNetUserClaims)
				.WithRequired(e => e.AspNetUser)
				.HasForeignKey(e => e.UserId);

			modelBuilder.Entity<AspNetUser>()
				.HasMany(e => e.AspNetUserLogins)
				.WithRequired(e => e.AspNetUser)
				.HasForeignKey(e => e.UserId);

			modelBuilder.Entity<AspNetUser>()
				.HasMany(e => e.ErrorReports)
				.WithRequired(e => e.AspNetUser)
				.HasForeignKey(e => e.UserID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<AspNetUser>()
				.HasMany(e => e.GroupMembers)
				.WithRequired(e => e.AspNetUser)
				.HasForeignKey(e => e.UserID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<AspNetUser>()
				.HasMany(e => e.UserCourseRelations)
				.WithRequired(e => e.AspNetUser)
				.HasForeignKey(e => e.UserID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Assignment>()
				.HasMany(e => e.GroupMembers)
				.WithRequired(e => e.Assignment)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Assignment>()
				.HasMany(e => e.Milestones)
				.WithRequired(e => e.Assignment)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Cours>()
				.HasMany(e => e.Assignments)
				.WithRequired(e => e.Cours)
				.HasForeignKey(e => e.CourseID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Cours>()
				.HasMany(e => e.ErrorReports)
				.WithOptional(e => e.Cours)
				.HasForeignKey(e => e.CourseID);

			modelBuilder.Entity<Cours>()
				.HasMany(e => e.UserCourseRelations)
				.WithRequired(e => e.Cours)
				.HasForeignKey(e => e.CourseID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Milestone>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<Milestone>()
				.HasMany(e => e.Submissions)
				.WithRequired(e => e.Milestone)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Milestone>()
				.HasMany(e => e.TestCases)
				.WithRequired(e => e.Milestone)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Submission>()
				.HasMany(e => e.Testruns)
				.WithRequired(e => e.Submission)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<TestCas>()
				.HasMany(e => e.Testruns)
				.WithRequired(e => e.TestCas)
				.HasForeignKey(e => e.TestCaseID)
				.WillCascadeOnDelete(false);
		}
	}
}
