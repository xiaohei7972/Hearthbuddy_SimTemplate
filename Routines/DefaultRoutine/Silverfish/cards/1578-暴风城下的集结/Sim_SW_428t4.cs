using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_428t4 : SimTemplate //* 铁肤古夫 Guff the Tough
	{
        //[x]<b>Taunt</b>. <b>Battlecry:</b> Give yourhero +8 Attack this turn.Gain 8 Armor.
        //<b>嘲讽</b>，<b>战吼：</b>在本回合中使你的英雄获得+8攻击力。获得8点护甲值。

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                p.minionGetTempBuff(p.ownHero, 8, 0);
                p.minionGetArmor(p.ownHero, 8);
            }
            else
            {
                p.minionGetTempBuff(p.enemyHero, 8, 0);
                p.minionGetArmor(p.enemyHero, 8);

            }
        }
    }
}
