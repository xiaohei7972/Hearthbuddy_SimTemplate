using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_523 : SimTemplate //* 仪式重槌 Ceremonial Maul
	{
        //<b>Spellburst</b>: Summon a Student with <b>Taunt</b> and stats equal to the spell's Cost.
        //<b>法术迸发：</b>召唤一个属性值等同于法术法力值消耗的并具有<b>嘲讽</b>的学生。
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_523);
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_523t);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
		{
			if (m.own == ownplay && m.Spellburst && hc.card.type == CardDB.cardtype.SPELL)
			{
				m.Spellburst = false;
				int place = p.ownMinions.Count;
				if (place < 7)
				{
					p.callKid(kid, place, true);
					p.minionSetAngrToX(p.ownMinions[place - 1], hc.manacost);//有的silverfish里是minionSetAttackToX
					p.minionSetLifetoX(p.ownMinions[place - 1], hc.manacost);
				}
				else p.evaluatePenality += 6;
			}
		}
	}
}
