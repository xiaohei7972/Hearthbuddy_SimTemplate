using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：4
	//Aggressive Projections
	//激进预估
	//+2 Attack.
	//+2攻击力。
	class Sim_WORK_025a : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 2, 0);
        }
		
	}
}
