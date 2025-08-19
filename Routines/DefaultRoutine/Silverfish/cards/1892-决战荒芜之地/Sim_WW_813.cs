using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 猎人 费用：4 攻击力：2 耐久度：0
	//Starshooter
	//明星手枪
	//After your hero attacks, get an Arcane Shot.
	//在你的英雄攻击后，获取一张奥术射击。
	class Sim_WW_813 : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_813); // 假设明星手枪的卡牌ID为 WW_813

		// public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		// {
		// 	p.equipWeapon(weapon, ownplay); // 装备明星手枪
		// }
		
		public override void afterHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“明星手枪”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.WW_813)
			{
				p.drawACard(CardDB.cardIDEnum.DS1_185, own.own, true); // 英雄攻击后，抽一张奥术射击
			}
		}

	}
}
