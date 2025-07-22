using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_088 : SimTemplate //* 瑞林的步枪 Rinling's Rifle
	{
		//After your hero attacks, <b>Discover</b> a <b>Secret</b> and cast it.
		//在你的英雄攻击后，<b>发现</b>一张<b>奥秘</b>牌并将其施放。
		CardDB.Card blaine = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_506);
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_088);
		public override void onHeroattack(Playfield p, Minion own, Minion target)//英雄攻击
		{
			if (p.ownSecretsIDList.Count >= 3)
			{
				return;
			}
			p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_289);
			p.evaluatePenality -= 20;
			return;
		}

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(card, ownplay);
		}

	}
}
