using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_005 : SimTemplate //* 路障 Barricade
	{
		//Summon a 2/4 Guard with <b>Taunt</b>. If it's_your only minion, summon another.
		//召唤一个2/4并具有<b>嘲讽</b>的护卫。如果它是你唯一的一个随从，再召唤一个。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.YOP_005t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);
			if (p.ownMinions.Count == 0)
			{
				p.callKid(kid, pos, ownplay, false);
			}
			p.evaluatePenality -= 6;
		}
	}
}
