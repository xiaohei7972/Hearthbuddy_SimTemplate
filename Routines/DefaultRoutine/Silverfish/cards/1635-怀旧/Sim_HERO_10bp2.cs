using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_HERO_10bp2 : SimTemplate //* 恶魔之咬 Demon's Bite
	{
		 public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
		//[x]<b>Hero Power</b>+2 Attack this turn.
		//<b>英雄技能</b>在本回合中获得+2攻击力。
		if (ownplay)
            {
                p.minionGetTempBuff(p.ownHero, 2, 0);
                p.minionGetArmor(p.ownHero,2);
            }
            else
            {
                p.minionGetTempBuff(p.enemyHero, 2, 0);
                p.minionGetArmor(p.enemyHero,2);
            }
		}


	}
}