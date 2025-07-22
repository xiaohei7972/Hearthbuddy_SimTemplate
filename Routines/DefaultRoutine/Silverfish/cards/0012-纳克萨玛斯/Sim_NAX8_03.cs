using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX8_03 : SimTemplate //* 冷酷学徒 Unrelenting Trainee
//<b>Deathrattle:</b> Summon a Spectral Trainee for your opponent.
//<b>亡语：</b>为你的对手召唤一个鬼灵学徒。 
	{

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NAX8_03t); 
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            int place = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(kid, place, !m.own);
        }
	}
}