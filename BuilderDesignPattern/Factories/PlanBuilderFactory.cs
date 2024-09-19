using BuilderDesignPatternDemo.Enums;
using BuilderDesignPatternDemo.Models;
using BuilderDesignPatternDemo.Services;
using System;

namespace BuilderDesignPatternDemo.Factories
{
    public class PlanBuilderFactory : IPlanBuilderFactory
    {
        public Plan BuildPlan(PlanType planType)
        {
            var builder = GetPlanBuilder(planType);

            if (planType == PlanType.Basic)
            {
                builder.BuildDiskSpaceFeature();
                builder.BuildBandwidthFeature();
                builder.BuildDatabaseFeature();
            }
            else if (planType == PlanType.Enterprise)
            {
                builder.BuildDiskSpaceFeature();
                builder.BuildBandwidthFeature();
                builder.BuildDatabaseFeature();
                builder.BuildSslFeature();
            }
            else if (planType == PlanType.Custom)
            {
                builder.BuildDiskSpaceFeature();
                builder.BuildBandwidthFeature();
            }
            return builder.GetPlan();
        }

        public IPlanBuilder GetPlanBuilder(PlanType planType)
        {
            return planType switch
            {
                PlanType.Basic => new BasicPlanBuilder(),
                PlanType.Enterprise => new EnterprisePlanBuilder(),
                PlanType.Custom => new BasicPlanBuilder(),
                _ => throw new ArgumentException("Invalid plan type", nameof(planType))
            };
        }
    }
}
