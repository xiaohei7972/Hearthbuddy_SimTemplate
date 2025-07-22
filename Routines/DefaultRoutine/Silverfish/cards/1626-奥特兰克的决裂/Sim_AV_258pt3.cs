using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_258pt3 : SimTemplate //* 火焰祈咒 fireinvocation
	{
		//<b>英雄技能</b> 对敌方英雄造成$6点伤害。每回合切换。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(6) : p.getEnemyHeroPowerDamage(6);
            if (target.isHero)
            {
                p.minionGetDamageOrHeal(target, dmg);
            }
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
