using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Active53 : SimTemplate //* 飞蝗来袭 LOCUUUUSTS!!!
	{
		//<b>Twinspell</b>.Choose an enemy.Fill your board with 2/2 Locusts that attack it.
		//<b>双生法术</b>选择一个敌人。召唤数只2/2的蝗虫，直到你的随从数量达到上限，攻击这个敌人。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
