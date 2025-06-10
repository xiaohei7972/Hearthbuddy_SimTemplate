using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：0
	//Healthstone
	//治疗石
	//<b>Tradeable</b>Restore all damage your hero has taken this turn.@<i>(@)</i>
	//<b>可交易</b>恢复你的英雄在本回合中受到的所有伤害。@<i>（恢复@点）</i>
	class Sim_GDB_125 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int heal = (ownplay) ? p.getSpellDamageDamage(choice) : p.getEnemySpellDamageDamage(choice); // 获取英雄在本回合中受到的伤害
			p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -heal); // 恢复英雄受到的伤害
			

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 要求目标为友方
				new PlayReq(CardDB.ErrorType2.REQ_HERO_TARGET), // 要求目标为英雄
			};
		}
		
	}
}
