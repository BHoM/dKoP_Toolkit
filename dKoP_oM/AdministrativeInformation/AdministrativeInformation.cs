using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class AdministrativeInformation : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual Overview Overview { get; set; } = new Overview();

        public virtual CrossReference CrossReference { get; set; } = new CrossReference();

        public virtual ProjectIdentification ProjectIdentification { get; set; } = new ProjectIdentification();

        public virtual ProjectTeam ProjectTeam { get; set; } = new ProjectTeam();

        public virtual PartIdentification PartIdentification { get; set; } = new PartIdentification();

        public virtual ProductDetails ProductDetails { get; set; } = new ProductDetails();

        public virtual ManufacturerDetails ManufacturerDetails { get; set; } = new ManufacturerDetails();

        /***************************************************/
    }
}
