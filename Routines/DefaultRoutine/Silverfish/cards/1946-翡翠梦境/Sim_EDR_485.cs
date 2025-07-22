using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：1 攻击力：1 生命值：1
	//Rotheart Dryad
	//腐心树妖
	//<b>Deathrattle:</b> Draw a minion that costs (7) or more.
	//<b>亡语：</b>抽一张法力值消耗大于或等于（7）点的随从牌。
	class Sim_EDR_485 : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
			foreach (var kvp in p.prozis.turnDeck)
            {
                // 获取卡片 ID 和卡片数据
                var deckCardId = kvp.Key;
                var deckCard = CardDB.Instance.getCardDataFromID(deckCardId);

				// 检查卡片是否属于指定种族
				if (deckCard.cost >= 7)
                {
					p.drawACard(deckCardId, m.own, true);
                }
            }

			// 没有找到符合条件的卡片
			return;
        }
		
	}
}
