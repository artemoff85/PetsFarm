using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.PD
{
    class cDog:cPet
    {
        public cDog(String _nickName)
            :base(_nickName)
        {

        }

        public override String doVoice()
        {
            return base.doVoice() + "Wow!";
        }
    }
}
