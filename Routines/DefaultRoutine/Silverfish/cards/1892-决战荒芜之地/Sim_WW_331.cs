using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：2 生命值：2
	//Miracle Salesman
	//奇迹推销员
	//<b>Deathrattle:</b> Get a <b>Tradeable</b> Snake Oil.
	//<b>亡语：</b>获取一张<b>可交易</b>的蛇油。
	class Sim_WW_331 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.WW_331t, m.own, true);
        }
		
	}
}
