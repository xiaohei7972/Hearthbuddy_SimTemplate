using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：4
	//Judge Unworthy
	//审判恶徒
	//Set an enemy minion's Health to 1, then deal $1 damage to all enemies.
	//将一个敌方随从的生命值变为1，然后对所有敌人造成$1点伤害。
	class Sim_TTN_853 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
				target.Hp = 1;
				target.maxHp = 1;
				p.allCharsOfASideGetDamage(!ownplay, damage);
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 目标只能是敌方
            };
		} 

	}
}
