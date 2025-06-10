using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_063 : SimTemplate //* 腐蚀术 Corruption
	{
		//Choose an enemy minion. At the start of your turn, destroy it.
		//选择一个敌方随从，在你的回合开始时，消灭该随从。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            //if ownplay == true -> destroyOnOwnturnstart =true   else  destroyonenemyturnstart
            target.destroyOnOwnTurnStart = target.destroyOnOwnTurnStart || ownplay;
            target.destroyOnEnemyTurnStart = target.destroyOnEnemyTurnStart || !ownplay;
            
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}