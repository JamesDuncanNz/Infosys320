using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {



        partial void CaseInstances_Updating(CaseInstance entity)
        {
            entity.LastUpdate = DateTime.Now;
        }

        partial void CaseComments_Updating(CaseComment entity)
        {
            entity.TimeofComment = DateTime.Now;
        }
    }
}
