using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class AdministrativeInformation : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual Overview Overview { get; set; }

        public virtual CrossReference CrossReference { get; set; }

        public virtual ProjectIdentification ProjectIdentification { get; set; }

        public virtual ProjectTeam ProjectTeam { get; set; }

        public virtual PartIdentification PartIdentification { get; set; }

        public virtual ProductDetails ProductDetails { get; set; }

        public virtual ManufacturerDetails ManufacturerDetails { get; set; }

        /***************************************************/
    }
}
