using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS1h_001_H1 : SimTemplate //* 次级治疗术 Lesser Heal
//<b>Hero Power</b>Restore #2 Health.
//<b>英雄技能</b>恢复#2点生命值。 
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int heal = 2;
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
