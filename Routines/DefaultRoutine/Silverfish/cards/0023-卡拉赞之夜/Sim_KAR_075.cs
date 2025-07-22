using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_075 : SimTemplate //* 月光林地传送门 Moonglade Portal
//Restore #6 Health. Summon a random6-Cost minion.
//恢复#6点生命值。随机召唤一个法力值消耗为（6）的随从。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int heal = (ownplay) ? p.getSpellHeal(6) : p.getEnemySpellHeal(6);
            p.minionGetDamageOrHeal(target, -heal);
			
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;			
            p.callKid(p.getRandomCardForManaMinion(6), pos, ownplay, false);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}