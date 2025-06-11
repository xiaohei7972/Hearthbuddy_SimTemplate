using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：1
	//Illidan's Gift
	//伊利丹的礼物
	//<b>Discover</b> a <b>Temporary</b> Fel Barrage, Chaos Strike, or Chaos Nova.
	//<b>发现</b>一张<b>临时</b>的邪能弹幕，混乱打击或混乱新星。
	class Sim_GIFT_08 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据玩家选择的选项（choice）来决定添加哪张卡牌
            CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            if (choice == 1)
            {
                selectedCardID = CardDB.cardIDEnum.SW_040; // Fel Barrage (邪能弹幕)
            }
            else if (choice == 2)
            {
                selectedCardID = CardDB.cardIDEnum.BT_035; // Chaos Strike (混乱打击)
            }
            else if (choice == 3)
            {
                selectedCardID = CardDB.cardIDEnum.BT_235; // Chaos Nova (混乱新星)
            }

            // 将选中的卡牌作为临时卡牌添加到手牌中
            if (selectedCardID != CardDB.cardIDEnum.None)
            {
                p.drawTemporaryCard(selectedCardID, ownplay); // 使用 drawTemporaryCard 方法添加临时卡牌
            }
        }
    }
}
