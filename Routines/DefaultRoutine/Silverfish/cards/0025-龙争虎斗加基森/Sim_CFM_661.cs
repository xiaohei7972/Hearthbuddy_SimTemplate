using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_661 : SimTemplate //* 缩小药水 Pint-Size Potion
//[x]Give all enemy minions-3 Attack this turn only.
//在本回合中，使所有敌方随从获得-3攻击力。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
            foreach (Minion m in temp)
            {
                p.minionGetTempBuff(m, -3, 0);
            }
        }
    }
}