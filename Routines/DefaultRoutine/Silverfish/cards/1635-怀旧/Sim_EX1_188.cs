using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_188 : SimTemplate //* 贫瘠之地饲养员 Barrens Stablehand
	{
		//<b>Battlecry:</b> Summon a random Beast.
		//<b>战吼：</b>随机召唤一只野兽。
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_120), temp.Count, own.own);
        }		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
