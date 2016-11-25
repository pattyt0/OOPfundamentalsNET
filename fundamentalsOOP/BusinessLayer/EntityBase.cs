using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }

        public EntityStateOption EntityState { get; set; }
        public bool IsValid { get
            {
                return true;
            }
        }

        public abstract bool Validate();
    
        public enum EntityStateOption
        {
            Active,
            Deleted
        }
    }
}
