using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_092 : SimTemplate //* Medivh's Valet
	{
		//Battlecry: If you control a Secret, deal 3 damage.
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(p.ownSecretsIDList.Count>=1)
            {
            	if (target != null) p.minionGetDamageOrHeal(target, 3);
            } 
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE, 1),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET, 1),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET, 1),
            };
        }
	}
}