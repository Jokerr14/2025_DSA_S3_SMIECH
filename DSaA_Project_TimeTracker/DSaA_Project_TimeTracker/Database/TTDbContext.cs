using System.Configuration;
using DSaA_Project_TimeTracker.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database;

public class TTDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<TeamProject> TeamProjects { get; set; }
    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<TaskProgram> Tasks { get; set; }
    public DbSet<UserHistory> UserHistory { get; set; }
    public DbSet<TaskAssignment> TaskAssignments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TeamMember>()
            .HasKey(tm => new { tm.TeamId, tm.UserId });

        modelBuilder.Entity<TeamMember>()
            .HasOne(tm => tm.Team)
            .WithMany(t => t.TeamMembers)
            .HasForeignKey(tm => tm.TeamId);

        modelBuilder.Entity<TeamMember>()
            .HasOne(tm => tm.User)
            .WithMany(u => u.TeamMembers)
            .HasForeignKey(tm => tm.UserId);

        modelBuilder.Entity<TeamProject>()
        .HasKey(tp => new { tp.TeamId, tp.ProjectId });

        modelBuilder.Entity<TeamProject>()
            .HasOne(tp => tp.Team)
            .WithMany(t => t.TeamProjects)
            .HasForeignKey(tp => tp.TeamId);

        modelBuilder.Entity<TeamProject>()
            .HasOne(tp => tp.Project)
            .WithMany(p => p.TeamProjects)
            .HasForeignKey(tp => tp.ProjectId);

        modelBuilder.Entity<UserHistory>()
            .HasOne(uh => uh.User)
            .WithMany(u => u.UserHistories)
            .HasForeignKey(uh => uh.UserId);

        modelBuilder.Entity<TaskAssignment>()
            .HasKey(ta => new { ta.TaskId, ta.UserId });

        modelBuilder.Entity<TaskAssignment>()
            .HasOne(ta => ta.TaskProgram)
            .WithMany(tp => tp.TaskAssignments)  
            .HasForeignKey(ta => ta.TaskId);

        modelBuilder.Entity<TaskAssignment>()
            .HasOne(ta => ta.User)
            .WithMany(u => u.TaskAssignments)
            .HasForeignKey(ta => ta.UserId);

        modelBuilder.Entity<TaskProgram>()
        .HasKey(tp => tp.Id);

        modelBuilder.Entity<TaskProgram>()
            .HasOne(tp => tp.Project)
            .WithMany(p => p.TaskPrograms)
            .HasForeignKey(tp => tp.ProjectId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = ConfigurationManager.ConnectionStrings["TTDB"].ConnectionString;
        optionsBuilder.UseSqlServer(connectionString);
    }
}
