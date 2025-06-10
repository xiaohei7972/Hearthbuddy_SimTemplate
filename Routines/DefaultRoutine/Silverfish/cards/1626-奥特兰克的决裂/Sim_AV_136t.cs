using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_136t : SimTemplate //* 护甲碎片 armorscrap
	{
		//使一个随从获得+2生命值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionGetBuffed(target, 0, 2);
		}
	}
}
