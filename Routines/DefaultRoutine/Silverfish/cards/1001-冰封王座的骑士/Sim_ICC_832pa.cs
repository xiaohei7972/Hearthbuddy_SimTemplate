using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_832pa: SimTemplate //* 甲虫硬壳 Scarab Shell
//+3 Armor.
//+3护甲值。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay) p.minionGetArmor(p.ownHero, 3);
            else p.minionGetArmor(p.enemyHero, 3);
        }
    }
}