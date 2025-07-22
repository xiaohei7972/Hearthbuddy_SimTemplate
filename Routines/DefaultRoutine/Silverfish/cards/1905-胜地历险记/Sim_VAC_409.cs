using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 猎人 费用：2
	//Parrot Sanctuary
	//鹦鹉乐园
	//[x]Your next <b>Battlecry</b>minion costs (1) less.After you play a <b>Battlecry</b>minion, reopen this.
	//你的下一张<b>战吼</b>随从牌的法力值消耗减少（1）点。在你使用一张<b>战吼</b>随从牌后，重新开启本地标。
	class Sim_VAC_409 : SimTemplate
	{

        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 激活法力值减少效果
            if (triggerMinion.handcard.card.CooldownTurn == 0) p.parrotSanctuaryCount += 1;
        }
    }
}
