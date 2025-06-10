using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Amulet of Strides
	//挺进护符
	//[x]Reduce the Cost of allcards in your hand by (1).
	//使你手牌中的所有卡牌的法力值消耗减少（1）点。
	class Sim_VAC_959t10t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 使你手牌中的所有卡牌的法力值消耗减少1点
            foreach (Handmanager.Handcard hc in p.owncards)
            {
				if (hc.card.type == CardDB.cardtype.MOB)
				{
					hc.manacost = Math.Max(0, hc.manacost - 1);
				}            
            }
        }
    }
}
