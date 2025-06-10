using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_829t2 : SimTemplate //* 虚空传送门 Nether Portal
//At the end of your turn, summon two 3/2 Imps.
//在你的回合结束时，召唤两个3/2的小鬼。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_829t3); 

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                p.callKid(kid, triggerEffectMinion.zonepos - 1, triggerEffectMinion.own); 
                p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own); 
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}