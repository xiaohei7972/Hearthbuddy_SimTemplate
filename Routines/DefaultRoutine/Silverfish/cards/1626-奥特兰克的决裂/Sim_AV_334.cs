using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_334 : SimTemplate //* 雷矛军用山羊 stormpikebattleram
	{
		//<b>突袭</b>，<b>亡语：</b>你的下一张野兽牌法力值消耗减少（2）点。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own) p.ownBeastCostLessOnce++;
        }
		
	}
}
