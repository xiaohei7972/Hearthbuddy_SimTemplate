using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：1
	//Wilderness Pack
	//狂野的卡牌包
	//Add 5 randomBeasts to your hand.They are <b>Temporary</b>.
	//随机将五张野兽牌置入你的手牌。这些牌为<b>临时</b>牌。
	class Sim_MIS_104 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 随机添加五张野兽牌到手牌中
            for (int i = 0; i < 5; i++)
            {
                // 获取一张随机的野兽牌
                // 将野兽牌作为临时卡牌添加到手牌中
                p.drawTemporaryCard(CardDB.cardIDEnum.None, ownplay);
            }
        }
    }
}
