using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：1 攻击力：1 生命值：2
	//Charred Chameleon
	//火炭变色龙
	//<b>Battlecry:</b> If you've usedyour Hero Power this turn,give a friendly minion+1/+2 and <b>Rush</b>.
	//<b>战吼：</b>如果你在本回合中使用过英雄技能，使一个友方随从获得+1/+2和<b>突袭</b>。
	class Sim_FIR_908 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{	if (p.ownMinions.Count == 0) return;
			if (p.anzUsedOwnHeroPower > 0)
			{
				p.minionGetBuffed(target, 1, 2);
				p.minionGetRush(target);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{ 
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //目标只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE) // 没有目标时也可以使用
			};
		}

	}
}
