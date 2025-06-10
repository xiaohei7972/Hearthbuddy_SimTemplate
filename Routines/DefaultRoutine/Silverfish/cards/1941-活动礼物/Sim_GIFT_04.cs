using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：1
	//Arthas's Gift
	//阿尔萨斯的礼物
	//[x]<b>Discover</b> a <b>Temporary</b>Dark Transformation,Howling Blast, orDeath Strike.
	//<b>发现</b>一张<b>临时</b>的黑暗突变，凛风冲击或灵界打击。
	class Sim_GIFT_04 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据玩家选择的选项（choice）来决定添加哪张卡牌
            CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            if (choice == 1)
            {
                selectedCardID = CardDB.cardIDEnum.RLK_057; // Dark Transformation (黑暗突变)
            }
            else if (choice == 2)
            {
                selectedCardID = CardDB.cardIDEnum.RLK_015; // Howling Blast (凛风冲击)
            }
            else if (choice == 3)
            {
                selectedCardID = CardDB.cardIDEnum.RLK_024; // Death Strike (灵界打击)
            }

            // 将选中的卡牌作为临时卡牌添加到手牌中
            if (selectedCardID != CardDB.cardIDEnum.None)
            {
                p.drawTemporaryCard(selectedCardID, ownplay);
            }
        }

    }
}
