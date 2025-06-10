using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_432 : SimTemplate //* 科多兽坐骑 Kodo Mount
	{
		//Give a minion +4/+2 and <b>Rush</b>. When it dies, summon a Kodo.
		//使一个随从获得+4/+2和<b>突袭</b>。当该随从死亡时，召唤一只科多兽。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionGetBuffed(target, 4, 7);
		}

		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
