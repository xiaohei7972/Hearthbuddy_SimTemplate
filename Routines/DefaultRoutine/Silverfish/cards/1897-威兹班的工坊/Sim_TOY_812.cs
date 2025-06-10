using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：7 攻击力：4 生命值：4
	//Pipsi Painthoof
	//皮普希·彩蹄
	//[x]<b>Deathrattle:</b> Summon arandom <b>Divine Shield</b>,<b>Rush</b>, and <b>Taunt</b> minionfrom your deck.
	//<b>亡语：</b>随机从你的牌库中召唤<b>圣盾</b>，<b>突袭</b>和<b>嘲讽</b>随从各一个。
	class Sim_TOY_812 : SimTemplate
	{

        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 随机从牌库中召唤一个圣盾、突袭和嘲讽随从各一个
            bool divineShieldSummoned = false;
            bool rushSummoned = false;
            bool tauntSummoned = false;

            foreach (var card in p.ownDeck)
            {
                CardDB.Card deckCard = CardDB.Instance.getCardDataFromID(card.cardIDenum);

                if (!divineShieldSummoned && deckCard.Shield)
                {
                    p.callKid(deckCard, m.zonepos, m.own);
                    divineShieldSummoned = true;
                }
                else if (!rushSummoned && deckCard.Charge)
                {
                    p.callKid(deckCard, m.zonepos, m.own);
                    rushSummoned = true;
                }
                else if (!tauntSummoned && deckCard.tank)
                {
                    p.callKid(deckCard, m.zonepos, m.own);
                    tauntSummoned = true;
                }

                // 如果三种随从都已召唤，则结束循环
                if (divineShieldSummoned && rushSummoned && tauntSummoned)
                {
                    break;
                }
            }
        }

    }
}
