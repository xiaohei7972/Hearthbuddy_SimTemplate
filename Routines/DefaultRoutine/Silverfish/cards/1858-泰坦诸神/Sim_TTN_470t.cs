using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：1 攻击力：1 生命值：1
	//Val'kyr Champion
	//瓦格里勇士
	//[x]<b>Rush</b><b>Deathrattle:</b> Give your otherVal'kyr Champions +1/+1.
	//<b>突袭</b>。<b>亡语：</b>使你的其他瓦格里勇士获得+1/+1。
	class Sim_TTN_470t : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.minionGetBuffed(m, 1, 1);
		}
		
	}
}
