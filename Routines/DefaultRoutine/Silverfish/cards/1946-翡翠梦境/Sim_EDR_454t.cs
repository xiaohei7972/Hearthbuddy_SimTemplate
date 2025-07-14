using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：1 攻击力：0 生命值：2
	//Horrible Egg
	//恐怖的龙蛋
	//<b>Deathrattle:</b> Summon {0}.
	//<b>亡语：</b>召唤{0}。
	class Sim_EDR_454t : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
		{
			if (m.deathrattle2 != null)
			{
				CardDB.Card kid = CardDB.Instance.getCardDataFromID(m.deathrattle2.cardIDenum);
				Helpfunctions.Instance.logg("龙蛋亡语是：" + m.deathrattle2.nameCN);
				int pos = m.own ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, m.own);
			}
		}

	}
}
