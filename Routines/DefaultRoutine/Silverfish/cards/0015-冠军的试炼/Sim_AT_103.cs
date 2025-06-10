using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_103 : SimTemplate //* 北海海怪 North Sea Kraken
//<b>Battlecry:</b> Deal 4 damage.
//<b>战吼：</b>造成4点伤害。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int dmg = 4;
            p.minionGetDamageOrHeal(target, dmg);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}