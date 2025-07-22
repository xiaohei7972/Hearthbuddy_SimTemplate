using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_942 : SimTemplate //* 鱼人总动员 Unite the Murlocs
//[x]<b>Quest:</b> Summon10 Murlocs.<b>Reward:</b> Megafin.
//<b>任务：</b>召唤10个鱼人。<b>奖励：老鲨嘴</b>。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 2) p.evaluatePenality -= 30;
        }
    }
}