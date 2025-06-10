using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_450: SimTemplate //* 死亡幽魂 Death Revenant
//<b>Battlecry:</b> Gain +1/+1 for each damaged minion.
//<b>战吼：</b>每有一个受伤的随从，便获得+1/+1。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int gain = 0;
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.wounded) gain++;
            }
            if (gain >= 1) p.minionGetBuffed(own, gain, gain);
        }
    }
}