using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：3
	//Asphyxiate
	//窒息
	//Destroy the highest Attack enemy minion.
	//消灭攻击力最高的敌方随从。
	class Sim_RLK_Prologue_RLK_087 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

			Minion minion = p.searchRandomMinion(ownplay ? p.enemyMinions : p.ownMinions, searchmode.searchHighestAttack);
			if (minion != null)
			{
				p.minionGetDestroyed(minion);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS,1), // 对面场面最少需要一个随从
				
            };
		}
		
	}
}
