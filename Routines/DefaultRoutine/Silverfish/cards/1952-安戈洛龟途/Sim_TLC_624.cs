using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：6 攻击力：5 生命值：7
	//Nablya, the Watcher
	//观察者娜博亚
	//[x]<b>Battlecry:</b> Summon copies of your damaged minions.Give the copies <b>Rush</b>.
	//<b>战吼：</b>召唤你受伤的随从的复制，使复制获得<b>突袭</b>。
	class Sim_TLC_624 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			List<Minion> minions = new List<Minion>();
			foreach (Minion minion in own.own ? p.ownMinions : p.enemyMinions)
			{
				if (minion.wounded && minion.entitiyID != own.entitiyID)
					minions.Add(minion);
			}
			foreach (Minion minion in minions)
			{
				p.callKid(minion.handcard.card, minion.zonepos, own.own);
				
			}

		}

	}
}
