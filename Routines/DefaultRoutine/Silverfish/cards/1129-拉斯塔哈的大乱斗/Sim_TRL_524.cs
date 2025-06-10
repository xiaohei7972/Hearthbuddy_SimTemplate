using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_524 : SimTemplate //* 破盾者 Shieldbreaker
//<b>Battlecry:</b> <b>Silence</b> an enemy minion with <b>Taunt</b>.
//<b>战吼：</b><b>沉默</b>一个具有<b>嘲讽</b>的敌方随从。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) p.minionGetSilenced(target);
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