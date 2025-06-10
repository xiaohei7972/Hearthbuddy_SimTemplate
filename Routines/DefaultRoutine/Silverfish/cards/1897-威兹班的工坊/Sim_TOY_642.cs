using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：4 攻击力：3 生命值：3
	//Ball Hog
	//球霸野猪人
	//[x]<b>Lifesteal</b><b>Battlecry and Deathrattle:</b>Deal 3 damage to thelowest Health enemy.
	//<b>吸血</b>。<b>战吼，亡语：</b>对生命值最低的敌人造成3点伤害。
	class Sim_TOY_642 : SimTemplate
	{

        // 战吼效果
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            DealDamageToLowestHealthEnemy(p, own.own, 3);
        }

        // 亡语效果
        public override void onDeathrattle(Playfield p, Minion m)
        {
            DealDamageToLowestHealthEnemy(p, m.own, 3);
        }

        /// <summary>
        /// 对生命值最低的敌人造成伤害
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownSide"></param>
        /// <param name="damage"></param>
        private void DealDamageToLowestHealthEnemy(Playfield p, bool ownSide, int damage)
        {
            List<Minion> enemyMinions = ownSide ? p.enemyMinions : p.ownMinions;
            Minion lowestHealthMinion = null;
            int lowestHealth = int.MaxValue;

            // 找到生命值最低的敌方随从
            foreach (Minion m in enemyMinions)
            {
                if (m.Hp < lowestHealth)
                {
                    lowestHealth = m.Hp;
                    lowestHealthMinion = m;
                }
            }

            // 检查敌方英雄的生命值是否比最低的随从还低
            int enemyHeroHealth = ownSide ? p.enemyHero.Hp : p.ownHero.Hp;
            if (enemyHeroHealth < lowestHealth)
            {
                // 如果敌方英雄的生命值最低，对英雄造成伤害
                if (ownSide)
                {
                    p.minionGetDamageOrHeal(p.enemyHero, damage);
                }
                else
                {
                    p.minionGetDamageOrHeal(p.ownHero, damage);
                }
            }
            else if (lowestHealthMinion != null)
            {
                // 如果某个随从的生命值最低，对该随从造成伤害
                p.minionGetDamageOrHeal(lowestHealthMinion, damage);
            }
        }
    }
}
