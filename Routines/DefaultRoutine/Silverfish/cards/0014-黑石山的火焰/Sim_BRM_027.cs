using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRM_027 : SimTemplate //* 管理者埃克索图斯 Majordomo Executus
//<b>Deathrattle:</b> Replace your hero with Ragnaros the Firelord.
//<b>亡语：</b>用炎魔之王拉格纳罗斯替换你的英雄。 
	{
		
		        
		public override void onDeathrattle(Playfield p, Minion m)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.BRM_027p, m.own); 

			if (m.own)
            {
                p.ownHeroName = HeroEnum.ragnarosthefirelord;
                p.ownHero.Hp = 8;
                p.ownHero.maxHp = 8;
            }
            else
            {
                p.enemyHeroName = HeroEnum.ragnarosthefirelord;
                p.enemyHero.Hp = 8;
                p.enemyHero.maxHp = 8;
            }
        }
	}
}