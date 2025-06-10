using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_277 : SimTemplate //* 毁灭之种 seedsofdestruction
	{
		//将四张裂隙洗入你的牌库。当抽到裂隙时，召唤一个3/3的恐惧小鬼。
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own) p.ownDeckSize += 4;
            else p.enemyDeckSize += 4;

        }
		
	}
}
