using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_311 : SimTemplate //* 活化扫帚 Animated Broomstick
	{
		//<b>Rush</b><b>Battlecry:</b> Give your other minions <b>Rush</b>.
		//<b>突袭，战吼：</b>使你的其他随从获得<b>突袭</b>。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            foreach (Minion m in p.ownMinions)
            {
                if (m.entitiyID == own.entitiyID) continue;
				p.minionGetRush(m);
            }
		}
		
	}
}
