using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_063 : SimTemplate //圣剑扳手
	{
		// 在你的英雄攻击后，将一张“炸弹”牌洗入你的对手的牌库。
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_063);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(card, ownplay);

		}
	}
}