using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 巫妖王 费用：2
	//Pulsing Pumpkins
	//跃动的南瓜
	//[x]Deal $3 damage,with crushing <i>brawn!</i>My army shall be yours,if my Head is <i>drawn!</i>
	//造成$3点伤害，威力<i>无穷！</i>找到头颅，我的部队向你<i>效忠！</i>
	class Sim_TOY_829hp3 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getHeroPowerDamage(3) : p.getEnemyHeroPowerDamage(3);
				p.minionGetDamageOrHeal(target, damage);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
			};
        }
		
	}
}
