using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：5
	//Altered Chord
	//变音和弦
	//<b>Lifesteal</b>Deal $6 damage to aminion. Costs (3) lessif you're <b>Overloaded</b>.
	//<b>吸血</b>。对一个随从造成$6点伤害。如果你有<b>过载</b>的法力水晶，本牌的法力值消耗减少（3）点。
	class Sim_ETC_356 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(6) : p.getEnemySpellDamageDamage(6);
				p.minionGetDamageOrHeal(target, damage);
				p.applySpellLifesteal(damage, ownplay);
			}
		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //只能是随从
			};
		}
		
	}
}
