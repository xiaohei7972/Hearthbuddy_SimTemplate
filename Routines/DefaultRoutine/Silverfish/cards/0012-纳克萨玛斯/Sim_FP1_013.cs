using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_FP1_013 : SimTemplate //* 克尔苏加德 Kel'Thuzad
//At the end of each turn, summon all friendly minions that died this turn.
//在每个回合结束时，召唤所有在本回合中死亡的友方随从。 
	{
        

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            foreach (GraveYardItem gyi in p.diedMinions.ToArray()) 
            {
                if (gyi.own == triggerEffectMinion.own)
                {
                    CardDB.Card card = CardDB.Instance.getCardDataFromID(gyi.cardid);
                    int pos = triggerEffectMinion.own ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.callKid(card, p.ownMinions.Count, gyi.own);
                }
            }
        }
	}
}