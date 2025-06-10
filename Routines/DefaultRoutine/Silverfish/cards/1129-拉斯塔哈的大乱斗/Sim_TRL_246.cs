using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_246 : SimTemplate //* 虚空契约 Void Contract
//Destroy half of each player's deck.
//摧毁双方牌库中一半的牌。 
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.ownDeckSize /= 2;
            p.enemyDeckSize /= 2;
        }
    }
}