using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：1
	//Valeera's Gift
	//瓦莉拉的礼物
	//[x]<b>Discover</b> a <b>Temporary</b>Backstab, Deadly Poison,or Fan of Knives.
	//<b>发现</b>一张<b>临时</b>的背刺，致命药膏或刀扇。
	class Sim_GIFT_09 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据玩家选择的选项（choice）来决定添加哪张卡牌
            CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            if (choice == 1)
            {
                selectedCardID = CardDB.cardIDEnum.CS2_072; // Backstab (背刺)
            }
            else if (choice == 2)
            {
                selectedCardID = CardDB.cardIDEnum.CS2_074; // Deadly Poison (致命药膏)
            }
            else if (choice == 3)
            {
                selectedCardID = CardDB.cardIDEnum.EX1_129; // Fan of Knives (刀扇)
            }

            // 将选中的卡牌作为临时卡牌添加到手牌中
            if (selectedCardID != CardDB.cardIDEnum.None)
            {
                p.drawTemporaryCard(selectedCardID, ownplay); // 使用 drawTemporaryCard 方法添加临时卡牌
            }
        }

    }
}
