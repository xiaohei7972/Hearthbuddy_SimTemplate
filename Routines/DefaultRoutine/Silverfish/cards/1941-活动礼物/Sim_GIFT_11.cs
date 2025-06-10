using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：1
	//Gul'dan's Gift
	//古尔丹的礼物
	//[x]<b>Discover</b> a <b>Temporary</b>Mortal Coil, Siphon Soul,or Twisting Nether.
	//<b>发现</b>一张<b>临时</b>的死亡缠绕，灵魂虹吸或扭曲虚空。
	class Sim_GIFT_11 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据玩家选择的选项（choice）来决定添加哪张卡牌
            CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            if (choice == 1)
            {
                selectedCardID = CardDB.cardIDEnum.EX1_302; // Mortal Coil (死亡缠绕)
            }
            else if (choice == 2)
            {
                selectedCardID = CardDB.cardIDEnum.EX1_309; // Siphon Soul (灵魂虹吸)
            }
            else if (choice == 3)
            {
                selectedCardID = CardDB.cardIDEnum.EX1_312; // Twisting Nether (扭曲虚空)
            }

            // 将选中的卡牌作为临时卡牌添加到手牌中
            if (selectedCardID != CardDB.cardIDEnum.None)
            {
                p.drawTemporaryCard(selectedCardID, ownplay); // 使用 drawTemporaryCard 方法添加临时卡牌
            }
        }
    }
}
