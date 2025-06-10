using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：3 攻击力：3 生命值：3
	//Careless Crafter
	//粗心的匠人
	//<b>Deathrattle:</b> Get two0-Cost Bandages that restore 3 Health.
	//<b>亡语：</b>获取两张法力值消耗为（0）的可以恢复3点生命值的绷带。
	class Sim_TOY_382 : SimTemplate
	{

        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 获取两张法力值消耗为0的绷带牌
            CardDB.cardIDEnum bandageCard = CardDB.cardIDEnum.TOY_382t; // 假设绷带牌的ID为TOY_382t
            for (int i = 0; i < 2; i++)
            {
                p.drawACard(bandageCard, m.own, true); // 绷带牌为临时牌
            }
        }
    }
}
