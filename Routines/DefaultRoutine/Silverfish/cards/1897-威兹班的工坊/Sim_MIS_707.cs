using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：1
	//Mass Production
	//批量生产
	//Draw 2 cards. Deal $3 damage to your hero. Shuffle 2 copies of this into your deck.
	//抽两张牌。对你的英雄造成$3点伤害。将两张本牌的复制洗入你的牌库。
	class Sim_MIS_707 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 抽两张牌
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);

            // 对你的英雄造成3点伤害
            p.minionGetDamageOrHeal(p.ownHero, 3);

            // 获取当前卡牌对象
            CardDB.Card thisCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.MIS_707); // 假设本牌的ID是MIS_707

            // 将两张本牌的复制洗入你的牌库
            p.AddToDeck(thisCard);
            p.AddToDeck(thisCard);
        }
    }
}
