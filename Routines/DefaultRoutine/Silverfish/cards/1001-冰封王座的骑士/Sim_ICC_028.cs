using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_028: SimTemplate //* 阳焰瓦格里 Sunborne Val'kyr
//<b>Battlecry:</b> Give adjacent minions +2 Health.
//<b>战吼：</b>使相邻的随从获得+2生命值。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.zonepos == own.zonepos - 1 || m.zonepos == own.zonepos + 1)
                {
                    p.minionGetBuffed(m, 0, 2);
                }
            }
        }
    }
}