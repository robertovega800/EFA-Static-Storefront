using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public enum ExperienceRequired
    {
        Zero_To_Two = 1,
        Two_To_Four,
        Four_Or_More
    }
    public class DevTeam
    {
        public int DevTeamId { get; set; }
        public string DevTeamName { get; set; }
        public ExperienceRequired YearsOfExperience { get; set; }

        public DevTeam() { }

        public DevTeam(int devTeamId, string devTeamName, ExperienceRequired years)
        {
            DevTeamId = devTeamId;
            DevTeamName = devTeamName;
            YearsOfExperience = years;
        }
    }
}
