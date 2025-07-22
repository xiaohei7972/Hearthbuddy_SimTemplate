using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_601 : SimTemplate //* 古尔丹之颅 Skull of Gul'dan
	{
		//Draw 3 cards.<b>Outcast:</b> Reduce their Cost by (3).
		//抽三张牌。<b>流放：</b>这些牌的法力值消耗减少（3）点。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			//p.evaluatePenality += 24;
			if (outcast)
			{
				//var hc1 = p.owncards[p.owncards.Count - 3];
				//var hc2 = p.owncards[p.owncards.Count - 2];
				//var hc3 = p.owncards[p.owncards.Count - 1];
				//hc1.manacost = Math.Max(0, hc1.manacost - 3);
				//hc2.manacost = Math.Max(0, hc1.manacost - 3);
				//hc3.manacost = Math.Max(0, hc1.manacost - 3);
				p.evaluatePenality -= 80;
			}
			//p.evaluatePenality -= 25;
		}
	}
}
