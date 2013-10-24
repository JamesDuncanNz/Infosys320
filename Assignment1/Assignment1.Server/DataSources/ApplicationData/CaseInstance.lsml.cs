using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class CaseInstance
    {
        partial void CaseInstance_Created()
        {
            this.Tree = new Tree();
            this.VotesAgainst = 0;
            this.VotesFor = 0;           
            this.CreatedBy = this.Application.User.Name;
            this.WhenCreated = DateTime.Now;
        }
        
    }
}
