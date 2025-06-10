using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_344 : SimTemplate //* 丹巴达尔桥 dunbaldarbridge
	{
		//在你召唤一个随从后，使其获得+2/+2。 持续3回合。
        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
            if (m.own == summonedMinion.own && m.entitiyID != summonedMinion.entitiyID)
            {
                p.minionGetBuffed(summonedMinion, 2, 2);
            }
        }	
        //还没有加附魔统计有没有3次
	}
}
