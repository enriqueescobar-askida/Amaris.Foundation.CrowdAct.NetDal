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

    // Language
    /// <summary>
    /// Defines the <see cref="Language" />
    /// </summary>
    [Table("Language", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Language
    {
        /// <summary>
        /// Gets or sets the Id
        /// ID (Primary key)
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK_Language", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Label
        /// Label (length: 450)
        /// </summary>
        [Column(@"Label", Order = 2, TypeName = "nvarchar")]
        [Index(@"AK_Language_Label", 1, IsUnique = true, IsClustered = false)]
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
        /// Gets or sets the ActivityLanguages
        /// Child ActivityLanguages where [ActivityLanguage].[LanguageID] point to this entity (FK_ActivityLanguage_Language_LanguageID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ActivityLanguage> ActivityLanguages { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Language"/> class.
        /// </summary>
        public Language()
        {
            ActivityLanguages = new System.Collections.Generic.List<ActivityLanguage>();
        }
    }
}
// </auto-generated>