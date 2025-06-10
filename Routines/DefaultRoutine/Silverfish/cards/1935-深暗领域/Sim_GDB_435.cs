using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：2 生命值：2
	//Moonstone Mauler
	//月石重拳手
	//[x]<b>Battlecry:</b> Shuffle 3Asteroids into your deck thatdeal @ damage to a randomenemy when drawn.
	//<b>战吼：</b>将3张小行星洗入你的牌库。当抽到小行星时会对一个随机敌人造成@点伤害。
	class Sim_GDB_435 : SimTemplate
	{
		CardDB.Card eruptionCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GDB_430); // 小行星
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			for (int i = 0; i < 3; i++) // 洗入3张小行星
			{
				p.AddToDeck(eruptionCard);
			}
		}
	}
}
