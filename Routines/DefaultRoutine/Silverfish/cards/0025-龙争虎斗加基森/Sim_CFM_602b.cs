using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_602b : SimTemplate //* 青玉秘藏 Jade Stash
//Shuffle 3 Jade Idols into your deck.
//将三张“青玉护符”洗入你的牌库。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.ownDeckSize += 3;
                p.evaluatePenality -= 11;
            }
            else p.enemyDeckSize += 3;
        }
    }
}