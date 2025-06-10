using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_033 : SimTemplate //* 剽窃 Burgle
//Add 2 random cards to your hand <i>(from your opponent's class)</i>.
//随机将两张<i>（你对手职业的）</i>卡牌置入你的手牌。 
	{
		
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
        }
    }
}