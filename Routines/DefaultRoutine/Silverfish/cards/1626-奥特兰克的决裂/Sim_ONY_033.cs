using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：6
	//Impfestation
	//小鬼侵染
	//Summon a 3/3Dread Imp to attack each enemy minion.
	//每有一个敌方随从，便召唤一个3/3的恐惧小鬼并使其攻击对应敌方随从。
	class Sim_ONY_033 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_914t3);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			foreach (Minion minion in ownplay ? p.ownMinions : p.enemyMinions)
			{
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, ownplay);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1), // 需要一个空位
			};
		}

	}
}
