using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class UserProfile
    {
        partial void TotalAchievementPoints_Compute(ref int? result)
        {
            Random rnd = new Random();
            result = 10 * rnd.Next(1, 5);
            // Set result to the desired field value

        }
    }
}
