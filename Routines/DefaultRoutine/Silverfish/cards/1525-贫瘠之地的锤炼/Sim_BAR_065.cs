using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_065 : SimTemplate //* 剧毒魔蝎 Venomous Scorpid
	{
		//<b>Poisonous</b><b>Battlecry:</b> <b>Discover</b> a spell.
		//<b>剧毒</b><b>战吼：</b><b>发现</b>一张法术牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
		}		
		
	}
}
