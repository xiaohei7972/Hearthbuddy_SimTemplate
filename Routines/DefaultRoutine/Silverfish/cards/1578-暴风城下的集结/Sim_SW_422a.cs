using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_422a : SimTemplate //* 新生幼苗 New Growth
	{
		//Summon a 2/2 Treant.
		//召唤一个2/2的树人。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_422t);//panther

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);

		}
	}
}
