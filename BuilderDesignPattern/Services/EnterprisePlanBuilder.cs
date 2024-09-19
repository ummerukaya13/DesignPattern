using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderDesignPatternDemo.Models;

namespace BuilderDesignPatternDemo.Services
{
    //Concrete Builder: Implements the builder interface and provides the actual construction logic for creating the product.
    public class EnterprisePlanBuilder : IPlanBuilder
    {
        private readonly Plan _plan = new Plan();

        public EnterprisePlanBuilder()
        {
            _plan = new Plan() { Name = "Enterprise", Price = 49 };
        }

        public void BuildDiskSpaceFeature()
        {
            _plan.AddFeature(new Feature() { Title = "Disk Space", Value = "100 GB" });
        }

        public void BuildDatabaseFeature()
        {
            _plan.AddFeature(new Feature() { Title = "Database Size", Value = "300 GB" });
        }

        public void BuildBandwidthFeature()
        {
            _plan.AddFeature(new Feature() { Title = "Bandwidth", Value = "Unlimited" });
        }

        public void BuildSslFeature()
        {
            _plan.AddFeature(new Feature() { Title = "SSL", Value = "Free" });
        }

        public Plan GetPlan()
        {
            return _plan;
        }
    }
}
