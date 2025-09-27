using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：2
	//Holy Springwater
	//神圣泉水
	//Restore #8 Health to a damaged character.Save any excess in a1-Cost Bottle.
	//为一个受伤的角色恢复#8点生命值。将超过目标生命值上限的治疗量存入法力值消耗为（1）的瓶子。
	class Sim_WW_395 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int heal = ownplay ? p.getSpellHeal(-8) : p.getEnemySpellHeal(-8);
				p.minionGetDamageOrHeal(target, heal);
			}
		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_DAMAGED_TARGET), // 只能是受伤目标
			};
		}
		
	}
}
