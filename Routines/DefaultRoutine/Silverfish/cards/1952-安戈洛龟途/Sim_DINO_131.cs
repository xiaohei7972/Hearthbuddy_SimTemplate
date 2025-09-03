using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：6 攻击力：2 生命值：2
	//Possessed Animancer
	//着魔的动物术师
	//[x]<b>Deathrattle:</b> Summon arandom Beast from yourdeck. Give it <b>Lifesteal</b>.
	//<b>亡语：</b>随机从你的牌库中召唤一只野兽。使其获得<b>吸血</b>。
	class Sim_DINO_131 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
		{
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				// 招募野兽
				if (deckMinion.type == CardDB.cardtype.MOB && RaceUtils.MinionBelongsToRace(deckMinion.races, CardDB.Race.PET))
				{
					int pos = m.own ? p.ownMinions.Count : p.enemyMinions.Count;
					p.callKid(deckMinion, pos, m.own);
					break;
				}
			}
		}

	}
}
