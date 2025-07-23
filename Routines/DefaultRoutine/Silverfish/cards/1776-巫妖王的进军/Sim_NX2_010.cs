using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：6 攻击力：6 生命值：6
	//Death Beetle
	//死亡甲虫
	//<b>Taunt</b><b>Manathirst (@):</b> Gain +4/+4 and <b>Charge</b>.
	//<b>嘲讽</b>。<b>法力渴求（@）：</b>获得+4/+4和<b>冲锋</b>。
	class Sim_NX2_010 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			if (p.ownMaxMana >= hc.card.Manathirst)
			{
				hc.addattack += 4;
				hc.addHp += 4;
				hc.card.Charge = true;
			}
		}

	}
}
