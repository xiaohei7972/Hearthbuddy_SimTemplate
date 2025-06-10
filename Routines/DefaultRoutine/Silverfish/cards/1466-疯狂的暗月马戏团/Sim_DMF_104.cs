using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_104 : SimTemplate //* 华丽谢幕 Grand Finale
	{
		//Summon an 8/8 Elemental. Repeat for each Elemental you played last turn.
		//召唤一个8/8的元素。你在上个回合每使用一张元素牌，重复一次。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_104t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);
		}
	}
}
