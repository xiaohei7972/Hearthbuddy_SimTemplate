using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：6 攻击力：3 生命值：6
	//Scalehide Kodo
	//鳞皮科多兽
	//[x]<b>Battlecry:</b> Destroy thelowest Attack enemy minion.<b>Kindred:</b> The highestAttack instead.
	//<b>战吼：</b>消灭攻击力最低的敌方随从。<b>延系：</b>改为消灭攻击力最高的敌方随从。
	class Sim_TLC_454 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			Minion minion = p.searchRandomMinion(p.enemyMinions, searchmode.searchLowestAttack);
			//true改成延系
			// if (true)
			// 	minion = p.searchRandomMinion(p.enemyMinions, searchmode.searchHighestAttack);
			p.minionGetDestroyed(minion);
			
        }
		
	}
}
