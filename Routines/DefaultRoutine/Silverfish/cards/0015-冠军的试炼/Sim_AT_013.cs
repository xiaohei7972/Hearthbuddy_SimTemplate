using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_013 : SimTemplate //* 真言术：耀 Power Word: Glory
//Choose a minion. Whenever it attacks, restore 4 Health toyour hero.
//选择一个随从。每当其进行攻击，为你的英雄恢复4点生命值。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                target.ownPowerWordGlory++;
            }
            else
            {
                target.enemyPowerWordGlory++;
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}