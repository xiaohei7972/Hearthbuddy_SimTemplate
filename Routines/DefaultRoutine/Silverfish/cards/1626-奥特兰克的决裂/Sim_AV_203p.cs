using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_203p : SimTemplate //* 手法娴熟 sleightofhand
	{
		//<b>英雄技能</b> 在本回合中，你使用的下一张牌法力值消耗减少（2）点。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            (ownplay ? p.ownHero : p.enemyHero).enchs += CardDB.cardIDEnum.AV_203pe;
        }
		
	}
}
