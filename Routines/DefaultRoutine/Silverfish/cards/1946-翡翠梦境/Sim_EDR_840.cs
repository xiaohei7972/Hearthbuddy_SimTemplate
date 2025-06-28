using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：2
	//Grim Harvest
	//恐怖收割
	//Draw a card.Summon a random <b>Dormant</b> Dreadseed.
	//抽一张牌。随机召唤一个<b>休眠</b>的魔种。
	class Sim_EDR_840 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_840t1);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			p.callKid(kid, pos, ownplay);
		}

	}
}
