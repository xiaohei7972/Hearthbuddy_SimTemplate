using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：3
	//Fortify
	//强固
	//[x]Gain 3 Armor.Deal damage equalto your Armor to anenemy minion.
	//获得3点护甲值。对一个敌方随从造成等同于你护甲值的伤害。
	class Sim_TLC_620 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 3);
				int arrmor = ownplay ? p.ownHero.armor : p.enemyHero.armor;
				int damage = ownplay ? p.getSpellDamageDamage(0) : p.getEnemySpellDamageDamage(0);
				p.minionGetDamageOrHeal(target, damage + arrmor);
			}
		}


		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
            };
		}

	}
}
