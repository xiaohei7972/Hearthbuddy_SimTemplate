using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_621t21 : SimTemplate //* 神秘羊毛 Mystic Wool
//Transform a random enemy minion into a 1/1 Sheep.@Polymorph a random enemy minion.
//随机使一个敌方随从变形成为1/1的绵羊。@随机使一个敌方随从变形。 
	{
		
		
		private CardDB.Card sheep = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_621_m5);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			target = (ownplay) ? p.searchRandomMinion(p.enemyMinions, searchmode.searchLowestAttack) : p.searchRandomMinion(p.ownMinions, searchmode.searchLowestAttack);
			if (target != null) p.minionTransform(target, sheep);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 1),
            };
        }
    }
}