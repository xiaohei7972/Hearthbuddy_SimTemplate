using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_021 : SimTemplate //* 毒镖陷阱 Dart Trap
//<b>Secret:</b> After an opposing Hero Power is used, deal $5 damage to a random enemy.
//<b>奥秘：</b>在对方使用英雄技能后，随机对一个敌人造成$5点伤害。 
	{
		

		public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
			Minion target = null;
						
			if (temp.Count > 0) target = p.searchRandomMinion(temp, searchmode.searchHighAttackLowHP);
			if (target == null || ((ownplay) ? p.enemyHero : p.ownHero).Hp < 6) target = (ownplay) ? p.enemyHero : p.ownHero;
			p.minionGetDamageOrHeal(target, 5);
        }
    }
}