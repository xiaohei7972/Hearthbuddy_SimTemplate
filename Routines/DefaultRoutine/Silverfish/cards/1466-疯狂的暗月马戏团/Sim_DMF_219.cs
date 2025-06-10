using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_219 : SimTemplate //* 冷酷追杀 Relentless Pursuit
	{
		//Give your hero +4 Attack and <b>Immune</b> this turn.
		//在本回合中，使你的英雄获得+4攻击力和<b>免疫</b>。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				p.minionGetTempBuff(p.ownHero, 4, 0);
			}
		}

	}
}
