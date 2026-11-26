using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Extract.Core.Models
{
    public class HideoutRequirements
    {
        public HideoutRequirements(string hideoutNormalizedName, int requiredLevel, int count)
        {
            HideoutNormalizedName = hideoutNormalizedName;
            RequiredLevel = requiredLevel;
            Count = count;
        }

        public string HideoutNormalizedName { get; set; } = string.Empty;
        public int RequiredLevel { get; set; }
        public int Count { get; set; }
    }
}
