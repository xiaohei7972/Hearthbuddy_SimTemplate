using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_305 : SimTemplate //* 乌瑞恩首席剑士 First Blade of Wrynn
	{
		//[x]<b>Divine Shield</b><b>Battlecry:</b> Gain <b>Rush</b> if thishas at least 4 Attack.
		//<b>圣盾</b>，<b>战吼：</b>如果该随从拥有至少4点攻击力，获得<b>突袭</b>。
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
			if (m.Angr >= 4) p.minionGetRush(m);
		}
	}
}
