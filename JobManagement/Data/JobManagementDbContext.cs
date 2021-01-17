namespace JobManagement.Data
{
    using System;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Models.Enums;
    using Models.Models;
    using Models.Nomenclatures;
    using Services;

    public class JobManagementDbContext : IdentityDbContext<BaseUser, IdentityRole<Guid>, Guid>
    {
        private readonly IUserResolverService _resolverService;

        public JobManagementDbContext(DbContextOptions<JobManagementDbContext> options, IUserResolverService resolverService)
            : base(options)
        {
            _resolverService = resolverService;
        }

        private void TrackChanges()
        {

            foreach (var entry in this.ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
            {
                if (entry.Entity is IAuditable auditable)
                {
                    if (entry.State == EntityState.Added)
                    {
                        auditable.CreatedOn = auditable.ModifiedOn = DateTime.Now;
                        auditable.CreatedBy = auditable.ModifiedBy = _resolverService.GetUserId();
                    }
                    else
                    {
                        entry.Property("CreatedOn").IsModified = false;
                        entry.Property("CreatedBy").IsModified = false;
                        auditable.ModifiedOn = DateTime.Now;
                        auditable.ModifiedBy = _resolverService.GetUserId();
                    }
                }
            }
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            TrackChanges();
            return await base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            TrackChanges();
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<BaseUser>()
                .HasDiscriminator<UserTypeEnum>(nameof(BaseUser.UserType))
                .HasValue<User>(UserTypeEnum.User)
                .HasValue<BusinessUser>(UserTypeEnum.BusinessUser)
                .HasValue<AdministrationUser>(UserTypeEnum.AdministrationUser);


            builder.Entity<UserNSkill>(entity =>
            {
                entity.HasOne(x => x.User).WithMany(x => x.UserNSkills).OnDelete(DeleteBehavior.Restrict);
                entity.HasKey(a => new { a.UserId, a.NSkillId });
            });
            builder.Entity<UserNHealthStatus>(entity =>
            {
                entity.HasOne(x => x.User).WithMany(x => x.UserNHealthStatuses).OnDelete(DeleteBehavior.Restrict);
                entity.HasKey(a => new { a.UserId, a.NHealthStatusId });
            });
            builder.Entity<UserNCategory>(entity =>
            {
                entity.HasOne(x => x.User).WithMany(x => x.UserNCategories).OnDelete(DeleteBehavior.Restrict);
                entity.HasKey(a => new { a.UserId, a.NCategoryId });
            });

            builder.Entity<UserNJobType>(entity =>
            {
                entity.HasOne(x => x.User).WithMany(x => x.UserNJobTypes).OnDelete(DeleteBehavior.Restrict);
                entity.HasKey(a => new { a.UserId, a.NJobTypeId });
            });
            
            builder.Entity<User>().HasMany(x => x.CreatedByGalleryImages).WithOne(x => x.CreatedByUser as User)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<User>()
                .HasMany(x => x.ModifiedByGalleryImages)
                .WithOne(x => x.ModifiedByUser as User)
          
                .OnDelete(DeleteBehavior.Restrict);

            

            builder.Entity<NEducation>().ToTable("N_Educations");
            builder.Entity<NBusinessSector>().ToTable("N_BusinessSectors");

            DataSeed.SeedEducation(builder);
            DataSeed.SeedBusinessSector(builder);
            DataSeed.SeedSkills(builder);
            DataSeed.SeedCategories(builder);
            DataSeed.SeedJobTypes(builder);
            DataSeed.SeedHealthStatuses(builder);
            DataSeed.SeedGender(builder);
            DataSeed.SeedCountry(builder);
            DataSeed.SeedTown(builder);
        }

        public DbSet<BaseUser> BaseUsers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BusinessUser> BusinessUsers { get; set; }
        public DbSet<AdministrationUser> AdministrationUsers { get; set; }
        public DbSet<NEducation> NEducations { get; set; }
        public DbSet<NBusinessSector> NBusinessSectors { get; set; }
        public DbSet<NSkill> NSkills { get; set; }
        public DbSet<UserNSkill> UsersNSkills { get; set; }
        public DbSet<NCategory> NCategories { get; set; }
        public DbSet<UserNCategory> UserNCategories { get; set; }
        public DbSet<NJobType> NJobTypes { get; set; }
        public DbSet<UserNJobType> UserNJobTypes { get; set; }
        public DbSet<NHealthStatus> NHealthStatuses { get; set; }
        public DbSet<UserNHealthStatus> UserNHealthStatuses { get; set; }
        public DbSet<NGender> NGenders { get; set; }
        public DbSet<NCountry> NCountries { get; set; }
        public DbSet<NTown> NTowns { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
    }
}