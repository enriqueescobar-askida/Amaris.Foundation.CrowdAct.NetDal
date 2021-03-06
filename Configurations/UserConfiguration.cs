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

    // User
    /// <summary>
    /// Defines the <see cref="UserConfiguration" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class UserConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConfiguration"/> class.
        /// </summary>
        public UserConfiguration()
            : this("dbo")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserConfiguration"/> class.
        /// </summary>
        /// <param name="schema">The schema<see cref="string"/></param>
        public UserConfiguration(string schema)
        {
            Property(x => x.FirstName).IsOptional();
            Property(x => x.LastName).IsOptional();
            Property(x => x.Password).IsOptional();
            Property(x => x.Phone).IsOptional();
            Property(x => x.BirthDate).IsOptional();
            Property(x => x.Avatar).IsOptional();
            Property(x => x.AddressId).IsOptional();
            Property(x => x.AccountStatusId).IsOptional();
        }
    }
}
// </auto-generated>