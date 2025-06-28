using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：2
	//Mark of Ursol
	//乌索尔印记
	//[x]Choose a minion. If it'san enemy, set its statsto 1/1. If it's friendly, setits stats to 3/3 instead.
	//选择一个随从。如果是敌方随从，将其属性值变为1/1；如果是友方随从，改为将其属性值变为3/3。
	class Sim_EDR_252 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (target != null)
			{
				if (target.own)
				{
					target.Angr = 3;
					target.Hp = 3;
				}
				else
				{
					target.Angr = 1;
					target.Hp = 1;
				}
			}
        }

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
			};
		}
		
	}
}
