using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_321 : SimTemplate //* 荣耀追逐者 glorychaser
	{
		//在你使用一张<b>嘲讽</b>随从牌后，抽一张牌。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.MOB && wasOwnCard == triggerEffectMinion.own && hc.card.tank)
            {
                p.drawACard(CardDB.cardIDEnum.None, wasOwnCard);
            }

        }
		
	}
}
