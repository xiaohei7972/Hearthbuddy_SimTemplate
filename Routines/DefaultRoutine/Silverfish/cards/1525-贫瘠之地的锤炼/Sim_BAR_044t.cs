using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_044t : SimTemplate //* 闪电链（等级2） Chain Lightning (Rank 2)
	{
        //Deal $3 damage to a minion and a random adjacent one. <i>(Upgrades when you have 10 Mana.)</i>
        //对一个随从和随机一个相邻随从造成$3点伤害。<i>（当你有10点法力值时升级。）</i>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target == null) return;
            int dmg = p.getSpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
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
