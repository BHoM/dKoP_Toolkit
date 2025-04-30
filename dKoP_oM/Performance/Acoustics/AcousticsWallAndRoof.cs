using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class AcousticsWallAndRoof : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual AirborneSoundInsulation AirborneSoundInsulation { get; set; } = new AirborneSoundInsulation();

        /***************************************************/
    }
}
