using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_864 : SimTemplate //* 第一次接触 First Contact
//Summon two random 1-Cost minions. Overload: (1)
//随机召唤两个法力值消耗为（1）的随从。过载：（1 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count; // 随机召唤位置
            p.callKid(p.getRandomCardForManaMinion(1), pos, ownplay); // 随机召唤1费随从
            p.callKid(p.getRandomCardForManaMinion(1), pos, ownplay); // 随机召唤1费随从

            if (ownplay) p.ueberladung += 1; // 过载

		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), // 需要一个空位
            };
        }
	}
}