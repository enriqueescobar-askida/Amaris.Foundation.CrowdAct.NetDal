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

    // Country
    /// <summary>
    /// Defines the <see cref="Country" />
    /// </summary>
    [Table("Country", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Country
    {
        /// <summary>
        /// Gets or sets the Id
        /// ID (Primary key)
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK_Country", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Label
        /// Label (length: 450)
        /// </summary>
        [Column(@"Label", Order = 2, TypeName = "nvarchar")]
        [Index(@"AK_Country_Label", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(450)]
        [StringLength(450)]
        [Display(Name = "Label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Active
        /// </summary>
        [Column(@"Active", Order = 3, TypeName = "bit")]
        [Required]
        [Display(Name = "Active")]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Disabled
        /// </summary>
        [Column(@"Disabled", Order = 4, TypeName = "bit")]
        [Required]
        [Display(Name = "Disabled")]
        public bool Disabled { get; set; }

        // Reverse navigation

        /// <summary>
        /// Gets or sets the Cities
        /// Child Cities where [City].[CountryID] point to this entity (FK_City_Country_CountryID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<City> Cities { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Country"/> class.
        /// </summary>
        public Country()
        {
            this.Cities = new System.Collections.Generic.List<City>();
        }
    }
}
// </auto-generated>