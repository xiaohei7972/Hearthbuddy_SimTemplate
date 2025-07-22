using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_330 : SimTemplate //* 獠牙锥刃 Tuskpiercer
	{
        //[x]<b>Deathrattle:</b> Draw a<b>Deathrattle</b> minion.
        //<b>亡语：</b>抽一张<b>亡语</b>随从牌。
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_330);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onDeathrattle(Playfield p, Minion m)
		{
			foreach (var cardEntry in p.prozis.turnDeck)
			{
				CardDB.Card card = CardDB.Instance.getCardDataFromID(cardEntry.Key);
				if (card.deathrattle == true)
				{
					p.drawACard(cardEntry.Key, m.own);
					break;
				}
			}
		}

        // public override void onHeroattack(Playfield p, Minion own, Minion target)
        // {
        //     p.evaluatePenality -= 3;
        // }
    }
}
