using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_021 : SimTemplate //* 不稳定的暗影震爆 Unstable Shadow Blast
	{
        //[x]Deal $6 damage to aminion. Excess damagehits your hero.
        //对一个随从造成$6点伤害，超过目标生命值的伤害会命中你的英雄。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = p.getSpellDamageDamage(6);
            p.minionGetDamageOrHeal(target, dmg);
            if(target.Hp < 0)
            {
                p.minionGetDamageOrHeal(p.ownHero, -target.Hp);
            }
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}
