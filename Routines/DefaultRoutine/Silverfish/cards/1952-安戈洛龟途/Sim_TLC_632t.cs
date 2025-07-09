using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 战士 费用：2
	//DIE, INSECT!
	//死吧，虫子！
	//Deal $8 damage to a random enemy.<i>(Two uses left!)</i>
	//随机对一个敌人造成$8点伤害。<i>（还可使用两次！）</i>
	class Sim_TLC_632t : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				target = p.getEnemyCharTargetForRandomSingleDamage(8);
			}
			else
			{
				target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack);
				if (target == null) target = p.ownHero;
			}
			p.minionGetDamageOrHeal(target, 8, true);
			p.setNewHeroPower(CardDB.cardIDEnum.TLC_632t2, ownplay);
		}

	}
}
