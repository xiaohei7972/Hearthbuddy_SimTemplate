using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_244 : SimTemplate //* 图腾之力 Totemic Might
	{
		//Give your Totems +2_Health.
		//使你的图腾获得+2生命值。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion t in temp)
            {
                if (t.handcard.card.race == CardDB.Race.TOTEM) // if minion is a totem, buff it
                {
                    p.minionGetBuffed(t, 0, 2);
                }
            }
        }

    }
}
