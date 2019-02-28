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

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amaris.Foundation.CrowdAct.NetDal.Configurations
{
    using Entities;
    using Interfaces;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // Activity
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ActivityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Activity>
    {
        public ActivityConfiguration()
            : this("dbo")
        {
        }

        public ActivityConfiguration(string schema)
        {
            Property(x => x.Name).IsOptional();
            Property(x => x.Description).IsOptional();
            Property(x => x.Picture).IsOptional();
            Property(x => x.AddressId).IsOptional();
            Property(x => x.FieldId).IsOptional();
            Property(x => x.TypeId).IsOptional();

            HasMany(t => t.Skills).WithMany(t => t.Activities).Map(m =>
            {
                m.ToTable("ActivitySkill", "dbo");
                m.MapLeftKey("ActivityID");
                m.MapRightKey("SkillID");
            });
        }
    }

}
// </auto-generated>
