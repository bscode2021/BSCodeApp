using BSCodeAPI.Data;
using BSCodeAPI.Services.Interface;
using BSCodeModels_Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BSCodeAPI.Services
{
    public class TrainerService : ITrainerService
    {
        private BSCodeDbContext _bSCodeDb;

        public TrainerService(BSCodeDbContext bSCodeDb)
        {
            _bSCodeDb = bSCodeDb;
        }

        public bool Add(Trainer trainer)
        {
            _bSCodeDb.Trainers.Add(trainer); 
            int res = _bSCodeDb.SaveChanges();
            return res > 0;
        }

        public bool Delete(Guid id)
        {
            Trainer trainer  = _bSCodeDb.Trainers.FirstOrDefault(x => x.ID == id);
            _bSCodeDb.Trainers.Remove(trainer);
            int res = _bSCodeDb.SaveChanges();
            return res > 0;
        }

        public List<Trainer> Get()
        {
            return _bSCodeDb.Trainers.ToList();
        }

        public Trainer Get(Guid id)
        {
            return _bSCodeDb.Trainers.FirstOrDefault(x => x.ID == id);
        }

        public Trainer Update(Trainer trainer)
        {
            Trainer updatedTrainer =  _bSCodeDb.Trainers.Update(trainer).Entity;
            _bSCodeDb.SaveChanges();
            return updatedTrainer;
        }
    }
}
