using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_034t2 : SimTemplate //* 驯服野兽（等级3） Tame Beast (Rank 3)
	{
		//Summon a 6/6 Beast with <b>Rush</b>.
		//召唤一只6/6并具有<b>突袭</b>的野兽。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_034t5);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = p.ownMinions.Count;
			p.callKid(kid, pos + 1, ownplay);
		}					
		
	}
}
