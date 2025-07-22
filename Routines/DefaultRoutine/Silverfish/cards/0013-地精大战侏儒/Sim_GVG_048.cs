using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_048 : SimTemplate //* 金刚刃牙兽 Metaltooth Leaper
//<b>Battlecry:</b> Give your other Mechs +2 Attack.
//<b>战吼：</b>使你的其他机械获得+2攻击力。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.entitiyID == own.entitiyID) continue;
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL)
                {
                    p.minionGetBuffed(m, 2, 0);
                }
            }
        }
    }
}