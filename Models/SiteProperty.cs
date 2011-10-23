using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace site.Models
{
    public class SiteProperty
    {
        public virtual int Id { get; set; }
        public virtual string PropertyName { get; set; }
        public virtual string PropertyText { get; set; }
        public virtual string Test { get; set; }
    }
}