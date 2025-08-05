using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：3 攻击力：3 生命值：4
	//Halduron Brightwing
	//哈杜伦·明翼
	//<b>Battlecry:</b> Give all Arcane spells in your hand and[x]deck <b>Spell Damage +1</b>.
	//<b>战吼：</b>使你手牌和牌库中所有奥术法术牌获得<b>法术伤害+1</b>。
	class Sim_RLK_820 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				foreach (Handmanager.Handcard handcard in p.owncards)
				{
					if (handcard.card.type == CardDB.cardtype.SPELL && handcard.card.SpellSchool == CardDB.SpellSchool.ARCANE)
					{
						handcard.card.spellpowervalue++;
					}
				}

				foreach (var item in p.prozis.turnDeck)
				{
					CardDB.Card card = CardDB.Instance.getCardDataFromID(item.Key);
					if (card.type == CardDB.cardtype.SPELL && card.SpellSchool == CardDB.SpellSchool.ARCANE)
					{
						card.spellpowervalue++;
					}
				}

			}

		}

	}
}
