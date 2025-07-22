using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_085 : SimTemplate //* 暗巷契约 Dark Alley Pact
	{
		//[x]Summon a Fiendwith stats equal toyour hand size.
		//召唤一个属性值等同于你的手牌数量的邪魔。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_085t); 
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int place = p.ownMinions.Count;
			if (place < 7)
			{
				p.callKid(kid, place, true);
				p.minionSetAngrToX(p.ownMinions[place - 1], p.owncards.Count);
				p.minionSetLifetoX(p.ownMinions[place - 1], p.owncards.Count);
			}
        }
		
	}
}
