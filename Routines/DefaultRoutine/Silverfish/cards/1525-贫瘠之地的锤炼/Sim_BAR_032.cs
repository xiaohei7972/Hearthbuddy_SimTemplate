using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_032 : SimTemplate //* 穿刺射击 Piercing Shot
	{
        //Deal $6 damage to a minion. Excess damage hits the enemy hero.
        //对一个随从造成$6点伤害，超过目标生命值的伤害会命中敌方英雄。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target == null) return;
            int dmg = p.getSpellDamageDamage(6);
            int lastDmg = target.Hp > dmg ? 0 : dmg - target.Hp;
            p.minionGetDamageOrHeal(target, dmg);
            p.minionGetDamageOrHeal(p.enemyHero, lastDmg);
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}
