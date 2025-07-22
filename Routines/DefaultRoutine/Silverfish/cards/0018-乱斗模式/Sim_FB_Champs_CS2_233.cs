using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_CS2_233 : SimTemplate //* 剑刃乱舞 Blade Flurry
//Destroy your weapon and deal its damage to all enemies.
//摧毁你的武器，对所有敌人造成等同于其攻击力的伤害。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_WEAPON_EQUIPPED),
            };
        }
	}
}
