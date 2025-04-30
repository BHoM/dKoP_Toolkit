using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class ProjectTeam : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual ContactDetails Client { get; set; } = new ContactDetails();

        public virtual ContactDetails Architect { get; set; } = new ContactDetails();

        public virtual ContactDetails StructuralEngineer { get; set; } = new ContactDetails();

        public virtual ContactDetails SeriveEngineer { get; set; } = new ContactDetails();

        /***************************************************/
    }
}
