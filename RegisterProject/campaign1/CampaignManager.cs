using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterProject.campaign1
{
    public class CampaignManager : ICampaginService
    {
        public List<Campaign> campaigns;
        public CampaignManager()
        {
            campaigns = new List<Campaign>();
        }
        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
        }
        public void Delete(Campaign campaign)
        {
            campaigns.Remove(campaign);
        }
        public void Update(Campaign campaign)
        {
            var entity=campaigns.Where(c => c.Id.Equals(campaign.Id)).SingleOrDefault();
            entity.rate = campaign.rate;
            entity.name = campaign.name;
        }
    }
}
