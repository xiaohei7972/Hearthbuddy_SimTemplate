using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Water Source
	//喷涌水源
	//Restore #3 Health.Draw a card.
	//恢复#3点生命值。抽一张牌。
	class Sim_WW_001t2 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int heal = ownplay ? p.getSpellHeal(-3) : p.getEnemySpellHeal(-3);
				p.minionGetDamageOrHeal(target, heal);
				p.drawACard(CardDB.cardIDEnum.None, ownplay);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2. REQ_TARGET_TO_PLAY),
			};
		}
		
	}
}
