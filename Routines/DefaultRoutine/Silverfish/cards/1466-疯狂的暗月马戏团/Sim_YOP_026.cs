using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_026 : SimTemplate //* 树木生长 Arbor Up
	{
		//Summon two 2/2 Treants. Give your minions +2/+1.
		//召唤两个2/2的树人。使你的随从获得+2/+1。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_061t2);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);
			p.callKid(kid, pos, ownplay);
			p.allMinionOfASideGetBuffed(ownplay, 2, 1);
		}
	}
}
