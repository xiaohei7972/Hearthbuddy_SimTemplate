using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：0
	//Tentacle Swarm
	//触须攒聚
	//Fill your hand with1/1 Chaotic Tendrils.
	//用1/1的混乱触须填满你的手牌。
	class Sim_YOG_516t3 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int cardCount = 10 - p.owncards.Count;
            if (cardCount > 0)
            {
                for (int i = 0; i < cardCount; i++)
                {
                    p.drawACard(CardDB.cardIDEnum.YOG_514, true); // 用1/1的混乱触须填满手牌
                }
            }
        }
    }
}
