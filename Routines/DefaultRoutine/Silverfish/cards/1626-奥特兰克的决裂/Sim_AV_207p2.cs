using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_207p2 : SimTemplate //* 虚空之刺 voidspike
	{
        //<b>英雄技能</b> 造成$5点伤害。每回合翻转。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(5) : p.getEnemyHeroPowerDamage(5);
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
