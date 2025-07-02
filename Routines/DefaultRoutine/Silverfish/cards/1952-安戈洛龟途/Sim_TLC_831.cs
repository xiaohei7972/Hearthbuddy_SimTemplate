using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：0 生命值：3
	//Pterrordax Egg
	//翼手龙蛋
	//[x]<b>Deathrattle:</b> Summona 3/3 Pterrordax thatsteals 1 Health fromall other minions.
	//<b>亡语：</b>召唤一只3/3并会从所有其他随从处偷取1点生命值的翼手龙。
	class Sim_TLC_831 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_831t);
		public override void onDeathrattle(Playfield p, Minion m)
		{	
			List<Minion> minions = new List<Minion>();
			minions.AddRange(p.ownMinions);
			minions.AddRange(p.enemyMinions);
			int pos = m.own ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, m.zonepos - 1, m.own);
			minions.ForEach((minion) =>
			{
				p.minionGetBuffed(minion, 0, -1);
				p.minionGetBuffed(p.ownMinions[m.zonepos - 1], 0, 1);
			});
		}
		
	}
}
