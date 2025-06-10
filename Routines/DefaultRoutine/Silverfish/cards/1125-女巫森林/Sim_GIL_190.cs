using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_190 : SimTemplate //* 夜鳞龙后 Nightscale Matriarch
//Whenever a friendly minion is healed, summon a 3/3_Whelp.
//每当一个友方随从获得治疗时，召唤一条3/3的雏龙。 
	{
		

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_190t); 
		
        public override void onAMinionGotHealedTrigger(Playfield p, Minion triggerEffectMinion, int minionsGotHealed)
        {
            for (int i = 0; i < minionsGotHealed; i++)
            {
				p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);	
            }
        }
    }
}