using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 潜行者 费用：1
	//Spark of Light
	//圣光耀闪
	//Restore #2 Health. <b>Manathirst (8):</b> Restore #4 Health instead.
	//恢复#2点生命值。<b>法力渴求（8）：</b>改为恢复#4点。
	class Sim_THD_022hp : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			if (target != null)
			{
				int heal = ownplay ? p.getSpellHeal(2) : p.getEnemySpellHeal(2);
				if (p.ownMaxMana >= hc.card.Manathirst)
					heal = ownplay ? p.getSpellHeal(4) : p.getEnemySpellHeal(4);

				p.minionGetDamageOrHeal(target, -heal);
			}
		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),	// 需要一个目标
			};
		}

	}
}
