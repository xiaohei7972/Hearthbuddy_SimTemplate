using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX8_05 : SimTemplate //* 冷酷骑兵 Unrelenting Rider
//<b>Deathrattle:</b> Summon a Spectral Rider for your opponent.
//<b>亡语：</b>为你的对手召唤一个鬼灵骑兵。 
	{

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NAX8_05t); 
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            int place = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(kid, place, !m.own);
        }
	}
}