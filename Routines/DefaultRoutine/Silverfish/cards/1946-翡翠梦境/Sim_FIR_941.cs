using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：7
	//Searing Reflection
	//烧灼映像
	//Draw a minion. Summon an 8/8 copy of it with <b>Divine Shield</b>.
	//抽一张随从牌，召唤一个它的8/8并具有<b>圣盾</b>的复制。
	class Sim_FIR_941 : SimTemplate
	{
		// 偷懒写法
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_110);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;

			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			// CardDB.Card kid = p.owncards[p.owncards.Count - 1].card;
			p.callKid(kid, pos, ownplay);
			Minion Summons = p.ownMinions[pos - 1];
			Summons.Angr = 8;
			Summons.Hp = 8;
			Summons.maxHp = 8;
			Summons.divineshild = true;

		}

	}
}
