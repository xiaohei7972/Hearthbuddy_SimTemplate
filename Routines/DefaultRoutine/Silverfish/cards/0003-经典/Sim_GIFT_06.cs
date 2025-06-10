using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：1
	//Thrall's Gift
	//萨尔的礼物
	//<b>Discover</b> a <b>Temporary</b> Lightning Storm, Hex,or Bloodlust.
	//<b>发现</b>一张<b>临时</b>的闪电风暴，妖术或嗜血。
	class Sim_GIFT_06 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据玩家选择的选项（choice）来决定添加哪张卡牌
            CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            if (choice == 1)
            {
                selectedCardID = CardDB.cardIDEnum.EX1_259; // Lightning Storm (闪电风暴)
            }
            else if (choice == 2)
            {
                selectedCardID = CardDB.cardIDEnum.EX1_246; // Hex (妖术)
            }
            else if (choice == 3)
            {
                selectedCardID = CardDB.cardIDEnum.CS2_046; // Bloodlust (嗜血)
            }

            // 将选中的卡牌作为临时卡牌添加到手牌中
            if (selectedCardID != CardDB.cardIDEnum.None)
            {
                p.drawTemporaryCard(selectedCardID, ownplay);
            }
        }
    }
}
