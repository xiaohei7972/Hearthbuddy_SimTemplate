using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：3 攻击力：1 生命值：5
	//Tortollan Traveler
	//始祖龟旅行者
	//[x]<b>Taunt</b><b>Deathrattle:</b> Draw another<b>Taunt</b> minion. Reduceits Cost by (2).
	//<b>嘲讽</b>。<b>亡语：</b>抽一张其他<b>嘲讽</b>随从牌，其法力值消耗减少（2）点。
	class Sim_VAC_518 : SimTemplate
	{

        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 遍历己方卡组,寻找具有嘲讽的随从牌
			foreach(CardDB.Card tankCard in p.ownDeck)
			{
                CardDB.Card card = CardDB.Instance.getCardDataFromID(tankCard.cardIDenum);
                if(card.type == CardDB.cardtype.MOB && card.tank){
					// 给抽到的嘲讽牌-2费
                    card.cost -= 2;
					p.drawACard(tankCard.cardIDenum, m.own, true);
                    break;
                }
			}

        }
    }
}
