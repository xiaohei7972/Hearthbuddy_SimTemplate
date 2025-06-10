using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_EX1_091 : SimTemplate //* Cabal Shadow Priest
	{
        //Battlecry: Take control of an enemy minion that has 2 or less Attack.

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
                int num = temp.Count;
                p.minionGetControlled(target, own.own, false, true);
                if (num < 7)
                {
                    foreach (Minion m in temp)
                    {
                        if (m.name == CardDB.cardNameEN.knifejuggler && !m.silenced) m.handcard.card.sim_card.onMinionWasSummoned(p, m, temp[num]);
                    }
                }
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_MAX_ATTACK, 2),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}