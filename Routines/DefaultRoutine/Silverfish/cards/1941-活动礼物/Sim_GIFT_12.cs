using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：1
	//Anduin's Gift
	//安度因的礼物
	//[x]<b>Discover</b> a <b>Temporary</b>Power Word: Shield,Shadow Word: Pain,or Mind Control.
	//<b>发现</b>一张<b>临时</b>的真言术：盾，暗言术：痛或精神控制。
	class Sim_GIFT_12 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据玩家的选择决定要添加的临时卡牌
            CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            if (choice == 1)
            {
                selectedCardID = CardDB.cardIDEnum.CS2_004; // Power Word: Shield (真言术：盾)
            }
            else if (choice == 2)
            {
                selectedCardID = CardDB.cardIDEnum.CS2_234; // Shadow Word: Pain (暗言术：痛)
            }
            else if (choice == 3)
            {
                selectedCardID = CardDB.cardIDEnum.CS1_113; // Mind Control (精神控制)
            }

            // 添加临时卡牌到手牌中
            if (selectedCardID != CardDB.cardIDEnum.None)
            {
                p.drawTemporaryCard(selectedCardID, ownplay);
            }
        }
    }
}
