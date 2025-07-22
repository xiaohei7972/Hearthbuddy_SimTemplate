using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_811 : SimTemplate //* 新月视界 Lunar Visions
//Draw 2 cards. Minions drawn cost (2) less.
//抽两张牌，抽到的随从牌法力值消耗减少（2）点。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }
    }
}