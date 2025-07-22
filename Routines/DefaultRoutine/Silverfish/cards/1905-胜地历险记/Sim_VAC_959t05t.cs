using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Amulet of Tracking
	//追踪护符
	//[x]Get 3 random<b>Legendary</b> cards.
	//随机获取3张<b>传说</b>卡牌。
	class Sim_VAC_959t05t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            for (int i = 0; i < 3; i++)
            {
                // 随机获取3张传说卡牌 (假设 CardDB.cardIDEnum.None 表示随机传说卡牌)
                p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            }
        }

    }
}
