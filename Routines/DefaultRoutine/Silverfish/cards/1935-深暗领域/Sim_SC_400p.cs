using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 无效的 费用：2
	//Stimpack
	//强化剂
	//[x]Summon a 2/2Marine with <b>Taunt</b>.Give your Terranminions +2_Attack.
	//召唤一个2/2并具有<b>嘲讽</b>的陆战队员。使你的人族随从获得+2攻击力。
	class Sim_SC_400p : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_403t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			List<Minion> minions = ownplay ? p.ownMinions : p.enemyMinions;
			p.callKid(kid, pos, ownplay);
			foreach (Minion minion in minions)
			{
				if (minion.handcard.card.Terran)
					p.minionGetBuffed(minion, 2, 0);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1),
			};
		}

	}
}
