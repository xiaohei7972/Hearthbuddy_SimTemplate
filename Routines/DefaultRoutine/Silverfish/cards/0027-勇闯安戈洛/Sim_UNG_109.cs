using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_109 : SimTemplate //* 年迈的长颈龙 Elder Longneck
//<b>Battlecry:</b> If you're holding a minion with 5 or more Attack, <b>Adapt</b>.
//<b>战吼：</b>如果你的手牌中有攻击力大于或等于5的随从牌，便获得<b>进化</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if(own.own)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if ((hc.card.Attack + hc.addattack) >= 5)
					{
						p.getBestAdapt(own);
						break;
					}
				}
			}
        }
    }
}