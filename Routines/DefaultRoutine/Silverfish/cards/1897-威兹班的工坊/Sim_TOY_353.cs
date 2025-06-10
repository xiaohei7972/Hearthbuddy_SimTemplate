using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Patchwork Pals
	//拼布好朋友
	//Get all 3 Animal Companions. Theycost (1) less.
	//获取全部3种动物伙伴，其法力值消耗减少（1）点。
	class Sim_TOY_353 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 动物伙伴的卡牌ID
            CardDB.cardIDEnum huffer = CardDB.cardIDEnum.NEW1_010;  // 霍弗
            CardDB.cardIDEnum misha = CardDB.cardIDEnum.NEW1_032;   // 米莎
            CardDB.cardIDEnum leokk = CardDB.cardIDEnum.NEW1_033;   // 雷欧克

            // 将三种动物伙伴手动添加到手牌中，并减少法力值消耗
            addCardToHand(p, huffer, ownplay);
            addCardToHand(p, misha, ownplay);
            addCardToHand(p, leokk, ownplay);
        }

        private void addCardToHand(Playfield p, CardDB.cardIDEnum cardID, bool ownplay)
        {
            CardDB.Card card = CardDB.Instance.getCardDataFromID(cardID);
            card.cost = Math.Max(0, card.cost - 1);  // 确保法力值消耗至少为0
            p.owncards.Add(new Handmanager.Handcard(card));  // 手动添加到手牌中
            p.triggerCardsChanged(ownplay);  // 触发手牌变化
        }

    }
}
