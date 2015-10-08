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
            Moderate,
            High
        };

        public enum Probability
        {
            Unlikely,
            Moderate,
            Likely
        };

        public enum RiskLevel
        {
            Low,
            Moderate,
            High,
            Extreme,
            Incomprehensible
        };

        public enum Status
        {
            Open,
            Closed,
            Monitor
        };
    }
}
