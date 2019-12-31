using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._6_Exer._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new WorkflowEngine();
            var workflow = new Workflow();

            workflow.RegisterActivity(new UploadVideo());
            workflow.RegisterActivity(new CallWebService());
            workflow.RegisterActivity(new SendEmail());
            engine.Run(workflow);

            Console.WriteLine("\n\n");
        }        
    }
}
