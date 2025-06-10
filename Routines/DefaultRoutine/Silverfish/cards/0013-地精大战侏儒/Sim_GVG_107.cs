using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_107 : SimTemplate //* 强化机器人 Enhance-o Mechano
//<b>Battlecry:</b> Give your other minions <b>Windfury</b>, <b>Taunt</b>, or <b>Divine Shield</b><i>(at random)</i>.
//<b>战吼：</b>随机使你的其他随从分别获得<b>风怒</b>，<b>嘲讽</b>，或者<b>圣盾</b>效果中的一种。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;

            foreach (Minion m in temp)
            {
                if (m.entitiyID == own.entitiyID) continue;
                if (!m.taunt)
                {
                    m.taunt = true;
                    if (m.own) p.anzOwnTaunt++;
                    else p.anzEnemyTaunt++;
                }
            }
        }
    }
}