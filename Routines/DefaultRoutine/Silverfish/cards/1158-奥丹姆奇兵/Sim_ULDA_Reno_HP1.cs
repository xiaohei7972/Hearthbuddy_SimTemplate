using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_Reno_HP1 : SimTemplate //* 业余法师 Amateur Mage
	{
		//<b>Hero Power</b>Deal $1 damage.<b>Combo:</b> $2 instead.
		//<b>英雄技能</b>造成$1点伤害。<b>连击：</b>改为造成$2点伤害。
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(1) : p.getEnemyHeroPowerDamage(1);
            p.minionGetDamageOrHeal(target, dmg);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
