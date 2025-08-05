using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：4 攻击力：4 生命值：5
	//Onyxian Drake
	//奥妮克希亚幼龙
	//[x]<b>Taunt</b> <b>Battlecry:</b> Deal damageequal to your Armor toan enemy minion.
	//<b>嘲讽</b>，<b>战吼：</b>对一个敌方随从造成等同于你的护甲值的伤害。
	class Sim_ONY_024 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = own.own ? p.ownHero.armor : p.enemyHero.armor;
				p.minionGetDamageOrHeal(target, damage);
			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //目标只能是敌方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), //无目标时也能使用
            };
		}
		
	}
}
