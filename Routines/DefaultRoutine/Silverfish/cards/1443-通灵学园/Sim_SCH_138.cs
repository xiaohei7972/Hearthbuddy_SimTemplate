using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_138 : SimTemplate //* 威能祝福 Blessing of Authority
	{
		//Give a minion +8/+8. It_can't attack heroes this turn.
		//使一个随从获得+8/+8，在本回合中无法攻击英雄。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)//卡牌使用
        {
			if(target!=null)
		    {
                if (target.Ready && !target.cantAttackHeroes && p.enemyMinions.Count == 0 && !(p.enemyHero.immune || p.enemyHero.stealth || p.enemyHero.untouchable)) p.evaluatePenality += 1000;
                p.minionGetBuffed(target, 8, 8);
                target.cantAttackHeroes = true;
			}
        }			

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
