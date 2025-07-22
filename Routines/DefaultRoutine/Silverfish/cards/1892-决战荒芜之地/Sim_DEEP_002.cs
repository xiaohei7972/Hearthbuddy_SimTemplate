using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：3
	//Elemental Companion
	//元素伙伴
	//Summon a random Elemental Companion.
	//随机召唤一个元素伙伴。
	class Sim_DEEP_002 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 定义可能召唤的元素伙伴（衍生物）的ID
            List<CardDB.cardIDEnum> elementalIds = new List<CardDB.cardIDEnum>
            {
                CardDB.cardIDEnum.DEEP_002t,  // 假设这是第一个衍生物的ID
                CardDB.cardIDEnum.DEEP_002t2,  // 假设这是第二个衍生物的ID
                CardDB.cardIDEnum.DEEP_002t3   // 假设这是第三个衍生物的ID
            };

            // 从列表中随机选择一个元素伙伴ID
            CardDB.cardIDEnum chosenElementalId = elementalIds[p.getRandomNumber(0, elementalIds.Count - 1)];

            // 根据ID获取卡牌模板
            CardDB.Card kid = CardDB.Instance.getCardDataFromID(chosenElementalId);

            // 召唤该元素伙伴
            p.callKid(kid, p.ownMinions.Count, ownplay);
        }
    }
}
