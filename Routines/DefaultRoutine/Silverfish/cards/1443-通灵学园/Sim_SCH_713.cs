using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_713 : SimTemplate //* 异教低阶牧师 Cult Neophyte
	{
		//<b>Battlecry:</b> Your opponent's spells cost (1) more next_turn.
		//<b>战吼：</b>下个回合你的对手法术的法力值消耗增加(1)点。
		// public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		// {
        //     p.loatheb = true;
		// }
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            //p.enemyMaxMana --;
		}
		
		
	}
}
