using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_600 : SimTemplate //* 恶魔伙伴 Demon Companion
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_600t3);
		//Summon a random Demon Companion.
		//随机召唤一个恶魔伙伴。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.callKid(kid, p.ownMinions.Count, ownplay);
		}

	}
}
