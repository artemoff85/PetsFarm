using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsFarm.PD
{
    class cCat:cPet
    {
        public cCat(cFarm _farmOwner, int _col, int _row, String _nickName)
            :base(_farmOwner, _col, _row, _nickName)
        {
            sPetType = "k";
        }

        public override String doVoice()
        {
            return base.doVoice() + "Mawoo!";
        }
    }
}
