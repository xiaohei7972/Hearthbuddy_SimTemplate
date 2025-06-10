using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_116 : SimTemplate //* 遗物搜寻者 Reliquary Seeker
//<b>Battlecry:</b> If you have 6 other minions, gain +4/+4.
//<b>战吼：</b>如果你拥有六个其他随从，便获得+4/+4。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			int mCount = (m.own) ? p.ownMinions.Count : p.enemyMinions.Count;
			if (mCount > 6) p.minionGetBuffed(m, 4, 4);
        }
    }
}