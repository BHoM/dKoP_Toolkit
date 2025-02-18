using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class Documentation : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string ServiceLifePlanning { get; set; } = "";

        public virtual string TransportationAndStorage { get; set; } = "";

        public virtual string ErectionAndInstallation { get; set; } = "";

        public virtual string MoistureManagement { get; set; } = "";

        /***************************************************/
    }
}