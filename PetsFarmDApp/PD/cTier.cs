using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsFarm.PD
{
    class cPet
    {
        public String nickName;

        public cPet(String _nickName)
        {
            nickName = _nickName;
        }

        public virtual String doVoice()
        {
            return nickName + ": ";
        }
    }
}
