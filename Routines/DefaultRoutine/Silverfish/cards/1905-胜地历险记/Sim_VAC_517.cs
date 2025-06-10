using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 德鲁伊 费用：3
	//Hiking Trail
	//远足步道
	//<b>Discover</b> a <b>Taunt</b> minion. After you gain Armor, reopen this.
	//<b>发现</b>一张<b>嘲讽</b>随从牌。在你获得护甲值后，重新开启本地标。
	class Sim_VAC_517 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 发现一张嘲讽随从牌
            if (triggerMinion.handcard.card.CooldownTurn == 0) p.drawACard(CardDB.cardIDEnum.None, true);
        }

    }
}
