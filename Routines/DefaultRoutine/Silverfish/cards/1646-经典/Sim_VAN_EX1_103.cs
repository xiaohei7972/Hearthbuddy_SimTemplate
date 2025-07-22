using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_103 : SimTemplate //* 寒光先知 Coldlight Seer
	{
		//<b>Battlecry:</b> Give your other Murlocs +2 Health.
		//<b>战吼：</b>使你的其他鱼人获得+2生命值。
	
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MURLOC && own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 0, 2);
            }
        }
    }
}
