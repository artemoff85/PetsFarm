using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsFarm.PD
{
    class cDog:cPet
    {
        public cDog(String _nickName)
            :base(_nickName)
        {
            //iPetType = 2;
            sPetType = "d";
        }

        public override String doVoice()
        {
            return base.doVoice() + "Wow!";
        }
    }
}
