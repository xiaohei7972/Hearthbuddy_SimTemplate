using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_590 : SimTemplate //* 血骑士 Blood Knight
	{
		//<b>Battlecry:</b> All minions lose <b>Divine Shield</b>. Gain +3/+3 for each Shield lost.
		//<b>战吼：</b>所有随从失去<b>圣盾</b>。每有一个随从失去圣盾，便获得+3/+3。
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int shilds = 0;
            foreach (Minion m in p.ownMinions)
            {
                if (m.divineshild)
                {
                    p.minionLosesDivineShield(m);
                    shilds++;
                }
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.divineshild)
                {
                    p.minionLosesDivineShield(m);
                    shilds++;
                }
            }
            p.minionGetBuffed(own, 3 * shilds, 3 * shilds);
		}
	}
}