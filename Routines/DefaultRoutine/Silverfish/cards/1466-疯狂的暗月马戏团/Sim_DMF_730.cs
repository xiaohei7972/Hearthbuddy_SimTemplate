using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_730 : SimTemplate //* 月触项链 Moontouched Amulet
	{
		//Give your hero +4 Attack this turn. <b>Corrupt:</b> And gain 6 Armor.
		//在本回合中，使你的英雄获得+4攻击力。<b>腐蚀：</b>并获得6点护甲值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionGetTempBuff(p.ownHero, 4, 0);
		}

	}
}
