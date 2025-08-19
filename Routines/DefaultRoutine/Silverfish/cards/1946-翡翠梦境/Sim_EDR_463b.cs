using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：2
	//Controlling Vines
	//控制藤蔓
	//Summon a random2-Cost minion.
	//随机召唤一个法力值消耗为（2）的随从。
	class Sim_EDR_463b : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

			CardDB.Card kid = p.getRandomCardForManaMinion(2);
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);

		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), // 需求选择一个空位

            };
		}
		
	}
}
