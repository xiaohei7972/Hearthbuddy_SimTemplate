using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Amulet of Critters
	//生灵护符
	//Summon arandom 4-Cost minionand give it <b>Taunt</b>.
	//随机召唤一个法力值消耗为（4）的随从并使其获得<b>嘲讽</b>。
	class Sim_VAC_959t06t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 随机召唤一个法力值消耗为4的随从
            CardDB.Card kid = p.getRandomCardForManaMinion(4);
            int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay);

            // 给予召唤的随从嘲讽效果
            Minion summonedMinion = ownplay ? p.ownMinions[pos] : p.enemyMinions[pos];
            summonedMinion.taunt = true;
        }

    }
}
