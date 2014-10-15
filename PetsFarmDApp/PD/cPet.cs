using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsFarm.PD
{
    class cPet
    {
        private String nickName;
        //protected int iPetType;
        protected String sPetType;

        public cPet(String _nickName)
        {
            nickName = _nickName;
        }

        public String getPetSimbol()
        {
            return sPetType;
        }

        public virtual String doVoice()
        {
            return nickName + ": ";
        }
    }
}
