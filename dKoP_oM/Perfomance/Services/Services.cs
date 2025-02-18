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

        public virtual Electrical Electrical { get; set; } = new Electrical();

        public virtual Data Data { get; set; } = new Data();

        public virtual Heating Heating { get; set; } = new Heating();

        public virtual Water Water { get; set; } = new Water();

        public virtual Drainage Drainage { get; set; } = new Drainage();

        public virtual Gas Gas { get; set; } = new Gas();

        public virtual Ventilation Ventilation { get; set; } = new Ventilation();

        public virtual bool ServicesIntegrationConfirmation { get; set; }

        /***************************************************/
    }
}