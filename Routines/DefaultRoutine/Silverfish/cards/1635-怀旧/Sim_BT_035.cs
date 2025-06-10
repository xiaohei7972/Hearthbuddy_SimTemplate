using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_035 : SimTemplate //* 混乱打击 Chaos Strike
	{
        //Give your hero +2_Attack this turn. Draw a card.
        //在本回合中，使你的英雄获得+2攻击力。抽一张牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            //[x]<b>Hero Power</b>+2 Attack this turn.
            //<b>英雄技能</b>在本回合中获得+1攻击力。
            var hero = ownplay ? p.ownHero : p.enemyHero;
            p.minionGetTempBuff(hero, 2, 0);
            hero.updateReadyness();
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }

    }
}
