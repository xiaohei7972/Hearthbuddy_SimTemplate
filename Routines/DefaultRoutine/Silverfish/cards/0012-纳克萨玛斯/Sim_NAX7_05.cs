using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX7_05 : SimTemplate //* 精神控制水晶 Mind Control Crystal
//Activate the Crystal to control the Understudies!
//激活水晶来控制死亡学员！ 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            foreach (Minion m in ownplay ? p.enemyMinions : p.ownMinions)
            {
				if (m.name == CardDB.cardNameEN.understudy) p.minionGetControlled(m, ownplay, true);
			}
		}
	}
}