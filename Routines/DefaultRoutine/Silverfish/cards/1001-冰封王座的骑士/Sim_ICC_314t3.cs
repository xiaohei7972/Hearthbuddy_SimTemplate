using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ICC_314t3 : SimTemplate //* 末日契约 Doom Pact
//[x]Destroy all minions. Remove the top card from your deck for eachminion destroyed.
//消灭所有随从。每消灭一个随从，移除你的牌库顶的一张牌。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int anz = p.ownMinions.Count + p.enemyMinions.Count;
            p.allMinionsGetDestroyed();
            if (ownplay) p.ownDeckSize = Math.Max(0, p.ownDeckSize - anz);
            else p.enemyDeckSize = Math.Max(0, p.enemyDeckSize - anz);
        }
    }
}