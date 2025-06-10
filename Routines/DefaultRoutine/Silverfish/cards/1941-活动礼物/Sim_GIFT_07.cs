using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：1
	//Garrosh's Gift
	//加尔鲁什的礼物
	//<b>Discover</b> a <b>Temporary</b> Execute, Shield Block, or Brawl.
	//<b>发现</b>一张<b>临时</b>的斩杀，盾牌格挡或绝命乱斗。
	class Sim_GIFT_07 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据玩家选择的选项（choice）来决定添加哪张卡牌
            CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            if (choice == 1)
            {
                selectedCardID = CardDB.cardIDEnum.EX1_407; // Execute (斩杀)
            }
            else if (choice == 2)
            {
                selectedCardID = CardDB.cardIDEnum.EX1_606; // Shield Block (盾牌格挡)
            }
            else if (choice == 3)
            {
                selectedCardID = CardDB.cardIDEnum.EX1_407; // Brawl (绝命乱斗)
            }

            // 将选中的卡牌作为临时卡牌添加到手牌中
            if (selectedCardID != CardDB.cardIDEnum.None)
            {
                p.drawTemporaryCard(selectedCardID, ownplay); // 使用新的 drawTemporaryCard 方法
            }
        }
    }
}
