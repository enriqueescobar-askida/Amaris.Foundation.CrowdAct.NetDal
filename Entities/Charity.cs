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

    // Charity
    /// <summary>
    /// Defines the <see cref="Charity" />
    /// </summary>
    [Table("Charity", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Charity
    {
        /// <summary>
        /// Gets or sets the Id
        /// ID (Primary key)
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK_Charity", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the OrgName
        /// </summary>
        [Column(@"OrgName", Order = 2, TypeName = "nvarchar(max)")]
        [Display(Name = "Org name")]
        public string OrgName { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        [Column(@"Description", Order = 3, TypeName = "nvarchar(max)")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Picture
        /// </summary>
        [Column(@"Picture", Order = 4, TypeName = "nvarchar(max)")]
        [Display(Name = "Picture")]
        public string Picture { get; set; }

        /// <summary>
        /// Gets or sets the Certificate
        /// </summary>
        [Column(@"Certificate", Order = 5, TypeName = "nvarchar(max)")]
        [Display(Name = "Certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// Gets or sets the RegisteredDate
        /// </summary>
        [Column(@"RegisteredDate", Order = 6, TypeName = "datetime2")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Registered date")]
        public System.DateTime RegisteredDate { get; set; }

        /// <summary>
        /// Gets or sets the Email
        /// Email (length: 450)
        /// </summary>
        [Column(@"Email", Order = 7, TypeName = "nvarchar")]
        [Index(@"AK_Charity_Email", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(450)]
        [StringLength(450)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Phone
        /// </summary>
        [Column(@"Phone", Order = 8, TypeName = "nvarchar(max)")]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the Website
        /// </summary>
        [Column(@"Website", Order = 9, TypeName = "nvarchar(max)")]
        [Display(Name = "Website")]
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets the Siren
        /// </summary>
        [Column(@"SIREN", Order = 10, TypeName = "nvarchar(max)")]
        [Display(Name = "Siren")]
        public string Siren { get; set; }

        /// <summary>
        /// Gets or sets the Logo
        /// </summary>
        [Column(@"Logo", Order = 11, TypeName = "nvarchar(max)")]
        [Display(Name = "Logo")]
        public string Logo { get; set; }

        /// <summary>
        /// Gets or sets the RepresentativeId
        /// </summary>
        [Column(@"RepresentativeID", Order = 12, TypeName = "int")]
        [Index(@"IX_Charity_RepresentativeID", 1, IsUnique = false, IsClustered = false)]
        [Required]
        [Display(Name = "Representative ID")]
        public int RepresentativeId { get; set; }

        /// <summary>
        /// Gets or sets the AddressId
        /// </summary>
        [Column(@"AddressID", Order = 13, TypeName = "int")]
        [Index(@"IX_Charity_AddressID", 1, IsUnique = true, IsClustered = false)]
        [Display(Name = "Address ID")]
        public int? AddressId { get; set; }

        /// <summary>
        /// Gets or sets the FieldId
        /// </summary>
        [Column(@"FieldID", Order = 14, TypeName = "int")]
        [Index(@"IX_Charity_FieldID", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Field ID")]
        public int? FieldId { get; set; }

        // Reverse navigation

        /// <summary>
        /// Gets or sets the Activities
        /// Child Activities where [Activity].[CharityID] point to this entity (FK_Activity_Charity_CharityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Activity> Activities { get; set; }

        /// <summary>
        /// Gets or sets the Address
        /// Parent Address pointed by [Charity].([AddressId]) (FK_Charity_Address_AddressID)
        /// </summary>
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }

        /// <summary>
        /// Gets or sets the Category
        /// Parent Category pointed by [Charity].([FieldId]) (FK_Charity_Category_FieldID)
        /// </summary>
        [ForeignKey("FieldId")]
        public virtual Category Category { get; set; }

        /// <summary>
        /// Gets or sets the User
        /// Parent User pointed by [Charity].([RepresentativeId]) (FK_Charity_User_RepresentativeID)
        /// </summary>
        [ForeignKey("RepresentativeId"), Required]
        public virtual User User { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Charity"/> class.
        /// </summary>
        public Charity()
        {
            Activities = new System.Collections.Generic.List<Activity>();
        }
    }
}
// </auto-generated>