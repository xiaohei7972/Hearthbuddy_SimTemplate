using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：7
	//Wish Upon a Star
	//星空祈愿
	//Give +2/+3 to all minions in your hand, deck, and battlefield.
	//使你手牌，牌库和战场上的所有随从获得+2/+3。
	class Sim_TOY_877 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 增强战场上的所有己方随从
            foreach (Minion minion in p.ownMinions)
            {
                p.minionGetBuffed(minion, 2, 3);
            }

            // 增强手牌中的所有随从
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.type == CardDB.cardtype.MOB) // 检查是否为随从卡牌
                {
                    hc.addattack += 2;
                    hc.addHp += 3;
                }
            }

            // 增强牌库中的所有随从
            foreach (CardDB.Card card in p.ownDeck)
            {
                if (card.type == CardDB.cardtype.MOB) // 检查是否为随从卡牌
                {
                    card.Attack += 2; // 增加攻击力
                    card.Health += 3; // 增加生命值
                }
            }
        }


    }
}
