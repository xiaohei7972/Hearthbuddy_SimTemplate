using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_002 : SimTemplate //* 黑骑士 The Black Knight
	{
		//<b>Battlecry:</b> Destroy an enemy minion with <b>Taunt</b>.
		//<b>战吼：</b>消灭一个具有<b>嘲讽</b>的敌方随从。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(target!= null) p.minionGetDestroyed(target);
		}



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MUST_TARGET_TAUNTER),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}