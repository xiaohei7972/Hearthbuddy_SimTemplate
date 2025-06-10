using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_233 : SimTemplate //* 剑盾猛攻 Sword and Board
	{
		//Deal $2 damage to a minion. Gain 2 Armor.
		//对一个随从造成$2点伤害。获得2点护甲值。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
