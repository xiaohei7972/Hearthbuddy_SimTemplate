using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_006 : SimTemplate //* 腐蚀吐息 Corrosive Breath
	{
        //[x]Deal $3 damage to aminion. If you're holdinga Dragon, it also hitsthe enemy hero.
        //对一个随从造成$3点伤害。如果你的手牌中有龙牌，还会命中敌方英雄。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
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
