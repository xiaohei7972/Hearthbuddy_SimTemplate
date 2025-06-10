using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX14_02 : SimTemplate //* 冰霜吐息 Frost Breath
//<b>Hero Power</b>Destroy all enemy minions that aren't <b>Frozen</b>.
//<b>英雄技能</b>消灭所有没有被<b>冻结</b>的敌方随从。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = ownplay ? p.enemyMinions : p.ownMinions;
            int i = 0;
			int tempCount = temp.Count;
            for (; i < tempCount; i++)
            {
				temp[i].extraParam = true;
                if (temp[i].frozen) temp[i].extraParam = false;
                if (temp[i].name == CardDB.cardNameEN.frozenchampion && !temp[i].silenced)
				{
					temp[i].extraParam = false;
					if (i > 0) temp[i-1].extraParam = false;
					if (i + 1 < tempCount) temp[i+1].extraParam = false;
				}
            }
			
            foreach (Minion m in temp)
            {
                if (!m.extraParam) continue;
				m.extraParam = false;
				p.minionGetDestroyed(m);
            }
		}
	}
}