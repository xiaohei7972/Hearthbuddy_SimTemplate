using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_032 : SimTemplate //* 走私商贩 Shady Dealer
//<b>Battlecry:</b> If you have a Pirate, gain +1/+1.
//<b>战吼：</b>如果你控制任何海盗，便获得+1/+1。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PIRATE)
                {
                    p.minionGetBuffed(own, 1, 1);
					break;
                }
            }
        }
    }
}