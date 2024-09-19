
using BuilderDesignPatternDemo.Enums;
using BuilderDesignPatternDemo.Factories;
using BuilderDesignPatternDemo.Models;
using BuilderDesignPatternDemo.Services;

using Microsoft.AspNetCore.Mvc;

namespace BuilderDesignPatternDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlanDirector _director;
        private readonly IPlanBuilderFactory _planBuilderFactory;

        public HomeController(IPlanDirector director,
            IPlanBuilderFactory planBuilderFactory)
        {
            _director = director;
            _planBuilderFactory = planBuilderFactory;
        }

        public IActionResult Index()
        {
            PricingPlansModel model = new PricingPlansModel();

            //using factory pattern and with using director class
            model.BasicPlan = _planBuilderFactory.BuildPlan(PlanType.Basic);
            model.EnterprisePlan = _planBuilderFactory.BuildPlan(PlanType.Enterprise);
            model.CustomPlan = _planBuilderFactory.BuildPlan(PlanType.Custom);

            //// Build Basic Plan

            //var basicPlanBuilder = new BasicPlanBuilder();
            //_director.SetPlanBuilder(basicPlanBuilder);
            //_director.BuildBasicPlan();
            //model.BasicPlan = basicPlanBuilder.GetPlan();

            //// Build Enterprise Plan 

            //var enterprisePlanBuilder = new EnterprisePlanBuilder();
            //_director.SetPlanBuilder(enterprisePlanBuilder);
            //_director.BuildEnterprisePlan();
            //model.EnterprisePlan = enterprisePlanBuilder.GetPlan();


            //// Build Custom Plan 

            //var customPlanBuilder = new BasicPlanBuilder();
            //customPlanBuilder.BuildDiskSpaceFeature();
            //customPlanBuilder.BuildBandwidthFeature();
            //model.CustomPlan = customPlanBuilder.GetPlan();

            return View(model);
        }
    }
}
