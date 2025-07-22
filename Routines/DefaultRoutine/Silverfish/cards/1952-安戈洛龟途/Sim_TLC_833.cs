using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 恶魔猎手 费用：3 攻击力：2 耐久度：0
	//Insect Claw
	//昆虫利爪
	//After your hero attacks, summon a 2/1 Grub with <b>Rush</b>.
	//在你的英雄攻击后，召唤一只2/1并具有<b>突袭</b>的异种虫幼体。
	class Sim_TLC_833 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_833);
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_903t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)//英雄攻击
		{
			// 检查己方英雄是否装备了“昆虫利爪”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.TLC_833)
			{
				// 获取位置
				int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
				// 召唤异种虫幼体
				p.callKid(kid, pos, own.own);
			}
		}

	}
}
