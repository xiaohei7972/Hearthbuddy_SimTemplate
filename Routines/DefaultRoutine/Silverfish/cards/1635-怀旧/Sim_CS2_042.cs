using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_042 : SimTemplate //* 火元素 Fire Elemental
    {
        //<b>Battlecry:</b> Deal 4 damage.
        //<b>战吼：</b>造成4点伤害。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int dmg = 4;
            p.minionGetDamageOrHeal(target, dmg);
           
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}