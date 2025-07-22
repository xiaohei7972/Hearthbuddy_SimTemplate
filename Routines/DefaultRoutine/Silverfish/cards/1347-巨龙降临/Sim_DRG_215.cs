using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_215 : SimTemplate //* 风暴之怒 Storm's Wrath
	{
		//Give your minions +1/+1.<b>Overload:</b> (1)
		//使你的随从获得+1/+1。<b>过载：</b>（1）
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.allMinionOfASideGetBuffed(ownplay, 1, 1);
			if (ownplay) p.ueberladung++;
		}
	}
}