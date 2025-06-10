using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRM_018 : SimTemplate //* 龙王配偶 Dragon Consort
//<b>Battlecry:</b> The next Dragon you play costs (2) less.
//<b>战吼：</b>你的下一张龙牌的法力值消耗减少（2）点。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
            if (m.own) p.anzOwnDragonConsort++;
		}
	}
}