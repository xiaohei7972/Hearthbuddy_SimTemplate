namespace HREngine.Bots
{
	//* 沙漠之矛 Desert Spear
	//After your hero attacks, summon a 1/1 Locust with <b>Rush</b>.
	//在你的英雄攻击后，召唤一只1/1并具有<b>突袭</b>的蝗虫。
	class Sim_ULD_430 : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_430);
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_430t);

		// public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		// {
		// 	p.equipWeapon(weapon, ownplay);
		// }

		public override void afterHeroattack(Playfield p, Minion own, Minion target)//英雄攻击
		{
			// 检查己方英雄是否装备了“沙漠之矛”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.ULD_430)
			{
				// 获取位置	
				int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
				// 召唤蝗虫
				p.callKid(kid, pos, own.own);
			}
		}

	}
}