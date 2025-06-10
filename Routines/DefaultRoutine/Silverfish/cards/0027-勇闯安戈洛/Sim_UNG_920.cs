using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_920 : SimTemplate //* 湿地女王 The Marsh Queen
//[x]<b>Quest:</b> Play seven1-Cost minions.<b>Reward:</b> Queen Carnassa.
//<b>任务：</b>使用七张法力值消耗为（1）的随从牌。<b>奖励：</b>卡纳莎女王。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 2) p.evaluatePenality -= 30;
        }
    }
}