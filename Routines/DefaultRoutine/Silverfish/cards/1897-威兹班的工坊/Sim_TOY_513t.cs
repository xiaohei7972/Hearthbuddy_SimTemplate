using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：1 攻击力：1 生命值：1
	//Sand Art Elemental
	//沙画元素
	//[x]<b>Mini</b><b>Battlecry:</b> Give your hero+1 Attack and <b>Windfury</b>this turn.
	//<b>微型</b><b>战吼：</b>在本回合中，使你的英雄获得+1攻击力和<b>风怒</b>。
	class Sim_TOY_513t : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 给予英雄+1攻击力
            if (own.own)
            {
                p.minionGetBuffed(p.ownHero, 1, 0); // 给英雄+1攻击力
                p.ownHero.windfury = true; // 给英雄本回合风怒效果
            }
            else
            {
                p.minionGetBuffed(p.enemyHero, 1, 0); // 给敌方英雄+1攻击力
                p.enemyHero.windfury = true; // 给敌方英雄本回合风怒效果
            }
        }

    }
}
