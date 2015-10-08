using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiskyBusiness.Models
{
    public class RiskMeta
    {
        public enum Categories
        {
            Communication,
            Legal,
            Technology,
            Global,
            People
        };

        public enum Impact
        {
            Low,
            Medium,
            High
        };

        public enum Probability
        {
            Low,
            Medium,
            High
        };

        public enum RiskLevel
        {
            Low,
            Medium,
            High
        };

        public enum Status
        {
            Open,
            Closed,
            Monitor
        };
    }
}
