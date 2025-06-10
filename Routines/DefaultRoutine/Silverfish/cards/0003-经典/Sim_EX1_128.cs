using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_128 : SimTemplate //* 隐藏 Conceal
//Give your minions <b>Stealth</b> until your next_turn.
//直到你的下个回合，使所有友方随从获得<b>潜行</b>。 
	{



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                foreach (Minion m in p.ownMinions)
                {
                    if (!m.stealth)
                    {
                        m.stealth = true;
                        m.conceal = true;
                    }
                }
            }
            else
            {
                foreach (Minion m in p.enemyMinions)
                {
                    if (!m.stealth)
                    {
                        m.stealth = true;
                        m.conceal = true;
                    }
                }
            }
		}

	}

}