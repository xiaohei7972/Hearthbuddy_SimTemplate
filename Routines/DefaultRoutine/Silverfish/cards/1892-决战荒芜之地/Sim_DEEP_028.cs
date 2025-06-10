using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：6
	//Crystal Cluster
	//晶体结积
	//Gain three empty Mana Crystals. Any that can't fit summon a 3/7 Elemental with <b>Taunt</b>.
	//获得三个空的法力水晶，每有一个超过上限的法力水晶，召唤一个3/7并具有<b>嘲讽</b>的元素。
	class Sim_DEEP_028 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DEEP_028t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

			if (ownplay) p.ownMaxMana = Math.Min(10, p.ownMaxMana + 3);
            if (p.ownMaxMana > 10)
            {
                p.callKid(kid, pos, ownplay);
            }
            else p.enemyMaxMana = Math.Min(10, p.enemyMaxMana + 3);
            if (p.enemyMaxMana > 10)
            {
				p.callKid(kid, pos, ownplay);
			}
		}
		
	}
}
