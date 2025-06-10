using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：1
	//Eudora's Treasure Hunt
	//尤朵拉的猎宝之旅
	//<b>Sidequest:</b> Play 3 cards from other classes.<b>Reward:</b> <b>Discover</b> two amazing pieces of loot!
	//<b>支线任务：</b>使用3张其他职业的牌。<b>奖励：</b><b>发现</b>两件神奇的战利品！
	class Sim_VAC_464t : SimTemplate
	{
        public override void onQuestCompleteTrigger(Playfield p, bool own)
        {
            // 任务完成时，触发发现效果
            p.drawACard(CardDB.cardIDEnum.None, own, true);
            p.drawACard(CardDB.cardIDEnum.None, own, true);
        }

    }
}
