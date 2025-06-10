using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：3 攻击力：2 生命值：1
	//Toysnatching Geist
	//玩具盗窃恶鬼
	//[x]<b>Gigantify</b><b>Battlecry:</b> <b>Discover</b> anUndead. Reduce its Cost bythis minion's Attack.
	//<b>扩大</b><b>战吼：</b><b>发现</b>一张亡灵牌，使其降低等同于本随从攻击力的法力值消耗。
	class Sim_MIS_006 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 触发扩大效果，抽一张衍生物牌
            CardDB.cardIDEnum gigantifyCardID = CardDB.cardIDEnum.MIS_006t; // 衍生物牌的 ID 是当前牌的 ID 加上 "t"
            p.drawACard(gigantifyCardID, ownplay, true);

            // 触发战吼效果
            if (ownplay)
            {
                Minion m = p.ownMinions[p.ownMinions.Count - 1]; // 获取刚打出的随从

                // 从发现选项中获取选择的卡牌ID
                if (Hrtprozis.Instance.enchs.Count > 0)
                {
                    CardDB.cardIDEnum selectedCardID = Hrtprozis.Instance.enchs.LastOrDefault(); // 取出选择的卡牌ID

                    if (selectedCardID != CardDB.cardIDEnum.None)
                    {
                        // 将卡牌添加到手牌中，并调整法力值消耗
                        p.drawACard(selectedCardID, ownplay, false);
                        Handmanager.Handcard lastDrawnCard = p.owncards[p.owncards.Count - 1];

                        // 调整最后抽到的卡牌的法力值消耗
                        lastDrawnCard.manacost = Math.Max(0, lastDrawnCard.card.cost - m.Angr);
                    }
                }
            }
        }
    }
}
