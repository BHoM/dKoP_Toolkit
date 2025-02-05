using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP.AdministrativeInformation
{
    public class ManufacturerDetails : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string ManufactureName { get; set; } = "";

        public virtual string ManufactureLocation { get; set; } = "";

        public virtual string ManufactureWebsite { get; set; } = "";

        public virtual string ContactTelephoneNumber { get; set; } = "";

        public virtual string ContactEmailAddress { get; set; } = "";

        public virtual string ISO9001Certificate { get; set; } = "";

        public virtual string ISO14001Certificate { get; set; } = "";

        public virtual string WebLinkToProductBrochure { get; set; } = "";

        //TODO:
        //Image - handle here as well as JsonSchema
        /***************************************************/
    }
}
