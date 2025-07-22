using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：4
	//Camouflage Mount
	//迷彩坐骑
	//Give a minion +3/+3 and a random <b>Bonus Effect</b>. When it dies, summon a Chameleon.
	//使一个随从获得+3/+3和一项随机<b>额外效果</b>。当该随从死亡时，召唤一只变色龙。
	class Sim_WW_810 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 3, 3);
			}
		}


		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 只能是友方
            };
		}
		
	}
}
