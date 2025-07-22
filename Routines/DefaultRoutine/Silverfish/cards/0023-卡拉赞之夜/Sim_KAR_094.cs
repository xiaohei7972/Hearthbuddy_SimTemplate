using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_094 : SimTemplate //* 致命餐叉 Deadly Fork
//<b>Deathrattle:</b> Add a 3/2 weapon to your hand.
//<b>亡语：</b>将一张3/2的武器牌置入你的手牌。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.sharpfork, m.own, true);
        }
    }
}