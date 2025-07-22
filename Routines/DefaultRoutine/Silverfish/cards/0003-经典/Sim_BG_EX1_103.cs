using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 中立 费用：3 攻击力：2 生命值：3
    //Coldlight Seer
    //寒光先知
    //<b>Battlecry:</b> Give your other Murlocs +2 Health.
    //<b>战吼：</b>使你的其他鱼人获得+2生命值。
    class Sim_BG_EX1_103 : SimTemplate
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> ownMinions = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in ownMinions)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MURLOC && own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 0, 2);
            }
        }

    }
}
