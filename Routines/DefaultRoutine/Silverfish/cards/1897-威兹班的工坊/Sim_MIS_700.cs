using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Whack-A-Gnoll
	//痛打豺狼人
	//<b>Discover</b> a Paladin weapon from the past. Give it +1/+1.
	//<b>发现</b>一张来自过去的圣骑士武器牌，使其获得+1/+1。
	class Sim_MIS_700 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 假设 `Hrtprozis.Instance.enchs` 中已经存储了玩家通过发现选择的卡牌 ID
            if (Hrtprozis.Instance.enchs.Count > 0)
            {
                CardDB.cardIDEnum selectedCardID = Hrtprozis.Instance.enchs.LastOrDefault(); // 玩家选择的卡牌ID

                // 获取选择的武器卡牌数据
                CardDB.Card selectedCard = CardDB.Instance.getCardDataFromID(selectedCardID);

                // 增加武器的攻击力和耐久度
                selectedCard.Attack += 1;
                selectedCard.Durability += 1;

                // 将增强后的武器牌加入手牌
                p.drawACard(selectedCardID, ownplay, true);
            }
        }
    }
}
