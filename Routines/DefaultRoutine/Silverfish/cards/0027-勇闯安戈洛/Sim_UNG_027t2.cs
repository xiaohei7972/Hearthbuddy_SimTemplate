using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_027t2 : SimTemplate //* 派烙斯 Pyros
//<b>Deathrattle:</b> Return this to_your hand as a 10/10 that costs (10).
//<b>亡语：</b>将该随从移回你的手牌，并变为法力值消耗为（10）点的10/10随从牌。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.UNG_027t4, m.own, true);
        }
	}
}