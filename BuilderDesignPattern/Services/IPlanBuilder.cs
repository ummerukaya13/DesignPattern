using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderDesignPatternDemo.Models;

namespace BuilderDesignPatternDemo.Services
{
    //Builder Interface: Declares the steps required to build the product
    public interface IPlanBuilder
    {
        void BuildDiskSpaceFeature();

        void BuildDatabaseFeature();

        void BuildBandwidthFeature();

        void BuildSslFeature();

        Plan GetPlan();
    }
}
