
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_WON_308 : SimTemplate // 避免报错
    {
        // 在这里可以定义卡牌的属性，如法力值消耗、卡牌类型、效果等等
public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Handmanager.Handcard triggerhc)
		{
			if (ownplay && hc.card.Secret)
            {
				triggerhc.manacost = triggerhc.getManaCost(p);
			}
		}
        
        
    }
}
