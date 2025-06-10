using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Amulet of Tracking
	//追踪护符
	//[x]Get 3 random<b>Legendary</b> cards.<i>(Then transform theminto <b>Commons</b>!)</i>
	//随机获取3张<b>传说</b>卡牌。<i>（然后将其变形成为<b>普通</b>卡牌！）</i>
	class Sim_VAC_959t05 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 抽三张牌
            for (int i = 0; i < 3; i++)
            {
                p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            }
        }
		
	}
}
