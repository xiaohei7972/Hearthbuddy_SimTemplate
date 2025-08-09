using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：5
	//TREEEES!!!
	//树群来袭
	//Choose a minion. Summon four 2/2 Treants that attack it.
	//选择一个随从。召唤四个2/2的树人攻击该随从。
	class Sim_TLC_230 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_230t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				List<Minion> minions = new List<Minion>();
				for (int i = 0; i < 4; i++)
				{
					int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
					if (pos < 7)
					{
						p.callKid(kid, pos, ownplay);
						minions.Add(p.ownMinions[pos - 1]);
					}
				}
				foreach (Minion minion in minions)
				{
					p.minionAttacksMinion(minion, target);
				}
			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				// new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1),
			};
		}

	}
}
