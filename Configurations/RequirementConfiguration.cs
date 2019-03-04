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

namespace AmaFon.CrowdAct.Net.DataLayer.Configurations
{
    using Entities;
    using Interfaces;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // Requirement
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class RequirementConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Requirement>
    {
        public RequirementConfiguration()
            : this("dbo")
        {
        }

        public RequirementConfiguration(string schema)
        {
            Property(x => x.Name).IsOptional();
            Property(x => x.ResourceTypeId).IsOptional();
            Property(x => x.RequirementStatusId).IsOptional();

        }
    }

}
// </auto-generated>
