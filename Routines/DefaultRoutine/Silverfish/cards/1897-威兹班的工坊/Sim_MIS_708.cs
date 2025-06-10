using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：1
	//Twisted Pack
	//幻变的卡牌包
	//Add 5 random cards from otherclasses to your hand.They are <b>Temporary</b>.
	//随机将五张其他职业的牌置入你的手牌。这些牌为<b>临时</b>牌。
	class Sim_MIS_708 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 抽取5张随机的临时牌
            for (int i = 0; i < 5; i++)
            {
                p.drawTemporaryCard(CardDB.cardIDEnum.None, ownplay); // 使用drawTemporaryCard方法抽取临时牌
            }
        }
    }
}
