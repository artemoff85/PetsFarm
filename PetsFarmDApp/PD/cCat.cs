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

        }

        public override String doVoice()
        {
            return base.doVoice() + "Mawoo!";
        }
    }
}
