using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_079 : SimTemplate //* 伊莉斯·逐星 Elise Starseeker
//<b>Battlecry:</b> Shuffle the 'Map to the Golden Monkey'   into your deck.
//<b>战吼：</b>将“黄金猿藏宝图”洗入你的牌库。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
			{
				p.ownDeckSize++;
			}
            else p.enemyDeckSize++;
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}