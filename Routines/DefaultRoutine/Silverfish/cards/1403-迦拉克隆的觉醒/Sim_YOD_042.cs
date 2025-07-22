using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOD_042 : SimTemplate //* 莱登之拳 The Fist of Ra-den
	{
		//[x]After you cast a spell,summon a <b>Legendary</b>minion of that Cost.Lose 1 Durability.
		//在你施放一个法术后，召唤一个法力值消耗相同的<b>传说</b>随从。失去1点耐久度。
		CardDB.Card wcard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.YOD_042);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(wcard, ownplay);
		}
		public override void onCardWasPlayed(Playfield p, CardDB.Card c, bool wasOwnCard, Minion triggerEffectMinion)
		{
			CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_121);
			if (wasOwnCard && c.type == CardDB.cardtype.SPELL)
			{
				p.callKid(kid, p.ownMinions.Count, wasOwnCard);
				p.lowerWeaponDurability(1, wasOwnCard);
			}
		}
	}
}
