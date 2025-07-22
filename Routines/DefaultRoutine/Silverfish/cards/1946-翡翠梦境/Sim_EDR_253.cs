using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 圣骑士 费用：4 攻击力：4 耐久度：0
	//Ursine Maul
	//巨熊之槌
	//After your hero attacks, draw your highest Cost_card.
	//在你的英雄攻击后，抽取你法力值消耗最高的牌。
	class Sim_EDR_253 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_253);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)//英雄攻击
		{
			// 检查己方英雄是否装备了“巨熊之槌”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.EDR_253)
			{
				p.drawACard(CardDB.cardIDEnum.None, own.own);
			}
		}

	}
}
