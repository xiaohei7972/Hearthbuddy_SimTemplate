using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_323 : SimTemplate //* 烬鳞幼龙 Emberscale Drake
//<b>Battlecry:</b> If you're holding a Dragon, gain 5 Armor.
//<b>战吼：</b>如果你的手牌中有龙牌，便获得5点护甲值。 
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