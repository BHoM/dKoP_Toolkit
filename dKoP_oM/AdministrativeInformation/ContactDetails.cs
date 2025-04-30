using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class ContactDetails : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string Name { get; set; } = "";

        public virtual string Adress { get; set; } = "";

        public virtual string PhoneNumber { get; set; } = "";

        public virtual string Email { get; set; } = "";

        /***************************************************/
    }
}
