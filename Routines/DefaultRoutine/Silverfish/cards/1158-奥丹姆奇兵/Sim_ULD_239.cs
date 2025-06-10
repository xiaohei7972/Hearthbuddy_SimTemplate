using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ULD_239 : SimTemplate //* 火焰结界 Flame Ward
    {
        //<b>Secret:</b> After a minion attacks your hero, deal $3 damage to all enemy minions.
        //<b>奥秘：</b>在一个随从攻击你的英雄后，对所有敌方随从造成$3点伤害。
        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            if (ownplay)
            {
                p.minionGetDamageOrHeal(p.ownHero, number); // Todo:待确认，和爆炸陷阱不同，英雄要掉血，number传参进来攻击者攻击者
                for (int i = 0; i < p.ownSecretsIDList.Count; i++) //防奥秘，更新已方奥秘列表，这步很重要，影响牌面评分
                {
                    if (p.ownSecretsIDList[i] == CardDB.cardIDEnum.ULD_239)
                    {
                        p.ownSecretsIDList.RemoveAt(i);
                        break;
                    }
                }
            }
            else
            {
                p.minionGetDamageOrHeal(p.enemyHero, number);
                p.enemySecretCount--;
                for (int i = 0; i < p.enemySecretList.Count; i++) //防奥秘，更新敌方奥秘列表，这步很重要，影响牌面评分
                {
                    if (p.enemySecretList[i].canBe_flameward)
                    {
                        p.ownSecretsIDList.RemoveAt(i);
                        break;
                    }
                }
            }
            p.allMinionOfASideGetDamage(!ownplay, dmg);
        }

    }
}