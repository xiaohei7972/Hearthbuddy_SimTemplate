using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：5 生命值：5
	//Astalor, the Protector
	//护卫阿斯塔洛
	//<b>Battlecry:</b> Add Astalor, the Flamebringer to your hand. <b>Manathirst (@):</b> Gain 5 Armor.
	//<b>战吼：</b>将火焰使者阿斯塔洛置入你的手牌。<b>法力渴求（@）：</b>获得5点护甲值。
	class Sim_RLK_222t1 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.RLK_222t2, own.own, true);
		}

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			if (p.ownMaxMana >= hc.card.Manathirst)
				p.ownHero.armor += 5;

		}

	}
}
