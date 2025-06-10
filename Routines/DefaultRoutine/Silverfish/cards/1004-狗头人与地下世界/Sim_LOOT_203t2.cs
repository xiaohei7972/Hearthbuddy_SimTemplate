using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_203t2 : SimTemplate //* 法术秘银石 Mithril Spellstone
//Summon two 5/5 Mithril Golems. <i>(Equip a weapon to upgrade.)</i>
//召唤两个5/5的秘银魔像。<i>（装备一把武器后升级。）</i> 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_203t4);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
		}
	}
}