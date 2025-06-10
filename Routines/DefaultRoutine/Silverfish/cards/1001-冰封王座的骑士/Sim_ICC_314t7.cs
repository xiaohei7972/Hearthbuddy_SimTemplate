using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_314t7 : SimTemplate //* 反魔法护罩 Anti-Magic Shell
//Give your minions +2/+2 and "Can't be targeted by spells or Hero Powers."
//使你的所有随从获得+2/+2，且“无法成为法术或英雄技能的目标。” 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.allMinionOfASideGetBuffed(ownplay, 2, 2);

            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp) m.cantBeTargetedBySpellsOrHeroPowers = true;
        }
    }
}