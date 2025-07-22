using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_696 : SimTemplate //* 衰变 Devolve
//Transform all enemy minions into random ones that cost (1) less.
//随机将所有敌方随从变形成为法力值消耗减少（1）点的随从。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
            foreach (Minion m in temp)
            {
                p.minionTransform(m, p.getRandomCardForManaMinion(m.handcard.card.cost - 1));
            }
        }
    }
}