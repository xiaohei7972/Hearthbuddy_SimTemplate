using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：2 攻击力：2 生命值：3
	//Silvermoon Farstrider
	//银月城远行者
	//<b>Battlecry:</b> Give allArcane spells in your hand<b>Spell Damage +1</b>.
	//<b>战吼：</b>使你手牌中所有奥术法术牌获得<b>法术伤害+1</b>。
	class Sim_RLK_826 : SimTemplate
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

			}

		}
		
	}
}
