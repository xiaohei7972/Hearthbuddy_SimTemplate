using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：1 攻击力：1 生命值：1
	//Window Shopper
	//橱窗看客
	//[x]<b>Mini</b><b>Battlecry:</b> <b>Discover</b> aDemon. Set its stats andCost to this minion's.
	//<b>微型</b><b>战吼：</b><b>发现</b>一张恶魔牌，将其属性值与法力值消耗变为与本随从相同。
	class Sim_TOY_652t : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 发现一张恶魔牌
            if (Hrtprozis.Instance.enchs.Count > 0)
            {
                CardDB.cardIDEnum discoveredCardId = Hrtprozis.Instance.enchs.LastOrDefault();
                CardDB.Card discoveredCard = CardDB.Instance.getCardDataFromID(discoveredCardId);

                // 设置发现牌的属性和法力值消耗与本随从相同
                discoveredCard.Attack = own.Angr;
                discoveredCard.Health = own.Hp;
                discoveredCard.cost = own.handcard.card.cost;

                // 将调整后的牌加入手牌
                p.drawACard(discoveredCard.cardIDenum, own.own, true);
            }
        }
    }
}
