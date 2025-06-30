using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 猎人 费用：3 攻击力：3 耐久度：0
	//Shepherd's Crook
	//牧人之杖
	//After your hero attacks, summon a 3/3 Sheep that's <b>Dormant</b> for 2 turns.
	//在你的英雄攻击后，召唤一只3/3并<b>休眠</b>2回合的羊。
	class Sim_EDR_416 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_416);
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_416t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“牧人之杖”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.EDR_416)
			{
				int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, own.own);
			}
		}

	}


}
