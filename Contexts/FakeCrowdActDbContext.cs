// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace AmaFon.CrowdAct.Net.DataLayer.Contexts
{
    using Configurations;
    using Entities;
    using Interfaces;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FakeCrowdActDbContext : ICrowdActDbContext
    {
        public System.Data.Entity.DbSet<AccountStatus> AccountStatus { get; set; }
        public System.Data.Entity.DbSet<Activity> Activities { get; set; }
        public System.Data.Entity.DbSet<ActivityLanguage> ActivityLanguages { get; set; }
        public System.Data.Entity.DbSet<ActivityParticipant> ActivityParticipants { get; set; }
        public System.Data.Entity.DbSet<ActivityType> ActivityTypes { get; set; }
        public System.Data.Entity.DbSet<Address> Addresses { get; set; }
        public System.Data.Entity.DbSet<Category> Categories { get; set; }
        public System.Data.Entity.DbSet<Charity> Charities { get; set; }
        public System.Data.Entity.DbSet<City> Cities { get; set; }
        public System.Data.Entity.DbSet<Country> Countries { get; set; }
        public System.Data.Entity.DbSet<EfMigrationsHistory> EfMigrationsHistories { get; set; }
        public System.Data.Entity.DbSet<Language> Languages { get; set; }
        public System.Data.Entity.DbSet<ParticipantStatus> ParticipantStatus { get; set; }
        public System.Data.Entity.DbSet<Requirement> Requirements { get; set; }
        public System.Data.Entity.DbSet<RequirementStatus> RequirementStatus { get; set; }
        public System.Data.Entity.DbSet<ResourceType> ResourceTypes { get; set; }
        public System.Data.Entity.DbSet<Skill> Skills { get; set; }
        public System.Data.Entity.DbSet<User> Users { get; set; }

        public FakeCrowdActDbContext()
        {
            _changeTracker = null;
            _configuration = null;
            _database = null;

            AccountStatus = new FakeDbSet<AccountStatus>("Id");
            Activities = new FakeDbSet<Activity>("Id");
            ActivityLanguages = new FakeDbSet<ActivityLanguage>("ActivityId", "LanguageId");
            ActivityParticipants = new FakeDbSet<ActivityParticipant>("ActivityId", "ParticipantId");
            ActivityTypes = new FakeDbSet<ActivityType>("Id");
            Addresses = new FakeDbSet<Address>("Id");
            Categories = new FakeDbSet<Category>("Id");
            Charities = new FakeDbSet<Charity>("Id");
            Cities = new FakeDbSet<City>("Id");
            Countries = new FakeDbSet<Country>("Id");
            EfMigrationsHistories = new FakeDbSet<EfMigrationsHistory>("MigrationId");
            Languages = new FakeDbSet<Language>("Id");
            ParticipantStatus = new FakeDbSet<ParticipantStatus>("Id");
            Requirements = new FakeDbSet<Requirement>("Id");
            RequirementStatus = new FakeDbSet<RequirementStatus>("Id");
            ResourceTypes = new FakeDbSet<ResourceType>("Id");
            Skills = new FakeDbSet<Skill>("Id");
            Users = new FakeDbSet<User>("Id");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        private System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        private System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
// </auto-generated>
