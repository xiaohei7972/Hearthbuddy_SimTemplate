using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 恶魔之箭 Demonbolt
    //Destroy a minion. Costs (1) less for each minion you control.
    //消灭一个随从。你每有一个随从，该牌的法力值消耗便减少（1）点。
    class Sim_TRL_555 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetDestroyed(target);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
			};

        }
    }
}
