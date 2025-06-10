using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_072 : SimTemplate //* 暗影打击装甲 Shadowboxer
//Whenever a minion is healed, deal 1 damage to a random enemy.
//每当一个随从获得治疗，便随机对一个敌人造成1点伤害。 
    {
        

        public override void onACharGotHealed(Playfield p, Minion triggerEffectMinion, int charsGotHealed)
        {
            Minion target = null;

            if (triggerEffectMinion.own)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(charsGotHealed);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); 
                if (target == null) target = p.ownHero;
            }
            p.minionGetDamageOrHeal(target, charsGotHealed, true);
        }
    }
}