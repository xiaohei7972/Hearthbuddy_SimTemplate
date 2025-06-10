using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_018 : SimTemplate //* 幽光鱼竿 Underlight Angling Rod
	{
		//After your Hero attacks, add a random Murloc to your hand.
		//在你的英雄攻击后，随机将一张鱼人牌置入你的手牌。
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_018);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(card, ownplay);
		}
		public override void onHeroattack(Playfield p, Minion own, Minion target)//英雄攻击
		{
			p.drawACard(CardDB.cardIDEnum.CS2_168, own.own, true);
			//Helpfunctions.Instance.ErrorLog("鱼竿攻击，抽一条鱼");
			// 优先进攻
			if (p.mana == p.ownMaxMana)
			{
				p.evaluatePenality--;
			}
			return;
		}
	}
}
