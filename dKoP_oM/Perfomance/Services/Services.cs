using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class Services : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual Electrical Electrical { get; set; }

        public virtual Data Data { get; set; }

        public virtual Heating Heating { get; set; }

        public virtual Water Water { get; set; }

        public virtual Drainage Drainage { get; set; }

        public virtual Gas Gas { get; set; }

        public virtual Ventilation Ventilation { get; set; }

        public virtual bool ServicesIntegrationConfirmation { get; set; }

        /***************************************************/
    }
}