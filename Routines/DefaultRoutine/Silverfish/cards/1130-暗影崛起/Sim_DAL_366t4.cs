using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_366t4 : SimTemplate //* 叛变合约 Turncoat Contract
//Destroy a minion. It_deals its damage to adjacent minions.
//消灭一个随从。对其相邻的随从造成等同于其攻击力的伤害。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetDestroyed(target);
			
            if (target.Angr>0)
            {
                int dmg = target.Angr;
                List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
                foreach (Minion m in p.enemyMinions)
                {
                    if (m.zonepos + 1 == target.zonepos || m.zonepos-1 == target.zonepos)
                    {
                        /*int oldhp = m.Hp;
                        p.minionGetDamageOrHeal(m, dmg);
                        if (!target.silenced && (target.handcard.card.name == CardDB.cardName.waterelemental ||target.handcard.card.name == CardDB.cardName.snowchugger) && m.Hp < oldhp) m.frozen=true;
                        if (!target.silenced && m.Hp < oldhp && target.poisonous) p.minionGetDestroyed(m);*/
                        p.minionAttacksMinion(target, m, true);
                    }
                }

            }

		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}