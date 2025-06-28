using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：3
	//Resonance Coil
	//谐振盘
	//Deal $5 damage to a minion. Get a random Protoss spell.
	//对一个随从造成$5点伤害。随机获取一张星灵法术牌。
	class Sim_SC_760 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
				p.minionGetDamageOrHeal(target, damage);
				p.drawACard(CardDB.cardIDEnum.SC_753, ownplay, ownplay);
			}

		}

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标只能是随从
			};

		}
		
	}
}
