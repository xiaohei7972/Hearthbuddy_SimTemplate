using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_113 : SimTemplate //* 鱼人恩典 Everyfin is Awesome
//Give your minions +2/+2.Costs (1) less for each Murloc you control.
//使你的所有随从获得+2/+2。你每控制一个鱼人，该牌的法力值消耗便减少（1）点。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.allMinionOfASideGetBuffed(ownplay, 2, 2);
		}
	}
}