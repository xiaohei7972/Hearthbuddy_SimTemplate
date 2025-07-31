using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：6 攻击力：4 生命值：5
	//Bob the Bartender
	//调酒师鲍勃
	//[x]<b>Battlecry:</b> Choosean action from theBattlegrounds!
	//<b>战吼：</b>选择一项酒馆战棋绝技！
	class Sim_BG31_BOB : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (choice == 1)
			{
				List<Minion> minions = (own.own) ? p.enemyMinions : p.ownMinions;
				foreach (Minion minion in minions)
				{
					p.minionGetFrozen(minion);
				}
			}
			else if (choice == 2)
			{
				if (target != null)
				{
					p.drawACard(target.handcard.card.cardIDenum, own.own, true);
					p.drawACard(CardDB.cardIDEnum.GAME_005, !own.own, true);
					p.drawACard(CardDB.cardIDEnum.GAME_005, !own.own, true);
					p.drawACard(CardDB.cardIDEnum.GAME_005, !own.own, true);
				}
			}
			else if (choice == 3)
			{
				p.drawACard(CardDB.cardIDEnum.None, own.own, true);
				if (own.own)
				{
					p.mana = Math.Max(p.ownMaxMana, p.mana += 3);
				}
				else
				{
					// p.enemyMaxMana = Math.Max(p.enemyMaxMana, p.mana += 3);

				}
			}
			else if (choice == 4)
			{
				if (own.own)
				{
					foreach (var item in p.prozis.turnDeck)
					{
						CardDB.Card card = CardDB.Instance.getCardDataFromID(item.Key);
						if (card.type == CardDB.cardtype.MOB)
						{
							p.drawACard(item.Key, own.own);
							p.drawACard(item.Key, own.own, true);
							p.drawACard(item.Key, own.own, true);

						}
					}
				}
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
			};
		}

	}
}
