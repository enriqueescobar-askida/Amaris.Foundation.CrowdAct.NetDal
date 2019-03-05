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

namespace AmaFon.CrowdAct.Net.DataLayer.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    // __EFMigrationsHistory
    /// <summary>
    /// Defines the <see cref="EfMigrationsHistory" />
    /// </summary>
    [Table("__EFMigrationsHistory", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class EfMigrationsHistory
    {
        /// <summary>
        /// Gets or sets the MigrationId
        /// MigrationId (Primary key) (length: 150)
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"MigrationId", Order = 1, TypeName = "nvarchar")]
        [Index(@"PK___EFMigrationsHistory", 1, IsUnique = true, IsClustered = true)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Key]
        [Display(Name = "Migration ID")]
        public string MigrationId { get; set; }

        /// <summary>
        /// Gets or sets the ProductVersion
        /// ProductVersion (length: 32)
        /// </summary>
        [Column(@"ProductVersion", Order = 2, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(32)]
        [StringLength(32)]
        [Display(Name = "Product version")]
        public string ProductVersion { get; set; }
    }
}
// </auto-generated>