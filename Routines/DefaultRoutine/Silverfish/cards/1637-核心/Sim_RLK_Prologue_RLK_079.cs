using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：1 攻击力：1 生命值：2
	//Noxious Cadaver
	//喷毒尸骸
	//[x]<b>Battlecry</b>: Deal 2 damageto an enemy and your hero.
	//<b>战吼：</b>对一个敌人和你的英雄造成2点伤害。
	class Sim_RLK_Prologue_RLK_079 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if(target!=null){
				p.minionGetDamageOrHeal(target,2);
				p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero,2);
			}
        }

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
			};
        }
		
	}
}
