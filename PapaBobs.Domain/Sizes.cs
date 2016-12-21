using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain {
    public enum Sizes {
        [Description("Small (12 inch - $12)")]
        Small = 12,
        [Description("Medium (14 inch - $14)")]
        Medium = 14,
        [Description("Large (16 inch - $16")]
        Large = 16
    }
}
