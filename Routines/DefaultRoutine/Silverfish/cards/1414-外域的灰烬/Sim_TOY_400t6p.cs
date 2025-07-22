using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 恶魔猎手 费用：1
	//Demonic Blast
	//恶魔冲击
	//Deal $5 damage.<i>(Two uses left!)</i>
	//造成$5点伤害。<i>（还可使用两次！）</i>
	class Sim_TOY_400t6p : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getHeroPowerDamage(5) : p.getEnemyHeroPowerDamage(5);
			p.minionGetDamageOrHeal(target, dmg);
			p.setNewHeroPower(CardDB.cardIDEnum.TOY_400t6p2, ownplay);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
            };
        }
		
	}
}
