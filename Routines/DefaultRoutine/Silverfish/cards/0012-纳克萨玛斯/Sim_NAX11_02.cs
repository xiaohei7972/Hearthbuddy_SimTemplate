using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX11_02 : SimTemplate //* 毒云 Poison Cloud
//<b>Hero Power</b>Deal 1 damage to all minions. If any die, summon a slime.
//<b>英雄技能</b>对所有随从造成1点伤害。每死亡一个随从，召唤一个泥浆怪。 
	{
		
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NAX11_03);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getHeroPowerDamage(1) : p.getEnemyHeroPowerDamage(1);
			p.allMinionsGetDamage(dmg);
			
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            foreach (Minion m in p.ownMinions)
            {
				if (m.Hp <= 0) p.callKid(kid, place, ownplay);
			}
            foreach (Minion m in p.enemyMinions)
            {
				if (m.Hp <= 0) p.callKid(kid, place, ownplay);
			}
		}
	}
}