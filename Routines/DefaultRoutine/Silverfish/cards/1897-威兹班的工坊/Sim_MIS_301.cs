using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：3
	//Overgrown Beanstalk
	//豆蔓疯长
	//Summon a 2/2 Treant. Draw a card for each Treant you control.
	//召唤一个2/2的树人。你每控制一个树人，抽一张牌。
	class Sim_MIS_301 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 召唤一个2/2的树人
            CardDB.Card treant = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_158t); // 假设树人ID是 EX1_158t
            p.callKid(treant, p.ownMinions.Count, ownplay);

            // 计算己方控制的树人数量
            int treantCount = 0;
            foreach (Minion m in p.ownMinions)
            {
                if (m.name == CardDB.cardNameEN.treant) // 假设树人的名称为 treant
                {
                    treantCount++;
                }
            }

            // 根据树人数量抽取相应的牌
            for (int i = 0; i < treantCount; i++)
            {
                p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
            }
        }
    }
}
