using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_42p : SimTemplate //* 沙雕 Sand Shapin'
	{
		//[x]<b>Hero Power</b>Shuffle a copy of an enemyminion into your deck. Summon it when drawn.
		//<b>英雄技能</b>将一个敌方随从的一张复制洗入你的牌库。当抽到复制牌时，自动召唤该随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
