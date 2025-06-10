using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_601 : SimTemplate //* 被遗忘者军官 forsakenlieutenant
	{
		//<b>潜行</b>。在你使用一张<b>亡语</b>随从牌后，变形成为它的2/2并具有<b>突袭</b>的复制。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_601e);
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.MOB && wasOwnCard == triggerEffectMinion.own && hc.card.deathrattle == true)
            {
                p.minionTransform(triggerEffectMinion, kid);
                p.minionGetRush(triggerEffectMinion);
            }
        }
		
	}
}
