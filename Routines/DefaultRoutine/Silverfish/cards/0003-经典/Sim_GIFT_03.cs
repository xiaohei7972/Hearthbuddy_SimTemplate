using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：1
	//Rexxar's Gift
	//雷克萨的礼物
	//[x]<b>Discover</b> a <b>Temporary</b>Quick Shot, Deadly Shot,or Explosive Shot.
	//<b>发现</b>一张<b>临时</b>的快速射击，致命射击或爆炸射击。
	class Sim_GIFT_03 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据玩家选择的选项（choice）来决定添加哪张卡牌
            CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            if (choice == 1)
            {
                selectedCardID = CardDB.cardIDEnum.BRM_013; // Quick Shot (快速射击)
            }
            else if (choice == 2)
            {
                selectedCardID = CardDB.cardIDEnum.EX1_617; // Deadly Shot (致命射击)
            }
            else if (choice == 3)
            {
                selectedCardID = CardDB.cardIDEnum.EX1_537; // Explosive Shot (爆炸射击)
            }

            // 将选中的卡牌作为临时卡牌添加到手牌中
            if (selectedCardID != CardDB.cardIDEnum.None)
            {
                p.drawTemporaryCard(selectedCardID, ownplay);
            }
        }
    }
}
