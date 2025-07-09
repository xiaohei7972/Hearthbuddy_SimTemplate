using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：4 攻击力：5 生命值：4
	//Ravasaur Matriarch
	//暴掠龙女王
	//[x]<b>Kindred:</b> Deal damage toan enemy minion equal tothis minion's Attack.
	//<b>延系：</b>对一个敌方随从造成等同于本随从攻击力的伤害。
	class Sim_TLC_825 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
        {
			if (target != null)
			{
				//TODO:有延系方法再加一个if判断
				p.minionGetDamageOrHeal(target, hc.card.Attack);
			}
        }
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 无目标时也能用
			};
		}
		
	}
}
