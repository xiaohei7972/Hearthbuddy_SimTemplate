using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：7 攻击力：5 生命值：8
	//Snoozin' Zookeeper
	//打盹的动物管理员
	//[x]<b>Battlecry:</b> Summon an 8/8Beast for your opponent. Itattacks all of their minions.
	//<b>战吼：</b>为你的对手召唤一只8/8的野兽，使其攻击所在方的所有随从。
	class Sim_VAC_421 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 召唤一只8/8的野兽给对手
            CardDB.Card beast = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_421t); // 假设这个ID是8/8野兽
            int pos = own.own ? p.enemyMinions.Count : p.ownMinions.Count;

            p.callKid(beast, pos, !own.own, false);

            // 获取召唤的野兽
            Minion summonedBeast = own.own ? p.enemyMinions[p.enemyMinions.Count - 1] : p.ownMinions[p.ownMinions.Count - 1];

            // 让野兽攻击所有敌方随从
            if (summonedBeast != null)
            {
                foreach (Minion m in own.own ? p.enemyMinions : p.ownMinions)
                {
                    if (m.entitiyID != summonedBeast.entitiyID) // 确保野兽不攻击自己
                    {
                        p.minionAttacksMinion(summonedBeast, m);
                    }
                }
            }
        }
    }
}
