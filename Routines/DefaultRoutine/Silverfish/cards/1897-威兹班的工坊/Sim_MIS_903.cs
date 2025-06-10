using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：4
	//Dubious Purchase
	//可疑交易
	//Draw 3 cards.<b>Combo:</b> Destroy a random enemy minion.
	//抽三张牌。<b>连击：</b>随机消灭一个敌方随从。
	class Sim_MIS_903 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 抽三张牌
            for (int i = 0; i < 3; i++)
            {
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
            }
        }
    }
}
