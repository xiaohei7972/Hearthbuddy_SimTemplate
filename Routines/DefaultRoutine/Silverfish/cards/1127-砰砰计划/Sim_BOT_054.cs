using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_054 : SimTemplate //* 生物计划 Biology Project
//Each player gains 2_Mana Crystals.
//每个玩家获得两个法力水晶。 
    {
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.mana = Math.Min(10, p.mana+2);
            p.ownMaxMana = Math.Min(10, p.ownMaxMana+2);
            p.enemyMaxMana = Math.Min(10, p.enemyMaxMana+2);
        }


    }

}