using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Uther's Gift
	//乌瑟尔的礼物
	//<b>Discover</b> a <b>Temporary</b> Equality, Consecration, or Blessing of Kings.
	//<b>发现</b>一张<b>临时</b>的生而平等，奉献或王者祝福。
	class Sim_GIFT_05 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据玩家选择的选项（choice）来决定添加哪张卡牌
            CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            if (choice == 1)
            {
                selectedCardID = CardDB.cardIDEnum.CORE_EX1_619; // Equality (生而平等)
            }
            else if (choice == 2)
            {
                selectedCardID = CardDB.cardIDEnum.CS2_093; // Consecration (奉献)
            }
            else if (choice == 3)
            {
                selectedCardID = CardDB.cardIDEnum.CS2_092; // Blessing of Kings (王者祝福)
            }

            // 将选中的卡牌作为临时卡牌添加到手牌中
            if (selectedCardID != CardDB.cardIDEnum.None)
            {
                p.drawTemporaryCard(selectedCardID, ownplay);
            }
        }
    }
}
