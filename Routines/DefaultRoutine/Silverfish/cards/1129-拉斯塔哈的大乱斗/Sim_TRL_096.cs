using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_096 : SimTemplate //* 格里伏塔 Griftah
//[x]<b>Battlecry:</b> <b>Discover</b> twocards. Give one to youropponent at random.
//<b>战吼：</b><b>发现</b>两张牌。随机交给你的对手其中一张。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
            p.drawACard(CardDB.cardNameEN.unknown, own.own, false);

		}


	}
}