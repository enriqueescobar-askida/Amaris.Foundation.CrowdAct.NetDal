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

    // Requirement
    /// <summary>
    /// Defines the <see cref="Requirement" />
    /// </summary>
    [Table("Requirement", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Requirement
    {
        /// <summary>
        /// Gets or sets the Id
        /// ID (Primary key)
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK_Requirement", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        [Column(@"Name", Order = 2, TypeName = "nvarchar(max)")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the TargetedQuantity
        /// </summary>
        [Column(@"TargetedQuantity", Order = 3, TypeName = "bigint")]
        [Required]
        [Display(Name = "Targeted quantity")]
        public long TargetedQuantity { get; set; }

        /// <summary>
        /// Gets or sets the CollectedQuantity
        /// </summary>
        [Column(@"CollectedQuantity", Order = 4, TypeName = "bigint")]
        [Required]
        [Display(Name = "Collected quantity")]
        public long CollectedQuantity { get; set; }

        /// <summary>
        /// Gets or sets the ActivityId
        /// </summary>
        [Column(@"ActivityID", Order = 5, TypeName = "int")]
        [Index(@"IX_Requirement_ActivityID", 1, IsUnique = false, IsClustered = false)]
        [Required]
        [Display(Name = "Activity ID")]
        public int ActivityId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceTypeId
        /// </summary>
        [Column(@"ResourceTypeID", Order = 6, TypeName = "int")]
        [Index(@"IX_Requirement_ResourceTypeID", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Resource type ID")]
        public int? ResourceTypeId { get; set; }

        /// <summary>
        /// Gets or sets the RequirementStatusId
        /// </summary>
        [Column(@"RequirementStatusID", Order = 7, TypeName = "int")]
        [Index(@"IX_Requirement_RequirementStatusID", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Requirement status ID")]
        public int? RequirementStatusId { get; set; }

        // Foreign keys

        /// <summary>
        /// Gets or sets the Activity
        /// Parent Activity pointed by [Requirement].([ActivityId]) (FK_Requirement_Activity_ActivityID)
        /// </summary>
        [ForeignKey("ActivityId"), Required]
        public virtual Activity Activity { get; set; }

        /// <summary>
        /// Gets or sets the RequirementStatus
        /// Parent RequirementStatus pointed by [Requirement].([RequirementStatusId]) (FK_Requirement_RequirementStatus_RequirementStatusID)
        /// </summary>
        [ForeignKey("RequirementStatusId")]
        public virtual RequirementStatus RequirementStatus { get; set; }

        /// <summary>
        /// Gets or sets the ResourceType
        /// Parent ResourceType pointed by [Requirement].([ResourceTypeId]) (FK_Requirement_ResourceType_ResourceTypeID)
        /// </summary>
        [ForeignKey("ResourceTypeId")]
        public virtual ResourceType ResourceType { get; set; }
    }
}
// </auto-generated>