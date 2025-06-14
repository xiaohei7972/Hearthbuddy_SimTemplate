using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：4 生命值：6
	//Carnivorous Cubicle
	//食肉格块
	//[x]<b>Battlecry:</b> Destroy afriendly minion.Summon a copy of it at the end of your turns.
	//<b>战吼：</b>消灭一个友方随从。在你的回合结束时，召唤一个它的复制。
	class Sim_WORK_042 : SimTemplate
	{
		// CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardNameEN.unknown);
		CardDB.Card kid = null;
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (p.ownMinions.Count != 0)
			{
				p.minionGetDestroyed(target);
				kid = CardDB.Instance.getCardDataFromID(target.name);
			}
		}

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
			if (kid == null) return;
			
			if (triggerEffectMinion.own == turnEndOfOwner)
			{
				int pos = triggerEffectMinion.own ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, true);
			}
        }
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE) // 没有目标时也可以使用

			};

		}
	}
}
