using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_952 : SimTemplate //* 剑龙骑术 Spikeridged Steed
//Give a minion +2/+6 and <b>Taunt</b>. When it dies, summon a Stegodon.
//使一个随从获得+2/+6和<b>嘲讽</b>。当该随从死亡时，召唤一个剑龙。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetBuffed(target, 2, 6);
			target.stegodon++;
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}