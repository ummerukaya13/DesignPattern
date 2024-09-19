using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderDesignPatternDemo.Models;

namespace BuilderDesignPatternDemo.Services
{
    //Concrete Builder: Implements the builder interface and provides the actual construction logic for creating the product.
    public class BasicPlanBuilder : IPlanBuilder
    {
        private readonly Plan _plan = new Plan();

        public BasicPlanBuilder()
        {
            _plan = new Plan() { Name = "Basic", Price = 19 };
        }

        public void BuildDiskSpaceFeature()
        {
            _plan.AddFeature(new Feature() { Title = "Disk Space", Value = "1 GB" });
        }

        public void BuildDatabaseFeature()
        {
            _plan.AddFeature(new Feature() { Title = "Database Size", Value = "5 GB" });
        }

        public void BuildBandwidthFeature()
        {
            _plan.AddFeature(new Feature() { Title = "Bandwidth", Value = "10 GB" });
        }

        public void BuildSslFeature()
        {
            _plan.AddFeature(new Feature() { Title = "SSL", Value = "Not Free" });
        }

        public Plan GetPlan()
        {
            return _plan;
        }
    }
}
