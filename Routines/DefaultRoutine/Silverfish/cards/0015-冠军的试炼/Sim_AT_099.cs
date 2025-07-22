using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_099 : SimTemplate //* 科多兽骑手 Kodorider
//<b>Inspire:</b> Summon a 3/5 War Kodo.
//<b>激励：</b>召唤一个3/5的作战科多兽。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_099t); 
		
		public override void onInspire(Playfield p, Minion m, bool own)
        {
            if (m.own == own) p.callKid(kid, m.zonepos, own);
        }
	}
}