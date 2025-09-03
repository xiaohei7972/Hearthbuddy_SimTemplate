using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：7 攻击力：7 生命值：5
	//Therazane
	//塞拉赞恩
	//[x]<b>Taunt</b> <b>Deathrattle:</b> Double thestats of all Elementals inyour hand and deck.
	//<b>嘲讽</b>。<b>亡语：</b>使你手牌和牌库中的所有元素牌属性值翻倍。
	class Sim_DEEP_036 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
		{
			if (m.own)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.MOB && RaceUtils.MinionBelongsToRace(hc.card.races, CardDB.Race.ELEMENTAL))
					{
						hc.addattack += hc.card.Attack;
						hc.addHp += hc.card.Health;
						p.anzOwnExtraAngrHp += hc.card.Health + hc.card.Health;
					}
				}
				
				foreach (CardDB.Card card in p.ownDeck)
				{
					if (card.type == CardDB.cardtype.MOB && RaceUtils.MinionBelongsToRace(card.races, CardDB.Race.ELEMENTAL))
					{
						card.Attack += card.Attack;
						card.Health += card.Health;
					}
				}
			}
		}
	}
}
