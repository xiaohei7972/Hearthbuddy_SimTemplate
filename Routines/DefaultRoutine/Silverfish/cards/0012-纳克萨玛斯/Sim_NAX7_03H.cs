using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX7_03H : SimTemplate //* 重压打击 Unbalancing Strike
//<b>Hero Power</b>Deal 4 damage.
//<b>英雄技能</b>造成4点伤害。 
	{
		
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			int dmg = (ownplay) ? p.getHeroPowerDamage(4) : p.getEnemyHeroPowerDamage(4);
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