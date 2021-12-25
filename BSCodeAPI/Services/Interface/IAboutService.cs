using BSCodeModels_Lib;
using System;

namespace BSCodeAPI.Services.Interface
{
    public interface IAboutService
    {
        About Get();
        bool Add(About about);
        About Update(About about);
        bool Delete(Guid id);

    }
}
