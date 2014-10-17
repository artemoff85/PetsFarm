using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsFarm.PD
{
    class cDog:cPet
    {
        public cDog(cFarm _farmOwner, int _col, int _row, String _nickName)
            :base(_farmOwner, _col, _row, _nickName)
        {
            sPetType = "d";
        }

        public override String doVoice()
        {
            return base.doVoice() + "Wow!";
        }
        protected override void BirthPet(int _col, int _row)
        {
            int i = farmOwner.getPetsCount();
            new cDog(farmOwner, _col, _row, "Doge" + i);
        }
    }
}
