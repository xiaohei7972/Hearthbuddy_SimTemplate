using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_207p : SimTemplate //* 神圣之触 holytouch
	{
        //<b>英雄技能</b> 恢复#5点生命值。每回合翻转。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int heal = 5;
            if (ownplay)
            {
                if (p.anzOwnAuchenaiSoulpriest > 0 || p.embracetheshadow > 0) heal = -heal;
                if (p.doublepriest >= 1) heal *= (2 * p.doublepriest);
            }
            else
            {
                if (p.anzEnemyAuchenaiSoulpriest >= 1) heal = -heal;
                if (p.enemydoublepriest >= 1) heal *= (2 * p.enemydoublepriest);
            }
            p.minionGetDamageOrHeal(target, -heal);
        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }

}
