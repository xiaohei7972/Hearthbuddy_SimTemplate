using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 中立 费用：6 攻击力：4 耐久度：4
	//Quel'Delar
	//奎尔德拉
	//After your hero attacks, deal 4 damage to all_enemies.
	//在你的英雄攻击后，对所有敌人造成4点伤害。
	class Sim_VAC_464t31 : SimTemplate
	{

        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            // 检查英雄是否为持有者，并且该武器是奎尔德拉
            if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.VAC_464t31)
            {
                int damage = 4;

                // 对所有敌方角色（英雄和随从）造成4点伤害
                p.allCharsOfASideGetDamage(false, damage); // false表示对敌方角色造成伤害
            }
            else if (!own.own && p.enemyWeapon.card.cardIDenum == CardDB.cardIDEnum.VAC_464t31)
            {
                int damage = 4;

                // 对所有友方角色（英雄和随从）造成4点伤害（如果敌方使用此武器）
                p.allCharsOfASideGetDamage(true, damage); // true表示对友方角色造成伤害
            }
        }
    }
}
