using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_035 : SimTemplate //* 好奇的萤根草 Curious Glimmerroot
//[x]<b>Battlecry:</b> Look at 3 cards.Guess which one startedin your opponent's deckto get a copy of it.
//<b>战吼：</b>检视三张卡牌。猜中来自你对手套牌中的卡牌，则获得该牌的一张复制。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}