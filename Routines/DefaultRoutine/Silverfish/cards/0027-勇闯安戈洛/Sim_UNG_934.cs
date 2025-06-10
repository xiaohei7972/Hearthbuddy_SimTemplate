using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_934 : SimTemplate //* 火羽之心 Fire Plume's Heart
//[x]<b>Quest:</b> Play7 <b>Taunt</b> minions.<b>Reward:</b> Sulfuras.
//<b>任务：</b>使用七张具有<b>嘲讽</b>的随从牌。<b>奖励：</b>萨弗拉斯。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 2) p.evaluatePenality -= 30;
        }
    }
}