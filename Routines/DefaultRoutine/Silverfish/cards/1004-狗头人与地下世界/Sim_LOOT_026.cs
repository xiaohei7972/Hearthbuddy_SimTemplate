using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_026 : SimTemplate //* 法多雷突袭者 Fal'dorei Strider
//[x]<b>Battlecry:</b> Shuffle 3Ambushes into your deck.When drawn, summona 4/4 Spider.
//<b>战吼：</b>将三张伏击牌洗入你的牌库。 当抽到伏击牌时，召唤一只4/4的蜘蛛。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own) p.ownDeckSize++;
            else p.enemyDeckSize++;
			
        }
    }
}