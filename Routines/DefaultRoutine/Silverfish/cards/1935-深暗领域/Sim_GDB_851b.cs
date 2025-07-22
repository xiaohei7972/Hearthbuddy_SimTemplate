using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//晕击星光 Stunning Star
	//Choose an enemy minion. It goes Dormant for 2 turns.
	//选择一个敌方随从。使其休眠2回合。
	class Sim_GDB_851b : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                target.dormant = 2; // 使目标随从休眠2回合
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 需要一个随从目标
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 需要一个敌方目标
            };
        }
    }
}