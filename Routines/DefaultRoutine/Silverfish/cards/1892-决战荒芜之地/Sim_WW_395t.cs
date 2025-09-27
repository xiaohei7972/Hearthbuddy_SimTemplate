using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：1
	//Bottled Springwater
	//瓶装泉水
	//Restore the excess Health.@Restore #{0} Health.
	//恢复余下的生命值。@恢复#{0}点生命值。
	class Sim_WW_395t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
        {
            if (target != null)
			{
				int heal = ownplay ? p.getSpellHeal(-hc.card.TAG_SCRIPT_DATA_NUM_1) : p.getEnemySpellHeal(-hc.card.TAG_SCRIPT_DATA_NUM_1);
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
