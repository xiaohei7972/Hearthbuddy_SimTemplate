using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：1 攻击力：1 生命值：3
	//Sock Puppet Slitherspear
	//滑矛布袋手偶
	//This minion's Attack is improved by your hero's.
	//本随从的攻击力随你的英雄的攻击力提高。
	class Sim_MIS_710 : SimTemplate
	{
        public override void onAuraStarts(Playfield p, Minion own)
        {
            // 当该随从进入场上时，其攻击力随英雄的攻击力提高
            if (own.own)
            {
                own.Angr += p.ownHero.Angr; // 英雄的攻击力加到随从的攻击力上
            }
            else
            {
                own.Angr += p.enemyHero.Angr; // 对方英雄的攻击力加到随从的攻击力上
            }
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            // 当该随从离场时，恢复其基础攻击力
            if (own.own)
            {
                own.Angr -= p.ownHero.Angr; // 恢复基础攻击力
            }
            else
            {
                own.Angr -= p.enemyHero.Angr;
            }
        }

        public override void onEnrageStart(Playfield p, Minion m)
        {
            // 当英雄的攻击力发生变化时，更新该随从的攻击力
            if (m.own)
            {
                m.Angr += p.ownHero.Angr;
            }
            else
            {
                m.Angr += p.enemyHero.Angr;
            }
        }

        public override void onEnrageStop(Playfield p, Minion m)
        {
            // 如果英雄的攻击力降低或恢复，调整该随从的攻击力
            if (m.own)
            {
                m.Angr -= p.ownHero.Angr;
            }
            else
            {
                m.Angr -= p.enemyHero.Angr;
            }
        }

    }
}
