using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 术士 费用：3
	//Ultralisk Cavern
	//雷兽窟
	//[x]Deal 1 damageto all enemies.<b>Deathrattle:</b> Summon an8/8 Ultralisk with <b>Rush</b>.
	//对所有敌人造成1点伤害。<b>亡语：</b>召唤一只8/8并具有<b>突袭</b>的雷兽。
	class Sim_SC_019 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_019);
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (triggerMinion.handcard.card.CooldownTurn == 0)
				p.allCharsOfASideGetDamage(!triggerMinion.own, 1);
		}

		public override void onDeathrattle(Playfield p, Minion m)
		{
			int pos = m.own ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, m.own);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1), // 需要一个空位
			};
		}

	}
}
