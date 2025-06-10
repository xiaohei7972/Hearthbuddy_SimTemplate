using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_608 : SimTemplate //* 魔术戏法 Magic Trick
//<b>Discover</b> a spell that costs (3) or less.
//<b>发现</b>一张法力值消耗小于或等于（3）点的法术牌。 
	{
        

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.frostbolt, ownplay, true); 
		}
	}
}