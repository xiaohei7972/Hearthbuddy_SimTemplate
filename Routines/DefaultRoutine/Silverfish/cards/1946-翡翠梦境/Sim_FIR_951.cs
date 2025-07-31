using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：8 攻击力：5 生命值：5
	//Volcoross
	//沃尔科罗斯
	//[x]<b>Rush, Taunt</b><b>Battlecry:</b> Choose to spend10, 20, or 30 <b>Corpses</b> togain that many stats.
	//<b>突袭。嘲讽</b>。<b>战吼：</b>选择消耗10份，20份或30份<b>残骸</b>以获得等量属性值。
	class Sim_FIR_951 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (choice == 1 && p.getCorpseCount() >= 10)
			{
				p.corpseConsumption(10);
				p.minionGetBuffed(own, 10, 10);
			}
			else if (choice == 2 && p.getCorpseCount() >= 20)
			{
				p.corpseConsumption(20);
				p.minionGetBuffed(own, 20, 20);

			}
			else if (choice == 3 && p.getCorpseCount() >= 30)
			{
				p.corpseConsumption(30);
				p.minionGetBuffed(own, 30, 30);

			}
		}

	}
}
