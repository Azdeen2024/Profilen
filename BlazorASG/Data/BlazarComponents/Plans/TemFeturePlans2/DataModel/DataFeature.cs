using BlazorASG.Data.BlazarComponents.Plans.TemFeturePlans2.Model;
 
namespace BlazorASG.Data.BlazarComponents.Plans.TemFeturePlans2.DataModel
{
    public class DataFeature
    {
     public List<PlanComponent> planComponent =new List<PlanComponent>()

        {
            new PlanComponent()
            {

            Id = "COMP001",
            Name = "Premium Plan",
            Description = "Comprehensive plan for technical and control services.",
            Status = "Active",
            IsAuth = true,
            IsMySelf = false,
            IdCategory = "CATEGORY001",
            ListservicesTechnicalAndModels = new List<TypeServicesTechnicalAndModel>
            {
                new TypeServicesTechnicalAndModel
                {
                    Id = "TS001",
                    Name = "Server Maintenance",
                    Description = "Ensure servers are running optimally.",
                    Status = "Active",
                    IsAuth = true,
                    IsMySelf = false,
                    ListServices = new List<string> { "Backup Service", "Performance Monitoring", "Error Reporting" }
                },
                new TypeServicesTechnicalAndModel
                {
                    Id = "TS002",
                    Name = "Cloud Integration",
                    Description = "Integrate with cloud platforms.",
                    Status = "Active",
                    IsAuth = false,
                    IsMySelf = true,
                    ListServices = new List<string> { "AWS Support", "Azure Setup", "Google Cloud Management" }
                }
            },
            serviceTextsAndSounds = new List<TypeServiceTextsAndSound>
            {
                new TypeServiceTextsAndSound
                {
                    Id = "CTRL001",
                    Name = "Audio Management",
                    Description = "Control audio playback and settings.",
                    Status = "Active",
                    IsAuth = true,
                    IsMySelf = false,
                    MaxCount = 5
                },
                new TypeServiceTextsAndSound
                {
                    Id = "CTRL002",
                    Name = "Text Editing",
                    Description = "Advanced text formatting and editing.",
                    Status = "Inactive",
                    IsAuth = false,
                    IsMySelf = true,
                    MaxCount = 10
                }
            }
        }



      };
        }
}

          

       
           
            
           
         
         
 

