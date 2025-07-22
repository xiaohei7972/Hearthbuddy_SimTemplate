using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//法术 猎人 费用：3
	//Mismatched Fossils
	//错位化石
	//<b>Discover</b> a Beastand an Undead.Swap their stats.
	//<b>发现</b>一张野兽牌和一张亡灵牌，交换其属性值。
	class Sim_DEEP_001 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			CardDB.Card card1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.None);
			CardDB.Card card2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.None);
			if (Hrtprozis.Instance.enchs.Count > 0)
			{
				card1 = CardDB.Instance.getCardDataFromID(Hrtprozis.Instance.enchs.LastOrDefault());
				p.drawACard(card1.cardIDenum, ownplay, false); // 添加一张选中野兽牌
			}

			if (Hrtprozis.Instance.enchs.Count > 0)
			{
				card2 = CardDB.Instance.getCardDataFromID(Hrtprozis.Instance.enchs.LastOrDefault());
				p.drawACard(card2.cardIDenum, ownplay, false); // 添加一张选中的亡灵牌
			}

			Handmanager.Handcard BEASTcard = p.owncards[p.owncards.Count - 2];
			Handmanager.Handcard UNDEADcard = p.owncards[p.owncards.Count - 1];
			
			BEASTcard.card.Attack = card2.Attack;
			BEASTcard.card.Health = card2.Health;
			UNDEADcard.card.Attack = card1.Attack;
			UNDEADcard.card.Health = card1.Health;

			// int BEASTcardAttack = BEASTcard.card.Attack;
			// int BEASTcardHealth = BEASTcard.card.Health;
			// int UNDEADcarddAttack = UNDEADcard.card.Attack;
			// int UNDEADcardHealth = UNDEADcard.card.Health;

			// BEASTcard.card.Attack = UNDEADcarddAttack;
			// BEASTcard.card.Health = UNDEADcardHealth;
			// UNDEADcard.card.Attack = BEASTcardAttack;
			// UNDEADcard.card.Health = BEASTcardHealth;

		}

	}
}
