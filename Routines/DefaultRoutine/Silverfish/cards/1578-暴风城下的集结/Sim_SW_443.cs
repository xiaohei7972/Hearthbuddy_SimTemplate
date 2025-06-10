using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_443 : SimTemplate //* 雷象坐骑 Elekk Mount
	{
		//Give a minion +4/+7 and <b>Taunt</b>. When it dies, summon an Elekk.
		//使一个随从获得+4/+7和<b>嘲讽</b>。当该随从死亡时，召唤一只雷象。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetBuffed(target, 4, 7);
		}		

		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
