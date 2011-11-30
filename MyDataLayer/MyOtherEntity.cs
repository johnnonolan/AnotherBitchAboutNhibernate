using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDataLayer
{
    public class MyOtherEntity
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }

        public virtual IList<Child> Children { get; set; }
    }

    public class Child
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
    }
}
