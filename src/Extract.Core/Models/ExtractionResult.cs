using System;
using System.Collections.Generic;
using System.Text;

namespace Extract.Core.Models
{
    public class ExtractionResult
    {
        public ExtractionResult(bool success, Item item, double confidenceScore, string status, TimeSpan executionTime) 
        {
            Success = success;
            Item = item;
            ConfidenceScore = confidenceScore;
            Status = status;
            ExecutionTime = executionTime;
        }

        public bool Success { get; set; }
        public Item? Item { get; set; }
        public double ConfidenceScore { get; set; }
        public string Status { get; set; } = string.Empty;
        public TimeSpan ExecutionTime { get; set; }
    }
}
