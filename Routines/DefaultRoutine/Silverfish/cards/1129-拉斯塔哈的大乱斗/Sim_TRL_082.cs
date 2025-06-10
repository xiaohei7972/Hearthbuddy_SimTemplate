using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_082 : SimTemplate //* 终极巫毒 Big Bad Voodoo
//Give a friendly minion "<b>Deathrattle:</b> Summon a random minion that costs (1) more."
//使一个友方随从获得“<b>亡语：</b>随机召唤一个法力值消耗增加（1）点的随从。” 
	{


		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            target.ancestralspirit++;
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