using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：2 攻击力：2 生命值：2
	//Fossil Fanatic
	//化石狂热者
	//After your hero attacks, draw a Fel spell.	
	//在你的英雄攻击后，抽一张邪能法术牌。
	class Sim_TID_704 : SimTemplate
	{
		public override void onHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
		{
			if (triggerMinion.own == hero.own)
			{
				if (triggerMinion.own)
				{
					foreach (var item in p.prozis.turnDeck)
					{
						CardDB.Card card = CardDB.Instance.getCardDataFromID(item.Key);
						if (card.type == CardDB.cardtype.SPELL && card.SpellSchool == CardDB.SpellSchool.FEL)
						{
							p.drawACard(item.Key, triggerMinion.own);
							break;
						}

					}

				}
			}

		}


	}
}
