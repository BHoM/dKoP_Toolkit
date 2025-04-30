using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class PartyWallPerformance : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual Sustainability Sustainability { get; set; } = new Sustainability();

        public virtual Durability Durability { get; set; } = new Durability();

        public virtual AcousticsWallAndRoof Acoustics { get; set; } = new AcousticsWallAndRoof();

        public virtual Fire Fire { get; set; } = new Fire();

        public virtual ThermalPerformance ThermalPerformance { get; set; } = new ThermalPerformance();

        public virtual Loading Loading { get; set; } = new Loading();

        public virtual Services Services { get; set; } = new Services();

        public virtual FinishesWall Finishes { get; set; } = new FinishesWall();

        public virtual string AdditionalFeatures { get; set; } = "";
        /***************************************************/
    }
}