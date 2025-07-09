using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：5
	//Threshrider's Blessing
	//蛇颈龙骑手的祝福
	//Give a friendly minion +4/+4 and "<b>Deathrattle:</b> Summon a random 4-Cost minion."
	//使一个友方随从获得+4/+4和“<b>亡语：</b>随机召唤一个法力值消耗为（4）的随从。”
	class Sim_TLC_477 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (target != null)
			{
				p.minionGetBuffed(target, 4, 4);
				//TODO:不知道额外亡语这么写
				// target.deathrattle2 
			}
        }
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 只能是友方
			};
		}
	}
}
