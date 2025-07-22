using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_113 : SimTemplate //* 热情的探险家 Bright-Eyed Scout
//<b>Battlecry:</b> Draw a card. Change its Cost to (5).
//<b>战吼：</b>抽一张牌，使其法力值消耗变为（5）点。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own);
                p.owncards[p.owncards.Count - 1].manacost = 5;
		}
	}
}