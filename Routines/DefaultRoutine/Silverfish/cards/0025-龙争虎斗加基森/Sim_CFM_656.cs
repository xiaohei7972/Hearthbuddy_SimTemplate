using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_656 : SimTemplate //* 街头调查员 Streetwise Investigator
//<b>Battlecry:</b> Enemy minions lose <b>Stealth</b>.
//<b>战吼：</b>使所有敌方随从失去<b>潜行</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            List<Minion> temp = (m.own) ? p.enemyMinions : p.ownMinions;
            foreach (Minion mnn in temp)
            {
                mnn.stealth = false;
            }
        }
    }
}