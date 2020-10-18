﻿using runlog2021api.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace runlog2021api.Models.DataManager
{
    public class RunManager : IDataRepository<Run>
    {
        readonly RunContext _runContext;
        public RunManager(RunContext context)
        {
            _runContext = context;
        }
        public IEnumerable<Run> GetAll()
        {
            return _runContext.Runs.ToList();
        }
        public Run Get(long id)
        {
            return _runContext.Runs
                  .FirstOrDefault(r => r.RunId == id);
        }
        public void Add(Run entity)
        {
            _runContext.Runs.Add(entity);
            _runContext.SaveChanges();
        }
        public void Update(Run run, Run entity)
        {
            run.Date = entity.Date;
            run.Duration = entity.Duration;
            run.Length = entity.Length;
            run.Pace = entity.Pace;
            _runContext.SaveChanges();
        }
        public void Delete(Run run)
        {
            _runContext.Runs.Remove(run);
            _runContext.SaveChanges();
        }
    }
}