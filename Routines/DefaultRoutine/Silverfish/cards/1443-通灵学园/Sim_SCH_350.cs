using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_350 : SimTemplate //* 魔杖窃贼 Wand Thief
	{
		//<b>Combo:</b> <b>Discover</b> a Mage_spell.
		//<b>连击：</b><b>发现</b>一张法师法术牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (p.cardsPlayedThisTurn >= 1)
			{
				CardDB.Card c;
				int count = 0;
				foreach (KeyValuePair<CardDB.cardIDEnum, int> cid in p.prozis.turnDeck)
				{
					c = CardDB.Instance.getCardDataFromID(cid.Key);
					for (int i = 0; i < cid.Value; i++)
					{
						p.drawACard(c.nameEN, true);
						count++;
						if (count > 1) break;
					}
					if (count > 1) break;
				}
			}
		}
	}
}
