using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS3_020 : SimTemplate //* 伊利达雷审判官 Illidari Inquisitor
	{
        //<b>Rush</b>. After your hero attacks an enemy, this attacks it too.
        //<b>突袭</b>在你的英雄攻击一个敌人后，该随从也会攻击。
        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            p.minionAttacksMinion(own, target);
        }

    }
}
