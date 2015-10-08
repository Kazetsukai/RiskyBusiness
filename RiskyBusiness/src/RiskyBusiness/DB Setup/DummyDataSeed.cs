using RiskyBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiskyBusiness.DB_Setup
{
    public class DummyDataSeed
    {
        public void Seed(Risks_issues_DEVLContext Context)
        {
            //var RiskMeta = new RiskMeta();

            var Risk1 = new Risks()
            {
                risk_descr = "This is a risk associated with Hack day",
                category = RiskMeta.Categories.Communication.ToString(),
                comments = "This is an example comment",
                date_raised = DateTime.Now.AddDays(-2),
                last_review_date = DateTime.Now.AddDays(-2),
                mitigation_plan = "This is how we will mitiage",
                next_review_date = DateTime.Now.AddDays(7),
                owner = "Sam",
                pre_mitigation_impact = RiskMeta.Impact.Low.ToString(),
                pre_mitigation_probability = RiskMeta.Probability.Medium.ToString(),
                pre_mitigation_risk_level = RiskMeta.RiskLevel.Low.ToString(),
                post_mitigation_impact = RiskMeta.Impact.Low.ToString(),
                post_mitigation_probability = RiskMeta.Probability.Low.ToString(),
                post_mitigation_risk_level = RiskMeta.RiskLevel.High.ToString(),
                raised_by = "Daniel",
                risk_ref_id = "",
                status = RiskMeta.Status.Open.ToString()
            };

            var Risk2 = new Risks()
            {
                risk_descr = "Taupo the volcano can explode at any time",
                category = RiskMeta.Categories.Global.ToString(),
                comments = "This will be bad!",
                date_raised = DateTime.Now.AddDays(-500),
                last_review_date = DateTime.Now.AddDays(-14),
                mitigation_plan = "Move to England",
                next_review_date = DateTime.Now.AddDays(7),
                owner = "Sam",
                pre_mitigation_impact = RiskMeta.Impact.High.ToString(),
                pre_mitigation_probability = RiskMeta.Probability.High.ToString(),
                pre_mitigation_risk_level = RiskMeta.RiskLevel.High.ToString(),
                post_mitigation_impact = RiskMeta.Impact.Medium.ToString(),
                post_mitigation_probability = RiskMeta.Probability.Medium.ToString(),
                post_mitigation_risk_level = RiskMeta.RiskLevel.Medium.ToString(),
                raised_by = "Daniel",
                risk_ref_id = "",
                status = RiskMeta.Status.Open.ToString()
            };

            var Risk3 = new Risks()
            {
                risk_descr = "Github sells out to Microsoft",
                category = RiskMeta.Categories.Global.ToString(),
                comments = "Everyone has there price",
                date_raised = DateTime.Now.AddDays(-500),
                last_review_date = DateTime.Now.AddDays(-14),
                mitigation_plan = "Keep local backups",
                next_review_date = DateTime.Now.AddDays(7),
                owner = "Sam",
                pre_mitigation_impact = RiskMeta.Impact.Medium.ToString(),
                pre_mitigation_probability = RiskMeta.Probability.Low.ToString(),
                pre_mitigation_risk_level = RiskMeta.RiskLevel.Low.ToString(),
                post_mitigation_impact = RiskMeta.Impact.Low.ToString(),
                post_mitigation_probability = RiskMeta.Probability.Low.ToString(),
                post_mitigation_risk_level = RiskMeta.RiskLevel.Low.ToString(),
                raised_by = "Jimmy",
                risk_ref_id = "",
                status = RiskMeta.Status.Open.ToString()
            };

            Context.Risks.Add(Risk1);
            Context.Risks.Add(Risk2);
            Context.Risks.Add(Risk3);

            Context.SaveChanges();
        }
    }
}
