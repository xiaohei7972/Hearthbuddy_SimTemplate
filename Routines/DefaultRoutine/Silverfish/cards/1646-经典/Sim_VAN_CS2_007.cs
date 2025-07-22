using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_007 : SimTemplate //* 治疗之触 Healing Touch
	{
		//Restore #8 Health.
		//恢复#8点生命值。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int heal = (ownplay) ? p.getSpellHeal(8) : p.getEnemySpellHeal(8);
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