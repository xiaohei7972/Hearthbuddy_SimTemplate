using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_053 : SimTemplate //* 戈霍恩之血 Blood of G'huun
	{
		//[x]<b>Taunt</b>At the end of your turn,summon a 5/5 copy of aminion in your deck.
		//<b>嘲讽</b>在你的回合结束时，召唤一个你牌库中的随从的5/5复制。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_187);//gnoll
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
