using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_250 : SimTemplate //* 倦怠光波 Wave of Apathy
	{
		//Set the Attack of all enemy minions to 1 until your next turn.
		//直到你的下个回合，将所有敌方随从的攻击力变为1点。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                foreach (Minion m in p.enemyMinions)
                {
                    p.minionGetTempBuff(m, -m.Angr + 1, 0);
                }
            }
            else
            {
                foreach (Minion m in p.ownMinions)
                {
                    p.minionGetTempBuff(m, -m.Angr + 1, 0);
                }
            }
        }
	}
}
