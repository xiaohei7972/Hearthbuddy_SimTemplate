using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_062 : SimTemplate //* 横扫攻击 Sweeping Strikes
//Give a minion "Also damages minions next to whomever this attacks."
//使一个随从获得“同时对其攻击目标相邻的随从造成伤害。” 
	{


		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            target.ancestralspirit++;
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