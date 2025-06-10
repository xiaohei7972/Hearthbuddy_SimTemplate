using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_245: SimTemplate //* 黑色卫士 Blackguard
//Whenever your hero is healed, deal that much damage to a random enemy minion.
//每当你的英雄获得治疗时，便随机对一个敌方随从造成等量的伤害。 
    {
        

        public override void onACharGotHealed(Playfield p, Minion triggerEffectMinion, int charsGotHealed)
        {
            int dmg = charsGotHealed;
            Minion target = null;
            if (triggerEffectMinion.own) target = p.getEnemyCharTargetForRandomSingleDamage(dmg, true);
            else target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); 
            if (target != null) p.minionGetDamageOrHeal(target, dmg);
        }
	}
}