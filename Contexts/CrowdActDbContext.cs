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


namespace Amaris.Foundation.CrowdAct.NetDal.Contexts
{
    using Configurations;
    using Entities;
    using Interfaces;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class CrowdActDbContext : System.Data.Entity.DbContext, ICrowdActDbContext
    {
        public System.Data.Entity.DbSet<AccountStatu> AccountStatus { get; set; } // AccountStatus
        public System.Data.Entity.DbSet<Activity> Activities { get; set; } // Activity
        public System.Data.Entity.DbSet<ActivityLanguage> ActivityLanguages { get; set; } // ActivityLanguage
        public System.Data.Entity.DbSet<ActivityParticipant> ActivityParticipants { get; set; } // ActivityParticipant
        public System.Data.Entity.DbSet<Address> Addresses { get; set; } // Address
        public System.Data.Entity.DbSet<Category> Categories { get; set; } // Category
        public System.Data.Entity.DbSet<Charity> Charities { get; set; } // Charity
        public System.Data.Entity.DbSet<City> Cities { get; set; } // City
        public System.Data.Entity.DbSet<Country> Countries { get; set; } // Country
        public System.Data.Entity.DbSet<EfMigrationsHistory> EfMigrationsHistories { get; set; } // __EFMigrationsHistory
        public System.Data.Entity.DbSet<Language> Languages { get; set; } // Language
        public System.Data.Entity.DbSet<ParticipantStatu> ParticipantStatus { get; set; } // ParticipantStatus
        public System.Data.Entity.DbSet<Requirement> Requirements { get; set; } // Requirement
        public System.Data.Entity.DbSet<RequirementStatu> RequirementStatus { get; set; } // RequirementStatus
        public System.Data.Entity.DbSet<ResourceType> ResourceTypes { get; set; } // ResourceType
        public System.Data.Entity.DbSet<Skill> Skills { get; set; } // Skill
        public System.Data.Entity.DbSet<Entities.Type> Types { get; set; } // Type
        public System.Data.Entity.DbSet<User> Users { get; set; } // User

        static CrowdActDbContext()
        {
            System.Data.Entity.Database.SetInitializer<CrowdActDbContext>(null);
        }

        public CrowdActDbContext()
            : base("Name=CrowdActConnectionString")
        {
        }

        public CrowdActDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public CrowdActDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public CrowdActDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public CrowdActDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AccountStatuConfiguration());
            modelBuilder.Configurations.Add(new ActivityConfiguration());
            modelBuilder.Configurations.Add(new ActivityLanguageConfiguration());
            modelBuilder.Configurations.Add(new ActivityParticipantConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new CharityConfiguration());
            modelBuilder.Configurations.Add(new CityConfiguration());
            modelBuilder.Configurations.Add(new CountryConfiguration());
            modelBuilder.Configurations.Add(new EfMigrationsHistoryConfiguration());
            modelBuilder.Configurations.Add(new LanguageConfiguration());
            modelBuilder.Configurations.Add(new ParticipantStatuConfiguration());
            modelBuilder.Configurations.Add(new RequirementConfiguration());
            modelBuilder.Configurations.Add(new RequirementStatuConfiguration());
            modelBuilder.Configurations.Add(new ResourceTypeConfiguration());
            modelBuilder.Configurations.Add(new SkillConfiguration());
            modelBuilder.Configurations.Add(new TypeConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AccountStatuConfiguration(schema));
            modelBuilder.Configurations.Add(new ActivityConfiguration(schema));
            modelBuilder.Configurations.Add(new ActivityLanguageConfiguration(schema));
            modelBuilder.Configurations.Add(new ActivityParticipantConfiguration(schema));
            modelBuilder.Configurations.Add(new AddressConfiguration(schema));
            modelBuilder.Configurations.Add(new CategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new CharityConfiguration(schema));
            modelBuilder.Configurations.Add(new CityConfiguration(schema));
            modelBuilder.Configurations.Add(new CountryConfiguration(schema));
            modelBuilder.Configurations.Add(new EfMigrationsHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new LanguageConfiguration(schema));
            modelBuilder.Configurations.Add(new ParticipantStatuConfiguration(schema));
            modelBuilder.Configurations.Add(new RequirementConfiguration(schema));
            modelBuilder.Configurations.Add(new RequirementStatuConfiguration(schema));
            modelBuilder.Configurations.Add(new ResourceTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new SkillConfiguration(schema));
            modelBuilder.Configurations.Add(new TypeConfiguration(schema));
            modelBuilder.Configurations.Add(new UserConfiguration(schema));
            return modelBuilder;
        }
    }
}
// </auto-generated>
