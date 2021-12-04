using BSCodeModels_Lib;
using System;
using System.Collections.Generic;

namespace BSCodeAPI.Services.Interface
{
    public interface ITrainerService
    {
        List<Trainer> Get();
        Trainer Get(Guid id);
        bool Add(Trainer trainer);
        Trainer Update(Trainer trainer);
        bool Delete(Guid id);
    }
}
