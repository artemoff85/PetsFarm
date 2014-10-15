using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsFarm.PD
{
    class cCat:cPet
    {
        public cCat(String _nickName)
            :base(_nickName)
        {
            //iPetType = 1;
            sPetType = "k";
        }

        public override String doVoice()
        {
            return base.doVoice() + "Mawoo!";
        }
    }
}
