using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：5 攻击力：7 生命值：4
	//Glaivebound Adept
	//刃缚精锐
	//<b>Battlecry:</b> If your hero attacked this turn,deal 4 damage.
	//<b>战吼：</b>在本回合中，如果你的英雄进行过攻击，则造成4点伤害。
	class Sim_TOY_913t3 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null && (own.own ? p.ownHero.allreadyAttacked : p.enemyHero.allreadyAttacked))
			{
				p.minionGetDamageOrHeal(target, 4);
			}
		}
		
		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_HERO_HAS_ATTACK), // 如果本回合英雄攻击过则有目标
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 目标只能是敌方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 无目标时也可以用
            };
        }
		
	}
}
