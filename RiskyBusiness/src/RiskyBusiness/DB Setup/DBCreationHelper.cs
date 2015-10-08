using Microsoft.Data.Entity;
using RiskyBusiness.DB_Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiskyBusiness
{
    public partial class Risks_issues_DEVLContext : DbContext
    {
        public void Seed(Risks_issues_DEVLContext Context)
        {
            var dds = new DummyDataSeed();
            dds.Seed(Context);
        }

        static Risks_issues_DEVLContext()
        {
            using (Risks_issues_DEVLContext context = new Risks_issues_DEVLContext())
            {
                if (!context.Risks.Any())
                {
                    context.Seed(context);
                }
            }
        }
    }
}
