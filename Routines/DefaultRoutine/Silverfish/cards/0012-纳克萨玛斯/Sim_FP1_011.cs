using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_011 : SimTemplate //* 结网蛛 Webspinner
//<b>Deathrattle:</b> Add a random Beast card to your hand.
//<b>亡语：</b>随机将一张野兽牌置入你的手牌。 
	{


        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.rivercrocolisk, m.own, true);
        }
	}
}