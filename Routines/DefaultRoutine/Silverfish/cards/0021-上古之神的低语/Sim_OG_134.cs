using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_134 : SimTemplate //* 尤格-萨隆 Yogg-Saron, Hope's End
//<b>Battlecry:</b> Cast a random spell for each spell you've cast this game <i>(targets chosen randomly)</i>.
//<b>战吼：</b>在本局对战中，你每施放过一个法术，便随机施放一个法术<i>（目标随机而定）</i>。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                if (p.ownMinions.Count < p.enemyMinions.Count) p.evaluatePenality -= 15;
                else p.evaluatePenality -= 5;
                foreach (Minion m in p.ownMinions) m.Ready = false;
                foreach (Minion m in p.enemyMinions) m.frozen = true;
                p.ownHero.Hp += 7;
            }
        }
    }
}