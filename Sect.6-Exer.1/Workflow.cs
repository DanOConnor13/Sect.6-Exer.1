using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._6_Exer._1
{
    public class Workflow
    {
        private readonly List<IActivity> _tasks;

        public Workflow()
        {
            _tasks = new List<IActivity>();
        }

        public void RegisterActivity(IActivity activity)
        {
            _tasks.Add(activity);
        }

        public IEnumerable<IActivity> GetTasks()
        {
            return _tasks;
        }
    }
}
