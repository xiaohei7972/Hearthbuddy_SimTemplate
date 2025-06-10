using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：3 攻击力：5 生命值：6
	//Malefic Rook
	//凶魔城堡
	//<b>Battlecry:</b> AttackYOUR hero.
	//<b>战吼：</b>攻击<b>你的</b>英雄。
	class Sim_TOY_526 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 如果是己方随从触发战吼，则攻击己方英雄
            if (own.own)
            {
                int damage = own.Angr;
                p.minionGetDamageOrHeal(p.ownHero, damage); // 让随从对己方英雄造成伤害
            }
            else // 如果是敌方随从触发战吼，则攻击敌方英雄
            {
                int damage = own.Angr;
                p.minionGetDamageOrHeal(p.enemyHero, damage); // 让随从对敌方英雄造成伤害
            }
        }
    }
}
