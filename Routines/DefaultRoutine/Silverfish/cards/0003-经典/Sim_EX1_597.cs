using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_597 : SimTemplate //* 小鬼召唤师 Imp Master
	{
		//[x]At the end of your turn, deal1 damage to this minion and summon a 1/1 Imp.
		//在你的回合结束时，对该随从造成1点伤害，并召唤一个1/1的小鬼。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_598);//imp

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int posi = triggerEffectMinion.zonepos;
                if (triggerEffectMinion.Hp == 1) posi--;
                p.minionGetDamageOrHeal(triggerEffectMinion, 1);
                p.callKid(kid, posi, triggerEffectMinion.own);
                triggerEffectMinion.stealth = false;
            }
        }

	}
}