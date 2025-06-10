using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_092 : SimTemplate //* 王者祝福 Blessing of Kings
	{
		//Give a minion +4/+4. <i>(+4 Attack/+4 Health)</i>
		//使一个随从获得+4/+4。<i>（+4攻击力/+4生命值）</i>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 4, 4);
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
