using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_957 : SimTemplate //* 恐角龙宝宝 Direhorn Hatchling
//<b>Taunt</b><b>Deathrattle:</b> Shuffle a 6/9 Direhorn with <b>Taunt</b> into your deck.
//<b>嘲讽，亡语：</b>将一张6/9并具有<b>嘲讽</b>的“恐角龙头领”洗入你的牌库。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own) p.ownDeckSize++;
            else p.enemyDeckSize++;
        }
    }
}