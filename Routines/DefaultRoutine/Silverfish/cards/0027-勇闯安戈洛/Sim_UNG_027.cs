using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_027 : SimTemplate //* 派烙斯 Pyros
//<b>Deathrattle:</b> Return this to_your hand as a 6/6 that costs (6).
//<b>亡语：</b>将该随从移回你的手牌，并变为法力值消耗为（6）点的6/6随从牌。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
		    p.drawACard(CardDB.cardIDEnum.UNG_027t2, m.own, true);
        }
	}
}