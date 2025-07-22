using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_076 : SimTemplate //* 鱼人骑士 Murloc Knight
//<b>Inspire:</b> Summon a random Murloc.
//<b>激励：</b>随机召唤一个鱼人。 
	{
		
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_050);

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				p.callKid(kid, m.zonepos, m.own);
			}
        }
	}
}