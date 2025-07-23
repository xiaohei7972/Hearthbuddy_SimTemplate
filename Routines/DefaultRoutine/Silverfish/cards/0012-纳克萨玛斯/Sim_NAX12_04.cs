using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 激怒 Enrage
    //Give your hero +6 Attack this turn.
    //在本回合中，使你的英雄获得+6攻击力。 
    class Sim_NAX12_04 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetTempBuff(ownplay ? p.ownHero : p.enemyHero, 6, 0);
        }
        
    }
}