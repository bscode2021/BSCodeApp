using BSCodeModels_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSCodeAPI.Services.Interface
{
    public interface IAboutService
    {
        About Get();
        bool Add(About about);
        About Update(About about);
        bool Delete (Guid id);

    }
}
