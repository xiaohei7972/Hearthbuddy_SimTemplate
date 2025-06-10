using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_816 : SimTemplate //* 沼泽龙蛋 Swamp Dragon Egg
//<b>Deathrattle:</b> Add a random Dragon to your hand.
//<b>亡语：</b>随机将一张龙牌置入你的手牌。 
	{


        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.faeriedragon, m.own, true);
        }
	}
}