using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_067 : SimTemplate //* 探索地下洞穴 The Caverns Below
	{
		//[x]<b>Quest:</b> Play four minionswith the same name.<b>Reward:</b> Crystal Core.
		//<b>任务：</b>使用四张名称相同的随从牌。<b>奖励：</b>水晶核心。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 2) p.evaluatePenality -= 30;
        }
    }
}
