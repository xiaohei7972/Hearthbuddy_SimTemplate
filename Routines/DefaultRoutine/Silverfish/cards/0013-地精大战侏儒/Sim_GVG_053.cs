using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_053 : SimTemplate //* 盾甲侍女 Shieldmaiden
//<b>Battlecry:</b> Gain 5 Armor.
//<b>战吼：</b>获得5点护甲值。 
    {

        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                p.minionGetArmor(p.ownHero, 5);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, 5);
            }
        }

    }

}