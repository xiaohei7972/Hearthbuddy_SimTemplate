using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_916 : SimTemplate //* 奔踏 Stampede
//Each time you play a Beast this turn, add_a_random Beast to_your hand.
//在本回合中，每当你使用一张野兽牌，随机将一张野兽牌置入你的手牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.stampede++;
            }
        }
    }
}