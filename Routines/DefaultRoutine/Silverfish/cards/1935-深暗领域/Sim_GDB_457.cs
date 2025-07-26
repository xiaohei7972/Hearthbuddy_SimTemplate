using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：2
	//Lightspeed
	//光速
	//Give a minion+1/+2 and <b>Rush</b>.Repeatable this turn.
	//使一个随从获得+1/+2和<b>突袭</b>。在本回合可以重复使用。
	class Sim_GDB_457 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				target.Angr += 1;
				target.Hp += 2;
				p.minionGetRush(target);
				//重复使用再想想
			}

		}

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标只能是随从

			};

		}
		
	}
}
