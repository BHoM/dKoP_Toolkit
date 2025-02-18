using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class Buildup : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string PrimaryStructuralMaterial { get; set; } = "";

        public virtual string BuildupDescription { get; set; } = "";

        public virtual bool ExternalFinishesInstalledOffsite { get; set; }

        public virtual string ExternalComponentsInstalledOnSite { get; set; }

        public virtual bool InternalFinishesInstalledOffsite { get; set; }

        public virtual string InternalComponentsInstalledOnSite { get; set; }

        /***************************************************/
    }
}