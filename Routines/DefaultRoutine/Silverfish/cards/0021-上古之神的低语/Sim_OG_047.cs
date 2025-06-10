using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_047 : SimTemplate //* 野性之怒 Feral Rage
//<b>Choose One -</b> Give your hero +4 Attack this turn; or Gain 8 Armor.
//<b>抉择：</b>使你的英雄在本回合中获得+4攻击力；或者获得8点护甲值。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                if (ownplay) p.minionGetTempBuff(p.ownHero, 4, 0);
                else p.minionGetTempBuff(p.enemyHero, 4, 0);
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {        
                if (ownplay) p.minionGetArmor(p.ownHero, 8);
                else p.minionGetArmor(p.enemyHero, 8);
            }
        }
    }
}