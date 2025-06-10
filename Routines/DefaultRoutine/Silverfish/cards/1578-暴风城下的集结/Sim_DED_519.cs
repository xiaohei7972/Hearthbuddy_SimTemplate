using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_519 : SimTemplate //* 迪菲亚炮手 Defias Cannoneer
    {
        //在你的英雄攻击后，随机对一个敌人造成2点伤害，触发两次。
        //fter your hero attacks, deal 2 damage to a random enemy twice.
        public override void onHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
        {
            p.minionGetDamageOrHeal(p.getEnemyCharTargetForRandomSingleDamage(2), 2, true);
            //p.minionGetDamageOrHeal(target, 2, true);
            //p.minionGetDamageOrHeal(target, 2, true);            
        }

    }
}
