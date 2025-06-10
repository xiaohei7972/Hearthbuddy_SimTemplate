using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：1
	//Bug Bites
	//尸虫噬咬
	//Spend 2 <b>Corpses</b> to deal $4 damage to a_minion.
	//消耗2份<b>残骸</b>，对一个随从造成$4点伤害。
	class Sim_EDR_813b : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
            p.minionGetDamageOrHeal(target, dmg);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),   // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),   // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),    // 目标必须是敌方
            };
        }
		
	}
}
