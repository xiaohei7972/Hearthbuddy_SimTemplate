using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_061 : SimTemplate //* 子弹上膛 Lock and Load
//Each time you cast a spell this turn, add a random Hunter card to your hand.
//在本回合中，每当你施放一个法术，随机将一张猎人卡牌置入你的手牌。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{			
            if (ownplay)
            {
                p.lockandload++;
            }
		}
	}
}