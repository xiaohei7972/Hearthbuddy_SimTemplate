using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_324 : SimTemplate //* 白眼大侠 White Eyes
//<b>Taunt</b><b>Deathrattle:</b> Shuffle'The Storm Guardian' into your deck.
//<b>嘲讽，亡语：</b>将风暴守护者洗入你的牌库。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own) p.ownDeckSize++;
            else p.enemyDeckSize++;
        }
    }
}