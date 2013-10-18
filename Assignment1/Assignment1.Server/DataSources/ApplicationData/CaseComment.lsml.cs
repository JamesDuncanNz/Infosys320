using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class CaseComment
    {

        partial void CaseComment_Created()
        {
            this.TimeofComment = DateTime.Now;
        }
    }
}
