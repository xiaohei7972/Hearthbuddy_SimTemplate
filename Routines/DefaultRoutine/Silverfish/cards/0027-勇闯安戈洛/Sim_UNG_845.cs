using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_845 : SimTemplate //* 火岩元素 Igneous Elemental
//<b>Deathrattle:</b> Add two 1/2 Elementals to your hand.
//<b>亡语：</b>将两张1/2的元素牌置入你的手牌。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.UNG_809t1, m.own, true);
            p.drawACard(CardDB.cardIDEnum.UNG_809t1, m.own, true);
        }
	}
}