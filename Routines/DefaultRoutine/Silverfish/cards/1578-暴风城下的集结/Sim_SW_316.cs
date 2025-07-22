using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_316 : SimTemplate //* 神圣坐骑 Noble Mount
	{
		//G[x]ive a minion +1/+1and <b>Divine Shield</b>.When it dies, summona Warhorse.
		//使一个随从获得+1/+1和<b>圣盾</b>。当该随从死亡时，召唤一匹战马。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)//卡牌使用
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 1, 1);
                target.divineshild = true;
                target.enchs += " SE_326e";
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
		
	}
}
