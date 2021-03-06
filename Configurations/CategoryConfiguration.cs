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

namespace AmaFon.CrowdAct.Net.DataLayer.Configurations
{
    using Entities;

    // Category
    /// <summary>
    /// Defines the <see cref="CategoryConfiguration" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class CategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Category>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryConfiguration"/> class.
        /// </summary>
        public CategoryConfiguration()
            : this("dbo")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryConfiguration"/> class.
        /// </summary>
        /// <param name="schema">The schema<see cref="string"/></param>
        public CategoryConfiguration(string schema)
        {
            HasMany(t => t.Users).WithMany(t => t.Categories).Map(m =>
            {
                m.ToTable("ParticipantCategory", "dbo");
                m.MapLeftKey("CategoryID");
                m.MapRightKey("ParticipantID");
            });
        }
    }
}
// </auto-generated>