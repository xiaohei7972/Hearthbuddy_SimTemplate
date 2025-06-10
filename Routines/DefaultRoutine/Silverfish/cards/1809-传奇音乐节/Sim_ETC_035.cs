using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：5 攻击力：5 生命值：5
	//Drum Soloist
	//鼓乐独演者
	//[x]<b>Taunt</b><b>Battlecry:</b> If you controlno other minions, gain+2/+2 and <b>Rush</b>.
	//<b>嘲讽</b>。<b>战吼：</b>如果你没有控制其他随从，获得+2/+2和<b>突袭</b>。
	class Sim_ETC_035 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int num = (own.own) ? p.ownMinions.Count : p.enemyMinions.Count;
			if (num > 1)
			{
			  //
			}
			else
			{
			   p.minionGetBuffed(own, 2, 2);
			   p.minionGetRush(own);
			}
		}
	}
}
