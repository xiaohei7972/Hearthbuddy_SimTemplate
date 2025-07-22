using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_419 : SimTemplate //* 树木学家 Dendrologist
//<b>Battlecry:</b> If you control a Treant, <b>Discover</b> a spell.
//<b>战吼：</b>如果你控制一个树人，<b>发现</b>一张法术牌。 
	{



		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) p.drawACard(CardDB.cardNameEN.unknown, own.own);
		}


	}
}