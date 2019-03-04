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

namespace AmaFon.CrowdAct.Net.DataLayer.Entities
{

    // User
    [Table("User", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK_User", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; } // ID (Primary key)

        [Column(@"FirstName", Order = 2, TypeName = "nvarchar(max)")]
        [Display(Name = "First name")]
        public string FirstName { get; set; } // FirstName

        [Column(@"LastName", Order = 3, TypeName = "nvarchar(max)")]
        [Display(Name = "Last name")]
        public string LastName { get; set; } // LastName

        [Column(@"Email", Order = 4, TypeName = "nvarchar")]
        [Index(@"AK_User_Email", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(450)]
        [StringLength(450)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } // Email (length: 450)

        [Column(@"Password", Order = 5, TypeName = "nvarchar(max)")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } // Password

        [Column(@"Phone", Order = 6, TypeName = "nvarchar(max)")]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; } // Phone

        [Column(@"BirthDate", Order = 7, TypeName = "datetime2")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Birth date")]
        public System.DateTime? BirthDate { get; set; } // BirthDate

        [Column(@"Avatar", Order = 8, TypeName = "nvarchar(max)")]
        [Display(Name = "Avatar")]
        public string Avatar { get; set; } // Avatar

        [Column(@"AddressID", Order = 9, TypeName = "int")]
        [Index(@"IX_User_AddressID", 1, IsUnique = true, IsClustered = false)]
        [Display(Name = "Address ID")]
        public int? AddressId { get; set; } // AddressID

        [Column(@"AccountStatusID", Order = 10, TypeName = "int")]
        [Index(@"IX_User_AccountStatusID", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Account status ID")]
        public int? AccountStatusId { get; set; } // AccountStatusID

        // Reverse navigation

        /// <summary>
        /// Child ActivityParticipants where [ActivityParticipant].[ParticipantID] point to this entity (FK_ActivityParticipant_User_ParticipantID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ActivityParticipant> ActivityParticipants { get; set; } // ActivityParticipant.FK_ActivityParticipant_User_ParticipantID
        /// <summary>
        /// Child Categories (Many-to-Many) mapped by table [ParticipantCategory]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Category> Categories { get; set; } // Many to many mapping
        /// <summary>
        /// Child Charities where [Charity].[RepresentativeID] point to this entity (FK_Charity_User_RepresentativeID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Charity> Charities { get; set; } // Charity.FK_Charity_User_RepresentativeID

        // Foreign keys

        /// <summary>
        /// Parent AccountStatus pointed by [User].([AccountStatusId]) (FK_User_AccountStatus_AccountStatusID)
        /// </summary>
        [ForeignKey("AccountStatusId")] public virtual AccountStatus AccountStatus { get; set; } // FK_User_AccountStatus_AccountStatusID

        /// <summary>
        /// Parent Address pointed by [User].([AddressId]) (FK_User_Address_AddressID)
        /// </summary>
        [ForeignKey("AddressId")] public virtual Address Address { get; set; } // FK_User_Address_AddressID

        public User()
        {
            ActivityParticipants = new System.Collections.Generic.List<ActivityParticipant>();
            Charities = new System.Collections.Generic.List<Charity>();
            Categories = new System.Collections.Generic.List<Category>();
        }
    }

}
// </auto-generated>
