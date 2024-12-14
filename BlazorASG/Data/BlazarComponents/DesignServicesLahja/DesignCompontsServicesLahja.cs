using BlazorASG.Data.BlazarComponents.Authentication;
using BlazorASG.Data.BlazarComponents.Plans.TemFeturePlans2.DataModel;
using BlazorASG.Data.BlazarComponents.Plans.TemFeturePlans2.Model;
using CardShopping.Web.VitsModel;

namespace BlazorASG.Data
{
    public class DesignCompontsServicesLahja
    {
        
        public AuthComponent Auth { get; set; }
        public List<PlanFeature> ListPlanFeture { get; set; }
        public List<PlanComponent> ListplanComponents { get; set;}

        public DesignCompontsServicesLahja()
        {


            DataFeature dataFeature = new DataFeature();
           ListplanComponents = dataFeature.planComponent;
            Auth=new AuthComponent();

        }
        public List<PlanComponent> planscompontt()
        {
            DataFeature dataFeature = new DataFeature();
            return dataFeature.planComponent;
        }

    }
}
