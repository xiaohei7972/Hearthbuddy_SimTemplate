using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_515 : SimTemplate //* 行骗 Swindle
	{
        //Draw a spell.<b>Combo:</b> And a minion.
        //抽一张法术牌。<b>连击：</b>并抽一张随从牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            if (p.cardsPlayedThisTurn > 0)
            {
                p.evaluatePenality -= 5;
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
            }
        }
    }
}
