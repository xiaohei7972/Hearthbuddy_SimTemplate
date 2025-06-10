using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA16_4 : SimTemplate //* 回响之锣 Reverberating Gong
//Destroy your opponent's weapon.
//摧毁你对手的武器。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_WEAPON_EQUIPPED),
            };
        }
	}
}
