using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：1
	//Jaina's Gift
	//吉安娜的礼物
	//<b>Discover</b> a <b>Temporary</b> Frostbolt, Arcane Intellect, or Fireball.
	//<b>发现</b>一张<b>临时</b>的寒冰箭，奥术智慧或火球术。
	class Sim_GIFT_02 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据玩家选择的选项（choice）来决定添加哪张卡牌
            CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            if (choice == 1)
            {
                selectedCardID = CardDB.cardIDEnum.CS2_024; // Frostbolt (寒冰箭)
            }
            else if (choice == 2)
            {
                selectedCardID = CardDB.cardIDEnum.CS2_023; // Arcane Intellect (奥术智慧)
            }
            else if (choice == 3)
            {
                selectedCardID = CardDB.cardIDEnum.CS2_029; // Fireball (火球术)
            }

            // 将选中的卡牌作为临时卡牌添加到手牌中
            if (selectedCardID != CardDB.cardIDEnum.None)
            {
                p.drawTemporaryCard(selectedCardID, ownplay);
            }
        }

    }
}
