using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：1
	//Malfurion's Gift
	//玛法里奥的礼物
	//<b>Discover</b> a <b>Temporary</b>Feral Rage, Wild Growth,or Swipe.
	//<b>发现</b>一张<b>临时</b>的野性之怒，野性成长或横扫。
	class Sim_GIFT_10 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据玩家选择的选项（choice）来决定添加哪张卡牌
            CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            if (choice == 1)
            {
                selectedCardID = CardDB.cardIDEnum.OG_047; // Feral Rage (野性之怒)
            }
            else if (choice == 2)
            {
                selectedCardID = CardDB.cardIDEnum.CORE_CS2_013; // Wild Growth (野性成长)
            }
            else if (choice == 3)
            {
                selectedCardID = CardDB.cardIDEnum.CS2_012; // Swipe (横扫)
            }

            // 将选中的卡牌作为临时卡牌添加到手牌中
            if (selectedCardID != CardDB.cardIDEnum.None)
            {
                p.drawTemporaryCard(selectedCardID, ownplay); // 使用 drawTemporaryCard 方法添加临时卡牌
            }
        }
    }
}
