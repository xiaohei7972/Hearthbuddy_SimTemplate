using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_127 : SimTemplate //* 火炮弹幕 Cannon Barrage
//[x]Deal $3 damage to arandom enemy. Repeatfor each of your Pirates.
//随机对一个敌人造成$3点伤害。你每有一个海盗，重复一次。 
	{
        

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int times = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.allCharsOfASideGetRandomDamage(!ownplay, times);
        }
    }
}