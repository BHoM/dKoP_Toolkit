using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace BH.oM.dKoP.AdministrativeInformation
{
    public class PartIdentification : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string BuildingReference { get; set; } = "";

        public virtual string ProjectUniquePartReference { get; set; } = "";

        /***************************************************/
    }
}
