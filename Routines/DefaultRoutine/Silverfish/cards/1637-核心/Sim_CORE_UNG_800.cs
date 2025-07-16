using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：2 攻击力：2 生命值：3
	//Terrorscale Stalker
	//恐鳞追猎者
	//<b>Battlecry:</b> Trigger a friendly minion's <b>Deathrattle</b>.
	//<b>战吼：</b>触发一个友方随从的<b>亡语</b>。
	class Sim_CORE_UNG_800 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null && target.own)
			{
				target.handcard.card.sim_card.onDeathrattle(p, target);
			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_DEATHRATTLE), // 目标只能是亡语随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 没有目标时也能用
            };
		}

	}
}
