using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_851 : SimTemplate //* “开拓者”伊莉斯 Elise the Trailblazer
//<b>Battlecry:</b> Shuffle a sealed_<b>Un'Goro</b> pack into_your deck.
//<b>战吼：</b>将一张<b>安戈洛卡牌包</b>洗入你的牌库。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own) p.ownDeckSize++;
            else p.enemyDeckSize++;
        }
    }
}