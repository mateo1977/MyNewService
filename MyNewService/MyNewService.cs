using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyNewService
{
    public partial class MyNewService : ServiceBase
    {
        public MyNewService()
        {
            InitializeComponent();
            eventLog1 = new System.Diagnostics.EventLog();
            if(!System.Diagnostics.EventLog.Exists("MySource"))
            {

                System.Diagnostics.EventLog.CreateEventSource("MySource","MyNewLog");

            }

            eventLog1.Source="Mysource";
            eventLog1.Log="MyNewLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("In OnStart");
        }

        protected override void OnStop()
        {
        }
    }
}
