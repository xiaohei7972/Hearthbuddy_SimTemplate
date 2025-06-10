using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_363 : SimTemplate //* 萨隆铁矿监工 Saronite Taskmaster
//<b>Deathrattle:</b> Summon a 0/3 Free Agent with <b>Taunt</b> for_your opponent.
//<b>亡语：</b>为你的对手召唤一个0/3并具有<b>嘲讽</b>的自由的矿工。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_363t);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, !m.own);
        }
	}
}