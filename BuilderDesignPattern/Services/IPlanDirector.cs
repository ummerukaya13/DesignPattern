using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderDesignPatternDemo.Models;

namespace BuilderDesignPatternDemo.Services
{
    //Director (Optional): Oversees the building process and ensures that the steps are executed in a specific sequence.
    public interface IPlanDirector
    {
        void SetPlanBuilder(IPlanBuilder builder);

        void BuildBasicPlan();

        void BuildEnterprisePlan(); 
    }
}
