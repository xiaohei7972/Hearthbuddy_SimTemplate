using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_604 : SimTemplate //* 强效治疗药水 Greater Healing Potion
//Restore #12 Health to a friendly character.
//为一个友方角色恢复#12点生命值。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int heal = (ownplay) ? p.getSpellHeal(12) : p.getEnemySpellHeal(12);
            p.minionGetDamageOrHeal(target, -heal);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
    }
}