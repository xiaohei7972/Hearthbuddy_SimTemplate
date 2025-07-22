using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_005 : SimTemplate //* 王牌猎人 Big Game Hunter
	{
		//<b>Battlecry:</b> Destroy a minion with 7 or more Attack.
		//<b>战吼：</b>消灭一个攻击力大于或等于7的随从。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(target != null && target.Angr >= 7) p.minionGetDestroyed(target);
            else
            {
                switch (p.enemyHeroStartClass)
                {
                    case TAG_CLASS.WARRIOR: p.evaluatePenality += 4 * 3; break;
                    default: break;
                }
            }
		}



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_MIN_ATTACK, 7),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}