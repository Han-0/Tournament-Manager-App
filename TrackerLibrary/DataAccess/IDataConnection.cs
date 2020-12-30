using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        Prize CreatePrize(Prize model);
        Person CreatePerson(Person model);
        TeamModel CreateTeam(TeamModel model);
        void createTournamet(Tournament model);
        List<TeamModel> GetTeam_All();
        List<Person> getPerson_All();
    }
}
