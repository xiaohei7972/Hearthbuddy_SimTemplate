using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：1
	//Burning Heart
	//灼燃之心
	//Deal $2 damage to a minion. If it survives, give your hero +3 Attack this turn.
	//对一个随从造成$2点伤害，如果它依然存活，使你的英雄在本回合中获得+3攻击力。
	class Sim_DEEP_011 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 对目标随从造成2点伤害
            int damage = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.minionGetDamageOrHeal(target, damage);

            // 检查目标随从是否存活
            if (target.Hp > 0 && !target.wounded)
            {
                // 如果目标随从存活，给予英雄+3攻击力
                if (ownplay)
                {
                    p.minionGetTempBuff(p.ownHero, 3, 0);
                }
                else
                {
                    p.minionGetTempBuff(p.enemyHero, 3, 0);
                }
            }
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要目标   
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 需要随从目标
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 需要敌方目标
            };
        }
    }
}
