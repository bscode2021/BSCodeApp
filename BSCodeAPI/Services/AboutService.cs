using BSCodeAPI.Data;
using BSCodeAPI.Services.Interface;
using BSCodeModels_Lib;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSCodeAPI.Services
{
    public class AboutService : IAboutService
    {
        private BSCodeDbContext bSCodeDb;

        public AboutService(BSCodeDbContext bSCodeDb)
        {
            this.bSCodeDb = bSCodeDb ?? throw new ArgumentNullException(nameof(bSCodeDb));
        }

        public bool Add(About about)
        {
            About _about = bSCodeDb.Abouts.FirstOrDefault();
            if (_about.ID == Guid.Empty)
            {
                bSCodeDb.Abouts.Add(about);
            }
            int res = bSCodeDb.SaveChanges();
            return res > 0;
        }

        public bool Delete(Guid id)
        {
            About proj = bSCodeDb.Abouts.FirstOrDefault(x => x.ID == id);
            bSCodeDb.Abouts.Remove(proj);
            int res = bSCodeDb.SaveChanges();
            return res > 0;
        }

        public About Get()
        {
            return bSCodeDb.Abouts.FirstOrDefault();
        }

        public About Update(About about)
        {
            EntityEntry<About> test = bSCodeDb.Abouts.Update(about);
            bSCodeDb.SaveChanges();
            return test.Entity;
        }
    }
}
