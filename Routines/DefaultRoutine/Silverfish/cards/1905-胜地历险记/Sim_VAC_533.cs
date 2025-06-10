using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：3
	//Food Fight
	//食物大战
	//Summon a 0/6 Entrée for your opponent. When it dies, summon a minion from your deck.
	//为你的对手召唤一份0/6的主菜。当它死亡时，从你的牌库中召唤一个随从。
	class Sim_VAC_533 : SimTemplate
	{

        CardDB.Card entree = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_533t); // 假设主菜的卡牌ID为 VAC_533t

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = ownplay ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(entree, pos, !ownplay); // 为对手召唤一份0/6的主菜
        }
    }
}
