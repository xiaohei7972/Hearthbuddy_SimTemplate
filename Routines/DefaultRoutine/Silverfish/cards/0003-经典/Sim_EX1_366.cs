using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_366 : SimTemplate //* 公正之剑 Sword of Justice
	{
		//After you summon a minion, give it +1/+1 and this loses 1_Durability.
		//在你召唤一个随从后，使其获得+1/+1，这把武器失去1点耐久度。
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_366);


		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.equipWeapon(card,ownplay);
		}

        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.own == summonedMinion.own )
            {
                p.minionGetBuffed(summonedMinion, 1, 1);
                p.lowerWeaponDurability(1, triggerEffectMinion.own);
            }
        }
	}
}