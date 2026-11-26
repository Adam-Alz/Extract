using System;
using System.Collections.Generic;
using System.Text;

namespace Extract.Core.Models
{
    public class ItemQuestRequirements
    {
        public ItemQuestRequirements(string questNormalizedName,  int questItemCount, bool foundInRaid) 
        {   
            QuestNormalizedName = questNormalizedName;
            QuestItemCount = questItemCount;
            FoundInRaid = foundInRaid;
        }

        public string QuestNormalizedName { get; set; } = string.Empty;
        public int QuestItemCount { get; set; }
        public bool FoundInRaid { get; set; }
    }
}
