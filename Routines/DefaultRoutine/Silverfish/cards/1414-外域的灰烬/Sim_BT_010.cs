using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_010 : SimTemplate //* 邪鳍导航员 Felfin Navigator
	{
        //<b>Battlecry:</b> Give your other Murlocs +1/+1.
        //<b>战吼：</b>使你的其他鱼人获得+1/+1。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MURLOC && own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 1, 1);
            }
        }
    }
}
