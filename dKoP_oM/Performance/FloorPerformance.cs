using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class FloorPerformance : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual Sustainability Sustainability { get; set; } = new Sustainability();

        public virtual Durability Durability { get; set; } = new Durability();

        public virtual AcousticsFloor Acoustics { get; set; } = new AcousticsFloor();

        public virtual Fire Fire { get; set; } = new Fire();

        public virtual Compartmentation Compartmentation { get; set; } = new Compartmentation();

        public virtual Loading Loading { get; set; } = new Loading();

        public virtual Vibration Vibration { get; set; } = new Vibration();

        public virtual Services Services { get; set; } = new Services();

        public virtual FinishesRoof Finishes { get; set; } = new FinishesRoof();

        public virtual string AdditionalFeatures { get; set; } = "";
        /***************************************************/
    }
}