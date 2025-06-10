using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_407 : SimTemplate //* 雷云元素 Thunderhead
//[x]After you play a card with<b>Overload</b>, summon two1/1 Sparks with <b>Rush</b>.
//在你使用一张<b>过载</b>牌后，召唤两个1/1并具有<b>突袭</b>的“火花”。 
	{
		

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (wasOwnCard == triggerEffectMinion.own && hc.card.overload > 0)
            {
                int pos = (wasOwnCard) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(p.getRandomCardForManaMinion(1), pos, wasOwnCard);
				p.callKid(p.getRandomCardForManaMinion(1), pos -1, wasOwnCard);
            }
        }
    }
}