using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：5
	//Sleep Paralysis
	//麻痹睡眠
	//[x]<b>Choose One - </b>Summontwo 3/6 Demons with<b>Taunt</b> that can't attack; orDestroy an enemy minion.
	//<b>抉择：</b>召唤两个3/6并具有<b>嘲讽</b>且无法攻击的恶魔；或者消灭一个敌方随从。
	class Sim_EDR_490 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_490t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, place, ownplay, false);
				p.callKid(kid, place, ownplay);
			}

			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				if (target != null)
				{
					p.minionGetDestroyed(target);
				}
			}


		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需求选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),   // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 目标只能是敌方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 没有目标时也能使用
            };
		}

	}
}
