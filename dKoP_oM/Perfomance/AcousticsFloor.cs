using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class AcousticsFloor
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual AirborneSoundInsulation AirborneSoundInsulation { get; set; } = new AirborneSoundInsulation();

        public virtual ImpactSoundInsulation ImpactSoundInsulation { get; set; } = new ImpactSoundInsulation();

        /***************************************************/
    }
}
