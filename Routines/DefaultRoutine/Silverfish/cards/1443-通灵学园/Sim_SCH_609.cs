using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_609 : SimTemplate //* 优胜劣汰 Survival of the Fittest
	{
		//Give +4/+4 to all minions in your hand, deck, and battlefield.
		//使你手牌，牌库以及战场中的所有随从获得+4/+4。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if(ownplay){
				// 场地
				foreach (Minion m in p.ownMinions)
				{
					p.minionGetBuffed(m, 4, 4);
				}
				// 手牌
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					hc.addattack += 4;
					hc.addHp += 4;
					p.anzOwnExtraAngrHp += 8;
				}
				// 卡组
				p.deckAngrBuff += 4;
				p.deckHpBuff += 4;
				p.evaluatePenality -= 5;
			}
		}
	}
}
