using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOEA06_04 : SimTemplate //* 粉碎之击 Shattering Spree
//Destroy all Statues. For each destroyed, deal 1 damage.
//粉碎所有雕像。每摧毁一个雕像，便造成1点伤害。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
