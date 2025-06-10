using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRM_028 : SimTemplate //* 索瑞森大帝 Emperor Thaurissan
//At the end of your turn, reduce the Cost of cards in your hand by (1).
//在你的回合结束时，你所有手牌的法力值消耗减少（1）点。 
	{
		
		
        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            if (m.own == turnEndOfOwner)
            {
				foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.manacost >= 1) hc.manacost--;
                }
            }
        }
	}
}