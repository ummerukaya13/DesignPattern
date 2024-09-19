using BuilderDesignPatternDemo.Enums;
using BuilderDesignPatternDemo.Models;
using BuilderDesignPatternDemo.Services;

namespace BuilderDesignPatternDemo.Factories
{
    public interface IPlanBuilderFactory
    {
        Plan BuildPlan(PlanType planType);
    }
}
