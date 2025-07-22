using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：4
	//Conservative Forecast
	//保守预估
	//+2 Health.
	//+2生命值。
	class Sim_WORK_025b : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 0, 2);
        }
		
	}
}
