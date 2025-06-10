using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_450t4 : SimTemplate //* 奥术师晨拥 Arcanist Dawngrasp
	{
		//[x]<b>Battlecry:</b> For the restof the game, you have<b>Spell Damage +3</b>.
		//<b>战吼：</b>在本局对战的剩余时间内，你获得<b>法术伤害+3</b>。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.spellpower++;
			p.spellpower++;
			p.spellpower++;
		}
	}
}
