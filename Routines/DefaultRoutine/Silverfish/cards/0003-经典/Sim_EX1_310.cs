using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_EX1_310 : SimTemplate //* 末日守卫 Doomguard
//<b>Charge</b>. <b>Battlecry:</b> Discard two random cards.
//<b>冲锋</b>，<b>战吼：</b>随机弃两张牌。 
	{
        

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.discardCards(2, own.own);
		}
	}
}