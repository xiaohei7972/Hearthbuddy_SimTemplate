using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_032a : SimTemplate //* 水晶赠礼 Gift of Mana
//Give each player a Mana Crystal.
//使每个玩家获得一个法力水晶。 
    {

        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.mana = Math.Min(10, p.mana+1);
            p.ownMaxMana = Math.Min(10, p.ownMaxMana+1);
            p.enemyMaxMana = Math.Min(10, p.enemyMaxMana+1);
        }


    }

}