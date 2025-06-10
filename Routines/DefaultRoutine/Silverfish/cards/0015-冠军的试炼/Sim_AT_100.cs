using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_100 : SimTemplate //* 白银之手教官 Silver Hand Regent
//<b>Inspire:</b> Summon a 1/1 Silver Hand Recruit.
//<b>激励：</b>召唤一个1/1的白银之手新兵。 
	{
		
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t);
		
		public override void onInspire(Playfield p, Minion m, bool own)
        {
            if (m.own == own) p.callKid(kid, m.zonepos, own);
        }
	}
}