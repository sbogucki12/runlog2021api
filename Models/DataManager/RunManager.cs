using runlog2021api.Models.Repository;
using System.Collections.Generic;
using System.Linq;

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

        public void AddMany(List<Run> runs)
        {
            for (var i = 0; i < runs.Count; i++)
            {
                _runContext.Runs.Add(runs[i]);
            }

            _runContext.SaveChanges();
        }
        public void Update(Run run, Run entity)
        {
            run.Date = entity.Date;
            run.Duration = entity.Duration;
            run.Length = entity.Length;
            run.Pace = entity.Pace;
            run.SleepHours = entity.SleepHours;
            run.SleepToBedTime = entity.SleepToBedTime;
            run.SleepWakeTime = entity.SleepWakeTime;
            run.RunListenedTo = entity.RunListenedTo;
            run.Temperature = entity.Temperature;
            _runContext.SaveChanges();
        }
        public void Delete(Run run)
        {
            _runContext.Runs.Remove(run);
            _runContext.SaveChanges();
        }
    }
}
