using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：6 攻击力：6 生命值：5
	//Crabatoa
	//可拉巴托亚
	//<b>Colossal +2</b>Your Crabatoa Claws have +2 Attack.
	//<b>巨型+2</b>你的可拉巴托亚的钳子拥有+2攻击力。
	class Sim_TSC_937 : SimTemplate
	{
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_937t);
		CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_937t);
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_937t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid1, pos-1, ownplay);
			p.callKid(kid2, pos, ownplay);
		}


		public override void onAuraStarts(Playfield p, Minion m)
		{
			List<Minion> minions = m.own ? p.ownMinions : p.enemyMinions;
			minions.ForEach((m => { if (m.handcard.card == kid1 || m.handcard.card == kid2 || m.handcard.card == weapon) p.minionGetTempBuff(m, 2, 0); }));
		}
		public override void onAuraEnds(Playfield p, Minion m)
		{
			List<Minion> minions = m.own ? p.ownMinions : p.enemyMinions;
			minions.ForEach((m => { if (m.handcard.card == kid1 || m.handcard.card == kid2 || m.handcard.card == weapon) p.minionGetTempBuff(m, 2, 0); }));
		}

	}
}
