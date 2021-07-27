using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class AuditableEntity : BaseEntity
    {
#nullable enable
        public string? CreatedBy { get; protected set; }
        public DateTime? CreatedDate { get; protected set; }
        public string? UpdatedBy { get; protected set; }
        public DateTime? UpdatedDate { get; protected set; }
#nullable disable
        public bool IsDeleted { get; protected set; }
    }
}