using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：3
	//Rest in Peace
	//安息
	//[x]Each player summonstheir highest Cost minionthat died this game.
	//每个玩家分别召唤其在本局对战中死亡的法力值消耗最高的随从。
	class Sim_VAC_457 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 寻找己方墓地中费用最高的随从
            CardDB.Card highestOwnMinion = null;
            int highestOwnCost = -1;

            foreach (KeyValuePair<CardDB.cardIDEnum, int> entry in Probabilitymaker.Instance.ownGraveyard)
            {
                CardDB.Card card = CardDB.Instance.getCardDataFromID(entry.Key);
                if (card.type == CardDB.cardtype.MOB && card.cost > highestOwnCost)
                {
                    highestOwnCost = card.cost;
                    highestOwnMinion = card;
                }
            }

            // 寻找敌方墓地中费用最高的随从
            CardDB.Card highestEnemyMinion = null;
            int highestEnemyCost = -1;

            foreach (KeyValuePair<CardDB.cardIDEnum, int> entry in Probabilitymaker.Instance.enemyGraveyard)
            {
                CardDB.Card card = CardDB.Instance.getCardDataFromID(entry.Key);
                if (card.type == CardDB.cardtype.MOB && card.cost > highestEnemyCost)
                {
                    highestEnemyCost = card.cost;
                    highestEnemyMinion = card;
                }
            }

            // 召唤己方的最高费用随从
            if (highestOwnMinion != null)
            {
                p.callKid(highestOwnMinion, p.ownMinions.Count, true);
            }

            // 召唤敌方的最高费用随从
            if (highestEnemyMinion != null)
            {
                p.callKid(highestEnemyMinion, p.enemyMinions.Count, false);
            }
        }

    }
}
