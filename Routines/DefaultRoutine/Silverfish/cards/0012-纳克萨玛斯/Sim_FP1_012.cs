using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_012 : SimTemplate //* 淤泥喷射者 Sludge Belcher
//<b>TauntDeathrattle:</b> Summon a 1/2 Slime with <b>Taunt</b>.
//<b>嘲讽，亡语：</b>召唤一个1/2并具有<b>嘲讽</b>的泥浆怪。 
	{
		
		
        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.FP1_012t);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(c, m.zonepos - 1, m.own);
        }
	}
}