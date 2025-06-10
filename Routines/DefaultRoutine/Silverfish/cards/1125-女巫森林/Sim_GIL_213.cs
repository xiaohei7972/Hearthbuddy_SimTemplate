using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_213 : SimTemplate //* 杂毛秘术师 Tanglefur Mystic
//<b>Battlecry:</b> Add a random2-Cost minion to each player's hand.
//<b>战吼：</b>随机将一张法力值消耗为（2）的随从牌置入每个玩家的手牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.rivercrocolisk, true, true);
            p.drawACard(CardDB.cardNameEN.rivercrocolisk, false, true);
		}
	}
}