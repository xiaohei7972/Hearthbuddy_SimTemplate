using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_131 : SimTemplate //* 绿色凝胶怪 Green Jelly
//At the end of your turn, summon a 1/2 Ooze with_<b>Taunt</b>.
//在你的回合结束时，召唤一个1/2并具有<b>嘲讽</b>的软泥怪。 
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_131t1);


        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int posi = triggerEffectMinion.zonepos;

                p.callKid(kid, posi, triggerEffectMinion.own);
            }
        }

	}
}