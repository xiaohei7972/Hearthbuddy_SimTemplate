using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_099t2 : SimTemplate //* 复活 Reanimation
	{
		//Summon an 8/8 Dragon with <b>Taunt</b>.
		//召唤一条8/8并具有<b>嘲讽</b>的龙。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_099t2t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);
		}
	}
}