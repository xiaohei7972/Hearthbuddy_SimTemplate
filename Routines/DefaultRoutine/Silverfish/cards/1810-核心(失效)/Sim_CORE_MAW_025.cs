using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：2 攻击力：1 生命值：3
	//Attorney-at-Maw
	//噬渊律师
	//<b>Choose One -</b> <b>Silence</b>a minion; or Give a minion <b>Immune</b> this turn.
	//<b>抉择：</b><b>沉默</b>一个随从；或者使一个随从在本回合中获得<b>免疫</b>。
	class Sim_CORE_MAW_025 : SimTemplate
	{
		public override void onCardPlay(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
				{
					p.minionGetSilenced(target);
				}
				if (choice == 2 || (p.ownFandralStaghelm > 0 && own.own))
				{
					target.immune = true;
				}
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 无目标时也可以使用
			};
		}
		
	}
}
