using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_048 : SimTemplate //* 治疗波 Healing Wave
//Restore #7 Health. Reveal a minion in each deck. If yours costs more, Restore #14 instead.
//恢复#7点生命值。揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，则恢复#14点生命值。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int heal = (ownplay) ? p.getSpellHeal(7) : p.getEnemySpellHeal(7);
            p.minionGetDamageOrHeal(target, -heal);            
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}