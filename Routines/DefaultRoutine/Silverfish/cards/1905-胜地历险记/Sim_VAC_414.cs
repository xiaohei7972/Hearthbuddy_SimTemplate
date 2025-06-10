using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：3
	//Hot Coals
	//炽热火炭
	//[x]Deal $2 damage to allenemies. If your herotook damage this turn,deal $1 more.
	//对所有敌人造成$2点伤害。如果你的英雄在本回合受到过伤害，再造成$1点。
	class Sim_VAC_414 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 基础伤害为2点
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

            // 如果英雄在本回合受到过伤害，额外增加1点伤害
            if ((ownplay && p.ownHero.anzGotDmg > 0) || (!ownplay && p.enemyHero.anzGotDmg > 0))
            {
                dmg += (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            }

            // 对所有敌方角色（随从和英雄）造成伤害
            p.allCharsOfASideGetDamage(!ownplay, dmg);
        }

    }
}
