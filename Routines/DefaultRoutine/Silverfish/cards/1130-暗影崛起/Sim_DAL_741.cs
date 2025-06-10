using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_741 : SimTemplate //* 虚灵跟班 Ethereal Lackey
//<b>Battlecry:</b> <b>Discover</b> a spell.
//<b>战吼：</b><b>发现</b>一张法术牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
		}
	}
}