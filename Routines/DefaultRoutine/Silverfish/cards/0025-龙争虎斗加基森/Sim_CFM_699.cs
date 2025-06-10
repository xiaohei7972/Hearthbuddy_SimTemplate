using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_699 : SimTemplate //* 海魔钉刺者 Seadevil Stinger
//[x]<b>Battlecry:</b> The next Murlocyou play this turn costs_Health instead of Mana.
//<b>战吼：</b>在本回合中，你召唤的下一个鱼人不再消耗法力值，转而消耗生命值。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own) p.nextMurlocThisTurnCostHealth = true;
        }
    }
}