using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：2 攻击力：1 生命值：2
	//Cinderfin
	//烬鳍鱼人
	//<b>Deathrattle:</b> Summon a 2/1 Sizzling Cinder.
	//<b>亡语：</b>召唤一个2/1的炽烈烬火。
	class Sim_TLC_225 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_249);
        public override void onDeathrattle(Playfield p, Minion m)
        {
			p.callKid(kid, m.zonepos - 1, m.own);
        }
		
	}
}
