using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS1_129 : SimTemplate //* 心灵之火 Inner Fire
	{
		//Change a minion's Attack to be equal to its Health.
		//使一个随从的攻击力等同于其生命值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionSetAngrToHP(target);
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