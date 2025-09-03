using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：7
	//Guard Duty
	//守卫执勤
	//Summon a random6, 4, and 2-Cost<b>Taunt</b> minion.
	//随机召唤法力值消耗为（6），（4）和（2）的<b>嘲讽</b>随从各一个。
	class Sim_DINO_433 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(p.getRandomCardForManaMinion(6), pos, ownplay);
			p.callKid(p.getRandomCardForManaMinion(4), pos, ownplay);
			p.callKid(p.getRandomCardForManaMinion(2), pos, ownplay);

		}
		
		public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1),
			};
        }
		
	}
}
