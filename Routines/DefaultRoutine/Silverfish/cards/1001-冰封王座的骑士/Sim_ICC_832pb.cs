using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_832pb: SimTemplate //* 蜘蛛毒牙 Spider Fangs
//+3 Attack.
//+3攻击力。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay) p.minionGetTempBuff(p.ownHero, 3, 0);
            else p.minionGetTempBuff(p.enemyHero, 3, 0);
        }
    }
}