using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 恶魔猎手 费用：4
	//Dangerous Cliffside
	//惊险悬崖
	//[x]Summon two 1/1Pirates with <b>Charge</b>.After your hero attacks,reopen this.
	//召唤两个1/1并具有<b>冲锋</b>的海盗。在你的英雄攻击后，重新开启本地标。
	class Sim_VAC_929 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            if (triggerMinion.handcard.card.CooldownTurn == 0)
            {
                // 召唤两个1/1具有冲锋的海盗
                summonPirate(p);
                summonPirate(p);
            }
        }

        private void summonPirate(Playfield p)
        {
            // 假设卡牌ID为 "PIRATE_CARD_ID"，需要替换为实际的海盗卡牌ID
            CardDB.Card pirateCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_926t);
            int position = p.ownMinions.Count; // 召唤的位置在己方随从的最后
            p.callKid(pirateCard, position, true); // true 表示是己方随从
        }

    }
}
