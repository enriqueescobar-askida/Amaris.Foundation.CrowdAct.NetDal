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

namespace Amaris.Foundation.CrowdAct.NetDal.Entities
{

    // Category
    [Table("Category", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK_Category", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; } // ID (Primary key)

        [Column(@"Label", Order = 2, TypeName = "nvarchar")]
        [Index(@"AK_Category_Label", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(450)]
        [StringLength(450)]
        [Display(Name = "Label")]
        public string Label { get; set; } // Label (length: 450)

        // Reverse navigation

        /// <summary>
        /// Child Activities where [Activity].[FieldID] point to this entity (FK_Activity_Category_FieldID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Activity> Activities { get; set; } // Activity.FK_Activity_Category_FieldID
        /// <summary>
        /// Child Charities where [Charity].[FieldID] point to this entity (FK_Charity_Category_FieldID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Charity> Charities { get; set; } // Charity.FK_Charity_Category_FieldID
        /// <summary>
        /// Child Users (Many-to-Many) mapped by table [ParticipantCategory]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<User> Users { get; set; } // Many to many mapping

        public Category()
        {
            Activities = new System.Collections.Generic.List<Activity>();
            Charities = new System.Collections.Generic.List<Charity>();
            Users = new System.Collections.Generic.List<User>();
        }
    }

}
// </auto-generated>
