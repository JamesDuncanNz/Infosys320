using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Person
    {
        partial void Person_Created()
        {
            this.UserProfile = new UserProfile();
            this.WhenCreated = DateTime.Now;
        }

        partial void DateOfBirth_Validate(EntityValidationResultsBuilder results)
        {
            if (this.DateOfBirth > DateTime.Today)
            {
                results.AddPropertyError("Your date of birth cannot be today");
            }
            // results.AddPropertyError("<Error-Message>");

        }
    }
}
