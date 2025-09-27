using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 巫妖王 费用：1 攻击力：0 生命值：2
    //Bloated Leech
    //饱胀水蛭
    //[x]At the end of your turn, yourhero steals @ Health fromthe lowest Health enemy.
    //在你的回合结束时，你的英雄会从生命值最低的敌人处偷取@点生命值。
    class Sim_EDR_810t : SimTemplate
    {
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                Minion target = null;
                List<Minion> minions = new List<Minion>(triggerEffectMinion.own ? p.enemyMinions : p.ownMinions);
                if (triggerEffectMinion.own) minions.Add(p.enemyHero);
                else minions.Add(p.ownHero);

                target = p.searchRandomMinion(minions, searchmode.searchLowestHP);
                // p.minionSetLifetoX(target, target.Hp - triggerEffectMinion.handcard.card.TAG_SCRIPT_DATA_NUM_1);
                //TAG_SCRIPT_DATA_NUM_1是一般炉石科技区里说的tag2,里面记录这卡会用到的数值
                if (target != null)
                {
                    p.minionGetBuffed(target, 0, -Math.Max(triggerEffectMinion.handcard.card.TAG_SCRIPT_DATA_NUM_1,target.Hp ));
                    p.minionGetBuffed(triggerEffectMinion.own ? p.ownHero : p.enemyHero, 0, triggerEffectMinion.handcard.card.TAG_SCRIPT_DATA_NUM_1);
                }
            }
        }

    }
}
