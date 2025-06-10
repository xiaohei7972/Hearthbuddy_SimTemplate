using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_036 : SimTemplate //* 阿努巴拉克 Anub'arak
//<b>Deathrattle:</b> Return this to your hand and summon a 4/4 Nerubian.
//<b>亡语：</b>将该随从移回你的手牌，召唤一个4/4的蛛魔。 
	{
		
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.FP1_007t);

        public override void onDeathrattle(Playfield p, Minion m)
        {
			p.minionReturnToHand(m, m.own, 0);
            p.callKid(kid, m.zonepos - 1, m.own);		
        }
	}
}