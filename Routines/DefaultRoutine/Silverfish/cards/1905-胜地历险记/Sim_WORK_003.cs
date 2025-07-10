using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：4
	//Vacation Planning
	//假期规划
	//Restore #4 Health. Summon 3 Silver Hand Recruits. Draw 2 cards.
	//恢复#4点生命值。召唤3个白银之手新兵。抽两张牌。
	class Sim_WORK_003 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int heal = ownplay ? p.getSpellHeal(4) : p.getEnemySpellHeal(4);
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				// 对目标恢复4点生命值
				p.minionGetDamageOrHeal(target, -heal);
				//召唤3个白银之手骑兵
				p.callKid(kid, pos, ownplay);
				p.callKid(kid, pos, ownplay);
				p.callKid(kid, pos, ownplay);
				// 抽两张牌
				p.drawACard(CardDB.cardNameEN.unknown, ownplay);
				p.drawACard(CardDB.cardNameEN.unknown, ownplay);

			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
			};
		}

	}
}
