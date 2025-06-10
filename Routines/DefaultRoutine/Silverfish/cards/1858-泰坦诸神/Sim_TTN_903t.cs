using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：0
	//Spontaneous Growth
	//自行生长
	//Draw cards until your hand is full.
	//抽牌直到手牌数量达到上限。
	class Sim_TTN_903t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            while (p.owncards.Count < 10)
            {
                p.drawACard(CardDB.cardNameEN.unknown, true); // 抽牌直到手牌数量达到上限
            }
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_903t4), p.ownMinions.Count, true, false);
        }
    }
}
