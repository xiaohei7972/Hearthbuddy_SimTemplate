using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_591 : SimTemplate //* 奥金尼灵魂祭司 Auchenai Soulpriest
//Your cards and powers that restore Health now deal damage instead.
//你的恢复生命值的牌和技能改为造成等量的伤害。 
	{


        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnAuchenaiSoulpriest++;
            }
            else
            {
                p.anzEnemyAuchenaiSoulpriest++;
            }

        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnAuchenaiSoulpriest--;
            }
            else
            {
                p.anzEnemyAuchenaiSoulpriest--;
            }
        }


	}
}