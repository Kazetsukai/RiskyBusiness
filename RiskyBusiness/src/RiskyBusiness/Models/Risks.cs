using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace RiskyBusiness
{
    public class Risks
    {
        public int risk_key { get; set; }
        public string category { get; set; }
        public string comments { get; set; }
        public DateTime? date_raised { get; set; }
        public DateTime? last_review_date { get; set; }
        public string mitigation_plan { get; set; }
        public DateTime? next_review_date { get; set; }
        public string owner { get; set; }
        public string post_mitigation_impact { get; set; }
        public string post_mitigation_probability { get; set; }
        public string post_mitigation_risk_level { get; set; }
        public string pre_mitigation_impact { get; set; }
        public string pre_mitigation_probability { get; set; }
        public string pre_mitigation_risk_level { get; set; }
        public string raised_by { get; set; }
        public string risk_descr { get; set; }
        public string risk_ref_id { get; set; }
        public string status { get; set; }

        // Unable to add a Navigation Property referencing type Risks_link because of errors generating that EntityType.
        // Unable to add a Navigation Property referencing type Risks_link because of errors generating that EntityType.
    }
}
