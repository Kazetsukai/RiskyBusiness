using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace RiskyBusiness
{
    public class risk_projects
    {
        public risk_projects()
        {
            Risks = new HashSet<Risks>();
        }

        public string project_task_reference { get; set; }
        public string account_manager { get; set; }
        public decimal? actual_hours_recorded { get; set; }
        public string affected_system { get; set; }
        public decimal? analysis_estimate { get; set; }
        public string analyst { get; set; }
        public string author { get; set; }
        public string budget_owner { get; set; }
        public string business_unit_code { get; set; }
        public string business_unit_descr { get; set; }
        public short? capitalise_ind { get; set; }
        public DateTime? close_date { get; set; }
        public int? closed_elapsed_days { get; set; }
        public DateTime? create_date { get; set; }
        public string created_by { get; set; }
        public DateTime? dss_update_time { get; set; }
        public int? elapsed_days { get; set; }
        public string estimated_by { get; set; }
        public string on_hold { get; set; }
        public string one_line_descr { get; set; }
        public string person_with { get; set; }
        public string priority { get; set; }
        public string programmer { get; set; }
        public string project_header_reference { get; set; }
        public string project_manager { get; set; }
        public int? quantity { get; set; }
        public string reporting { get; set; }
        public string review { get; set; }
        public string status { get; set; }
        public DateTime? target_date { get; set; }
        public string task_details { get; set; }
        public string work_completed_by { get; set; }
        public string work_stage { get; set; }

        public virtual ICollection<Risks> Risks { get; set; }
    }
}
