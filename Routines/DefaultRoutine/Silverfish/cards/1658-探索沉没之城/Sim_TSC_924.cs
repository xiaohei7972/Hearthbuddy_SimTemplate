using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：6
	//Abyssal Wave
	//深渊波流
	//[x]Deal $4 damage toall minions. Give youropponent an AbyssalCurse.
	//对所有随从造成$4点伤害。使你的对手获得一张深渊诅咒。
	class Sim_TSC_924 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int damage = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
			p.allMinionsGetDamage(damage);
			p.drawACard(CardDB.cardIDEnum.TSC_955t, !ownplay, true);
        }
		
	}
}
