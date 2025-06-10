using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_075 : SimTemplate //* 船载火炮 Ship's Cannon
//[x]After you summon aPirate, deal 2 damageto a random enemy.
//在你召唤一个海盗后，随机对一个敌人造成2点伤害。 
    {

        

        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if ((TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.PIRATE && triggerEffectMinion.own == summonedMinion.own)
            {
                Minion target = null;

                if (triggerEffectMinion.own)
                {
                    target = p.getEnemyCharTargetForRandomSingleDamage(2);
                    p.evaluatePenality -= 10;
                }
                else
                {
                    target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); 
                    if (target == null) target = p.ownHero;
                }
                p.minionGetDamageOrHeal(target, 2, true);
            }
        }
    }
}
