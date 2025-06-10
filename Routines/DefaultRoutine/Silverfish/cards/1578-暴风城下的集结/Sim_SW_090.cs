using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_090 : SimTemplate //* 纳斯雷兹姆之触 Touch of the Nathrezim
	{
        //[x]Deal $2 damage to aminion. If it dies, restore4 Health to your hero.
        //对一个随从造成$2点伤害。如果该随从死亡，则为你的英雄恢复4点生命值。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.ownHero.Hp >= 4) p.evaluatePenality += 20;
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            if (dmg >= target.Hp && !target.divineshild && !target.immune)
            {
                p.minionGetDamageOrHeal(p.ownHero, -3);
            }
            p.minionGetDamageOrHeal(target, dmg);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}
