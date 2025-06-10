using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：2
	//Safety Goggles
	//安全护目镜
	//Gain 6 Armor.Costs (0) if you don'thave any Armor.
	//获得6点护甲值。如果你没有护甲值，本牌的法力值消耗为（0）点。
	class Sim_TOY_907 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 为己方英雄获得6点护甲值
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, 6);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, 6);
            }
        }

    }
}
