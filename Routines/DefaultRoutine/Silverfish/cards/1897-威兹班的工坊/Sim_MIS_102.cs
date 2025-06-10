using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：3
	//Return Policy
	//退货政策
	//<b>Discover</b> a friendly <b>Deathrattle</b> card you've played this game.Trigger its <b>Deathrattle</b>.
	//<b>发现</b>一张你在本局对战中使用过的友方<b>亡语</b>牌。触发其<b>亡语</b>。
	class Sim_MIS_102 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 获取玩家本局对战中使用过的友方亡语牌列表
            List<CardDB.cardIDEnum> playedDeathrattleCards = ownplay ? p.ownPlayedDeathrattleCards : p.enemyPlayedDeathrattleCards;

            // 如果没有使用过亡语牌，直接返回
            if (playedDeathrattleCards.Count == 0)
            {
                return;
            }

            // 发现过程中选择的卡牌在 Hrtprozis.Instance.enchs 中
            if (Hrtprozis.Instance.enchs.Count > 0)
            {
                CardDB.cardIDEnum selectedCardID = Hrtprozis.Instance.enchs.LastOrDefault(); // 取出选择的卡牌ID

                if (playedDeathrattleCards.Contains(selectedCardID))
                {
                    // 获取选择的卡牌信息
                    CardDB.Card selectedCard = CardDB.Instance.getCardDataFromID(selectedCardID);

                    // 创建一个虚拟随从来触发其亡语效果
                    Minion minion = new Minion { handcard = new Handmanager.Handcard { card = selectedCard }, own = ownplay };

                    // 触发亡语效果
                    selectedCard.sim_card.onDeathrattle(p, minion);
                }
            }
        }
    }
}
