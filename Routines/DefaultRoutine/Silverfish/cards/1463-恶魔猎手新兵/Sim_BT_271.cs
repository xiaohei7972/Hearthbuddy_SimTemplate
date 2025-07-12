using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 恶魔猎手 费用：7 攻击力：5 耐久度：0
	//Flamereaper
	//斩炎
	//Also damages the minions next to whomever your hero_attacks.
	//同时对其攻击目标相邻的随从造成伤害。
	class Sim_BT_271 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_271);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)//英雄攻击
		{
			// 检查己方英雄是否装备了“斩炎”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.BT_271)
			{ 
				   //TODO:还没想好攻击相邻随从
			}

		}

	}
}
