using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_132 : SimTemplate //* 屠龙者 Dragonslayer
//<b>Battlecry:</b> Deal 6 damage to a Dragon.
//<b>战吼：</b>对一条龙造成6点伤害。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null)
            {
				int dmg = 6;
				p.minionGetDamageOrHeal(target, dmg);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 24),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}