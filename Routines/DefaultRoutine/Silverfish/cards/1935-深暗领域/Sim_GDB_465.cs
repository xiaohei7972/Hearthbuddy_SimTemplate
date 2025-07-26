using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：3
	//Barrel Roll
	//桶滚动作
	//[x]Deal $5 damage to anundamaged character.Costs (1) if you'rebuilding a <b>Starship</b>.
	//对一个未受伤的角色造成$5点伤害。如果你正在构筑<b>星舰</b>，则法力值消耗为（1）点。
	class Sim_GDB_465 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
				p.minionGetDamageOrHeal(target, damage);
				
			}

		}

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_DAMAGED_TARGET), // 只能是受伤的目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
			};

		}
		
	}
}
