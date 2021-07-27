using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class PostType : BaseEntity, IAggregateRoot
    {
        public string Type { get; private set; }

        public PostType(string type)
        {
            Type = type;
        }
    }
}