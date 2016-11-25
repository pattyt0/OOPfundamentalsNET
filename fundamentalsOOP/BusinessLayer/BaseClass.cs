using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public enum publicStateOption
    {
        Active,
        Deleted
    }

    public abstract class BaseClass
    {
        public publicStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }

        public bool IsNew { get; private set; }


    }
}
