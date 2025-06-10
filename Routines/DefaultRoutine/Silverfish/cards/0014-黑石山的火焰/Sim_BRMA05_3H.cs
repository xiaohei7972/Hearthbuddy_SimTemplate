using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA05_3H : SimTemplate //* 活体炸弹 Living Bomb
//Choose an enemy minion. If it lives until your next turn, deal $10 damage to all enemies.
//选择一个敌方随从。在你的下个回合开始时，如果该随从依然存活，则对所有敌人造成$10点伤害。 
	{
		
		
		
		

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
