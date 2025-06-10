using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_309 : SimTemplate //* 橡树的召唤 Oaken Summons
	{
        //Gain 6 Armor.<b>Recruit</b> a minion that costs (4) or less.
        //获得6点护甲值。<b>招募</b>一个法力值消耗小于或等于（4）的随从。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetArmor(p.ownHero, 6);
			// 遍历卡组
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				// 4费以下
				if (deckMinion.type == CardDB.cardtype.MOB && deckMinion.cost <= 4)
				{
					int pos = p.ownMinions.Count;
					p.callKid(deckMinion, pos, ownplay);
					if (deckMinion.cost == 4) p.evaluatePenality -= 20;
					break;
				}
			}
		}

    }
}
