using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：1
	//Lock On
	//锁定
	//Set a minion’s Health to 1. Your next <b>Starship</b>launch costs (2) less.
	//将一个随从的生命值变为1。你的下一次<b>星舰</b>发射的法力值消耗减少（2）点。
	class Sim_SC_407 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
                p.minionSetLifetoX(target, 1);
				//TODO:星舰减费以后再说
			}

		}

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标只能是随从

			};

		}
		
	}
}
