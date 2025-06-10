using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_136 : SimTemplate //* 救赎 Redemption
	{
		//<b>Secret:</b> When a friendly minion dies, return it to life with 1 Health.
		//<b>奥秘：</b>当一个友方随从死亡时，使其回到战场，并具有1点生命值。
        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            CardDB.Card kid = CardDB.Instance.getCardDataFromID(ownplay ? p.revivingOwnMinion : p.revivingEnemyMinion);
            List<Minion> tmp = ownplay ? p.ownMinions : p.enemyMinions;
            int pos = tmp.Count;

            p.callKid(kid, pos, ownplay, true, true);
            
            if (tmp.Count >= 1)
            {
                Minion summonedMinion = tmp[pos];
                if (summonedMinion.handcard.card.cardIDenum == kid.cardIDenum)
                {
                    summonedMinion.Hp = 1;
                    summonedMinion.wounded = false;
                    if (summonedMinion.Hp < summonedMinion.maxHp) summonedMinion.wounded = true;
                }
            }
        }
    }
}