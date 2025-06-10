using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_234 : SimTemplate //* 夜色镇炼金师 Darkshire Alchemist
//<b>Battlecry:</b> Restore #5 Health.
//<b>战吼：</b>恢复#5点生命值。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int heal = (own.own) ? p.getMinionHeal(5) : p.getEnemyMinionHeal(5);
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -heal);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}