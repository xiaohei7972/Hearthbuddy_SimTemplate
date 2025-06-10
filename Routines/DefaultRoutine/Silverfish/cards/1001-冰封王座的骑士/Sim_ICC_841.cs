using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_841 : SimTemplate //* 鲜血女王兰娜瑟尔 Blood-Queen Lana'thel
//[x]<b>Lifesteal</b>Has +1 Attack for eachcard you've discardedthis game.
//<b>吸血</b>在本局对战中，你每弃掉一张牌，便获得+1攻击力。 
    {
        
        

        public override bool onCardDicscard(Playfield p, Handmanager.Handcard hc, Minion own, int num, bool checkBonus)
        {
            if (own == null) return false;
            if (checkBonus) return false;

            p.minionGetBuffed(own, num, 0);
            return false;
        }
    }
}