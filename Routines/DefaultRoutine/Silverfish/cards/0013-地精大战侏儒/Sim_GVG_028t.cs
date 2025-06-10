using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_028t : SimTemplate //* 加里维克斯的幸运币 Gallywix's Coin
//Gain 1 Mana Crystal this turn only.<i>(Won't trigger Gallywix.)</i>
//在本回合中，获得一个法力水晶。<i>（不会触发加里维克斯的效果。）</i> 
    {

        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.mana++;
        }


    }

}