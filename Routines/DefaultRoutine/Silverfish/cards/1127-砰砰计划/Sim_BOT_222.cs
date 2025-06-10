using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_222 : SimTemplate //* 灵魂炸弹 Spirit Bomb
	{
        //Deal $4 damage to a minion and your hero.
        //对一个随从和你的英雄各造成$4点伤害。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = p.getSpellDamageDamage(4);
            p.minionGetDamageOrHeal(target, dmg);
            p.minionGetDamageOrHeal(p.ownHero, dmg);
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
