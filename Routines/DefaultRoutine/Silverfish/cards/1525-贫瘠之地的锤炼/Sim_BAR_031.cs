using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_031 : SimTemplate //* 赤鳞迅猛龙 Sunscale Raptor
	{
        //<b>Frenzy:</b> Shuffle a Sunscale Raptor into your deck with permanent +2/+1.
        //<b>暴怒：</b>将一张赤鳞迅猛龙洗入你的牌库并使其永久获得+2/+1。
        public override void onEnrageStart(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.ownDeckSize++;
            }
            else
            {
                p.enemyDeckSize++;
            }
        }
    }
}
